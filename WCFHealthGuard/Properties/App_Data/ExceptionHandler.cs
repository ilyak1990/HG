using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WCFHealthGuard
{
    public sealed class ExceptionHandler
    {
        private void ExceptionUtility()
        {

        }
        public static void LogException(Exception exc, string source)
        {
            string logFile = "/App_Data/ErrorLog.txt";
            logFile = HttpContext.Current.Server.MapPath(logFile);
            // Open the log file for append and write the log 
            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("********** {0} **********", DateTime.Now);
            if (exc.InnerException != null)
            {
                sw.Write("Inner Exception Type: ");
                sw.WriteLine(exc.InnerException.GetType().ToString());
                sw.Write("Inner Exception: ");
                sw.WriteLine(exc.InnerException.Message);
                sw.Write("Exception Type: ");
                sw.WriteLine(exc.GetType().ToString());
                sw.WriteLine("Exception: " + exc.Message);
                sw.WriteLine("Source: " + source);
                sw.WriteLine("Stack Trace: ");
                if (exc.StackTrace != null)
                {
                    sw.WriteLine(exc.StackTrace);
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        // Notify System Operators about an exception 
        public static void NotifySystemOps(Exception exc)
        {
            // Include code for notifying IT system operators 
        }

    }
}