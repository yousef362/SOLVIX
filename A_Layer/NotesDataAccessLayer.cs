using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using SettingConnection;

namespace A_Lyer
{
    /*
     * طبقة الوصول لبيانات الملاحظات.
     * تستقبل قيم SQL المرسلة من Business Layer وتنفذ SELECT/INSERT/UPDATE/DELETE.
     * تعيد سجلات الملاحظات والإحصاءات ولا تحتوي على منطق واجهة المستخدم.
     */
    public sealed class NotesDataAccessLayer
    {
        private static SqliteConnection OpenConnection()
        {
            var connection = new SqliteConnection(
                SettingDataAccessLayer.ConnectionString);

            connection.Open();
            return connection;
        }

        public List<NoteRecord> GetAll(
            string? search = null,
            string filter = "All")
        {
            var result = new List<NoteRecord>();

            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                SELECT
                    Id,
                    Title,
                    Content,
                    Category,
                    IsImportant,
                    IsPinned,
                    CreatedAt,
                    UpdatedAt
                FROM Notes
                WHERE
                    ($search = ''
                     OR Title LIKE $like
                     OR Content LIKE $like)
                    AND
                    (
                        $filter = 'All'
                        OR ($filter = 'Important' AND IsImportant = 1)
                        OR ($filter = 'Pinned' AND IsPinned = 1)
                    )
                ORDER BY IsPinned DESC, UpdatedAt DESC, Id DESC;
                """;

            string term = search?.Trim() ?? string.Empty;

            command.Parameters.AddWithValue("$search", term);
            command.Parameters.AddWithValue("$like", $"%{term}%");
            command.Parameters.AddWithValue("$filter", filter);

            using var reader = command.ExecuteReader();

            while (reader.Read())
                result.Add(Map(reader));

            return result;
        }

        public NoteRecord? GetById(int id)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                SELECT
                    Id,
                    Title,
                    Content,
                    Category,
                    IsImportant,
                    IsPinned,
                    CreatedAt,
                    UpdatedAt
                FROM Notes
                WHERE Id = $id
                LIMIT 1;
                """;

            command.Parameters.AddWithValue("$id", id);

            using var reader = command.ExecuteReader();
            return reader.Read() ? Map(reader) : null;
        }

        public int Insert(
            string title,
            string content,
            string? category,
            bool important,
            bool pinned,
            string createdAt,
            string updatedAt)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                INSERT INTO Notes
                    (Title, Content, Category, IsImportant, IsPinned, CreatedAt, UpdatedAt)
                VALUES
                    ($title, $content, $category, $important, $pinned, $created, $updated);

                SELECT last_insert_rowid();
                """;

            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$content", content);
            command.Parameters.AddWithValue(
                "$category",
                string.IsNullOrWhiteSpace(category) ? DBNull.Value : category);
            command.Parameters.AddWithValue("$important", important ? 1 : 0);
            command.Parameters.AddWithValue("$pinned", pinned ? 1 : 0);
            command.Parameters.AddWithValue("$created", createdAt);
            command.Parameters.AddWithValue("$updated", updatedAt);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Update(
            int id,
            string title,
            string content,
            string? category,
            bool important,
            bool pinned,
            string updatedAt)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                UPDATE Notes
                SET
                    Title = $title,
                    Content = $content,
                    Category = $category,
                    IsImportant = $important,
                    IsPinned = $pinned,
                    UpdatedAt = $updated
                WHERE Id = $id;
                """;

            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$content", content);
            command.Parameters.AddWithValue(
                "$category",
                string.IsNullOrWhiteSpace(category) ? DBNull.Value : category);
            command.Parameters.AddWithValue("$important", important ? 1 : 0);
            command.Parameters.AddWithValue("$pinned", pinned ? 1 : 0);
            command.Parameters.AddWithValue("$updated", updatedAt);

            return command.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = "DELETE FROM Notes WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);

            return command.ExecuteNonQuery() > 0;
        }

        public bool UpdateFlags(
            int id,
            bool important,
            bool pinned,
            string updatedAt)
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                UPDATE Notes
                SET IsImportant = $important,
                    IsPinned = $pinned,
                    UpdatedAt = $updated
                WHERE Id = $id;
                """;

            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$important", important ? 1 : 0);
            command.Parameters.AddWithValue("$pinned", pinned ? 1 : 0);
            command.Parameters.AddWithValue("$updated", updatedAt);

            return command.ExecuteNonQuery() > 0;
        }

        public NoteStatistics GetStatistics()
        {
            using var connection = OpenConnection();
            using var command = connection.CreateCommand();

            command.CommandText = """
                SELECT
                    COUNT(*),
                    COALESCE(SUM(CASE WHEN IsImportant = 1 THEN 1 ELSE 0 END), 0),
                    COALESCE(SUM(CASE WHEN IsPinned = 1 THEN 1 ELSE 0 END), 0),
                    COALESCE(SUM(
                        CASE
                            WHEN date(CreatedAt) = date('now', 'localtime')
                              OR date(UpdatedAt) = date('now', 'localtime')
                            THEN 1 ELSE 0
                        END
                    ), 0)
                FROM Notes;
                """;

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return new NoteStatistics();

            return new NoteStatistics
            {
                Total = reader.GetInt32(0),
                Important = reader.GetInt32(1),
                Pinned = reader.GetInt32(2),
                Today = reader.GetInt32(3)
            };
        }

        private static NoteRecord Map(SqliteDataReader reader)
        {
            return new NoteRecord
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Content = reader.GetString(2),
                Category = reader.IsDBNull(3) ? null : reader.GetString(3),
                IsImportant = reader.GetInt32(4) == 1,
                IsPinned = reader.GetInt32(5) == 1,
                CreatedAt = reader.GetString(6),
                UpdatedAt = reader.GetString(7)
            };
        }
    }

    public sealed class NoteRecord
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public string Content { get; init; } = string.Empty;
        public string? Category { get; init; }
        public bool IsImportant { get; init; }
        public bool IsPinned { get; init; }
        public string CreatedAt { get; init; } = string.Empty;
        public string UpdatedAt { get; init; } = string.Empty;
    }

    public sealed class NoteStatistics
    {
        public int Total { get; init; }
        public int Important { get; init; }
        public int Pinned { get; init; }
        public int Today { get; init; }
    }
}
