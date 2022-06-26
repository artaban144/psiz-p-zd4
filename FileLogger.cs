using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd4
{
    public class FileLogger
    {
        public static void LogMessage(string message)
        {
            File.AppendAllText("logs.txt",
                   "[" + GetCurrentDateTimeString() + "] " + message + Environment.NewLine);
        }

        private static string GetCurrentDateTimeString()
        {
            return DateTime.Now.ToString();
        }
    }
}
