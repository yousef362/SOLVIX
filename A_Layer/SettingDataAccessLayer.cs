using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SettingConnection
{
    public static class SettingDataAccessLayer
    {

        public static string ConnectionString =
    $@"Data Source={Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "SOLVIX.db")};";
    }
}
