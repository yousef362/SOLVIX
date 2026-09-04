using A_Lyer;
using System;
using System.Collections.Generic;

namespace B__Lyer
{
    /*
     * طبقة الأعمال للملاحظات.
     * تستقبل مدخلات الفورم وتتحقق منها ثم تستدعي DataAccess.
     * تعيد بيانات منظمة ونتيجة نجاح/فشل مع رسالة عربية.
     */
    public sealed class NotesBusinessLayer
    {
        private readonly NotesDataAccessLayer _dataAccess = new();

        public List<NoteItem> GetNotes(
            string? search = null,
            string filter = "All")
        {
            var records = _dataAccess.GetAll(search, filter);
            var result = new List<NoteItem>(records.Count);

            foreach (var record in records)
                result.Add(Map(record));

            return result;
        }

        public NoteItem? GetNote(int id)
        {
            NoteRecord? record = _dataAccess.GetById(id);
            return record == null ? null : Map(record);
        }

        public NoteStatistics GetStatistics()
        {
            var value = _dataAccess.GetStatistics();

            return new NoteStatistics
            {
                Total = value.Total,
                Important = value.Important,
                Pinned = value.Pinned,
                Today = value.Today
            };
        }

        public OperationResult AddNote(
            string title,
            string content,
            string? category,
            bool important,
            bool pinned)
        {
            string error = Validate(title, content);

            if (error.Length > 0)
                return OperationResult.Fail(error);

            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            int id = _dataAccess.Insert(
                title.Trim(),
                content.Trim(),
                NormalizeCategory(category),
                important,
                pinned,
                now,
                now);

            return OperationResult.Success(id, "تمت إضافة الملاحظة بنجاح.");
        }

        public OperationResult UpdateNote(
            int id,
            string title,
            string content,
            string? category,
            bool important,
            bool pinned)
        {
            if (id <= 0)
                return OperationResult.Fail("رقم الملاحظة غير صالح.");

            string error = Validate(title, content);

            if (error.Length > 0)
                return OperationResult.Fail(error);

            if (_dataAccess.GetById(id) == null)
                return OperationResult.Fail("الملاحظة غير موجودة.");

            bool updated = _dataAccess.Update(
                id,
                title.Trim(),
                content.Trim(),
                NormalizeCategory(category),
                important,
                pinned,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            return updated
                ? OperationResult.Success(id, "تم تحديث الملاحظة بنجاح.")
                : OperationResult.Fail("تعذر تحديث الملاحظة.");
        }

        public OperationResult DeleteNote(int id)
        {
            bool deleted = id > 0 && _dataAccess.Delete(id);

            return deleted
                ? OperationResult.Success(id, "تم حذف الملاحظة بنجاح.")
                : OperationResult.Fail("الملاحظة غير موجودة.");
        }

        public OperationResult TogglePinned(int id)
        {
            var note = _dataAccess.GetById(id);

            if (note == null)
                return OperationResult.Fail("الملاحظة غير موجودة.");

            bool updated = _dataAccess.UpdateFlags(
                id,
                note.IsImportant,
                !note.IsPinned,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            return updated
                ? OperationResult.Success(
                    id,
                    note.IsPinned
                        ? "تم إلغاء تثبيت الملاحظة."
                        : "تم تثبيت الملاحظة.")
                : OperationResult.Fail("تعذر تغيير حالة التثبيت.");
        }

        private static string Validate(string? title, string? content)
        {
            if (string.IsNullOrWhiteSpace(title))
                return "اكتب عنوان الملاحظة أولًا.";

            if (title.Trim().Length > 200)
                return "العنوان يجب ألا يتجاوز 200 حرف.";

            if (string.IsNullOrWhiteSpace(content))
                return "اكتب محتوى الملاحظة أولًا.";

            return string.Empty;
        }

        private static string? NormalizeCategory(string? category)
        {
            return string.IsNullOrWhiteSpace(category)
                ? null
                : category.Trim();
        }

        private static NoteItem Map(NoteRecord record)
        {
            return new NoteItem
            {
                Id = record.Id,
                Title = record.Title,
                Content = record.Content,
                Category = record.Category,
                IsImportant = record.IsImportant,
                IsPinned = record.IsPinned,
                CreatedAt = record.CreatedAt,
                UpdatedAt = record.UpdatedAt
            };
        }
    }

    public sealed class NoteItem
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

    public sealed class OperationResult
    {
        public bool Succeeded { get; init; }
        public int Id { get; init; }
        public string Message { get; init; } = string.Empty;

        public static OperationResult Success(int id, string message) =>
            new OperationResult
            {
                Succeeded = true,
                Id = id,
                Message = message
            };

        public static OperationResult Fail(string message) =>
            new OperationResult
            {
                Succeeded = false,
                Message = message
            };
    }
}
