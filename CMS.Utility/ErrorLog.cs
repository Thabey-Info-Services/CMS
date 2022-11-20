using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Utility
{
    public class ErrorLog : IDisposable
    {
        #region Properties

        static string slogfilepath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\SMS_Log");
        static string sSemesterLog = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\SemesterMarks_Log");
        //static string ImportFileName = "StudentImportInfo.txt";
        #endregion
        public ErrorLog()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Method used to write the exception passed an an arugement to targetted text file
        /// in a new line
        /// </summary>
        /// <param name="ex"></param>
        public void WriteError(Exception ex)
        {
            try
            {
                //Open the file
                WriteLog("-----------------------------------------------------------------------------------------");
                WriteLog("Date      :" + DateTime.Now.ToShortDateString());
                WriteLog("Time      :" + DateTime.Now.ToShortTimeString());
                WriteLog("Exception :" + ex.ToString());
                WriteLog("Source    :" + ex.Source);
                WriteLog("StackTrace:" + ex.StackTrace);
                WriteLog("-----------------------------------------------------------------------------------------");
            }
            catch (Exception msg)
            {
                WriteLog(msg.Message);
            }
        }
        /// <summary>
        /// Method used to write the exception passed an an arugement to targetted text file
        /// in a new line
        /// </summary>
        /// <param name="ex"></param>
        public void importError(string sName, string sAdmissionNo, string ClassId, string errMessage)
        {
            ImportLog("-----------------------------------------------------------------------------------------");
            ImportLog("Date      :" + DateTime.Now.ToShortDateString());
            ImportLog("Time      :" + DateTime.Now.ToShortTimeString());
            ImportLog("Student Name :" + sName);
            ImportLog("Admission No :" + sAdmissionNo);
            ImportLog("ErrorMessage :" + errMessage);
            ImportLog("-----------------------------------------------------------------------------------------");
        }

        private static void ImportLog(string sMessage)
        {
            string _sDirectorypath = string.Empty;
            // bool _bSuccess = true;
            _sDirectorypath = string.Concat("\\Producct");
            try
            {
                StreamWriter sw = File.AppendText((_sDirectorypath + ""));
                sMessage = ("::" + sMessage);
                sw.WriteLine(sMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }
        /// <summary>
        /// This method is to write the passed error message and other details of error occurence
        /// </summary>
        /// <param name="sMessage">string - Error message</param>
        private static void WriteLog(string sMessage)
        {
            try
            {
                string filename = string.Empty;
                //check if the directory exists
                if (!Directory.Exists(slogfilepath))
                {
                    Directory.CreateDirectory(slogfilepath);
                }
                filename = string.Concat(slogfilepath, "\\", "SMS", DateTime.Today.ToShortDateString().Replace("/", "_"), ".log"); //create log file daily basis if exception is thorwn
                StreamWriter sw = File.AppendText(filename);
                sMessage = ("::" + sMessage);
                sw.WriteLine(sMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }
        /// <summary>
        /// Method used to write the exception passed an an arugement to targetted text file
        /// in a new line
        /// </summary>
        /// <param name="ex"></param>
        public void WriteError(string className, string methodName, string query, string errMessage)
        {
            try
            {
                WriteLog("-----------------------------------------------------------------------------------------");
                WriteLog("Date      :" + DateTime.Now.ToShortDateString());
                WriteLog("Time      :" + DateTime.Now.ToShortTimeString());
                WriteLog("ClassName :" + className);
                WriteLog("MethodName :" + methodName);
                if (!string.IsNullOrEmpty(query))
                    WriteLog("Query :" + query);
                WriteLog("ErrorMessage :" + errMessage);
                WriteLog("-----------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }


        /// <summary>
        /// Method used to write the exception passed an an arugement to targetted text file
        /// in a new line
        /// </summary>
        /// <param name="ex"></param>
        public void WriteError(string className, string methodName, string errMessage)
        {
            try
            {
                //WriteLog("-----------------------------------------------------------------------------------------");
                //WriteLog("Date      :" + DateTime.Now.ToShortDateString());
                //WriteLog("Time      :" + DateTime.Now.ToShortTimeString());
                //WriteLog("ClassName :" + className);
                //WriteLog("MethodName :" + methodName);
                //WriteLog("ErrorMessage :" + errMessage);
                //WriteLog("-----------------------------------------------------------------------------------------");
                WriteLog(errMessage);
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }


        // Save Student Semester Marks ,..
        public void WriteSemesterMark(string sMessage, string sStudentId, string sQuestionId, string sExamSettingId)
        {
            try
            {
                SemesterMarksLog(sMessage, sStudentId, sQuestionId, sExamSettingId);
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }


        // Create Write Log ,..
        private static void SemesterMarksLog(string sMessage, string sStudentId, string sQuestionId, string sExamSettingId)
        {
            try
            {
                string filename = string.Empty;
                string _sDirectorypath = string.Empty;
                _sDirectorypath = AppDomain.CurrentDomain.BaseDirectory + "\\" + @"SemesterMarks_Log";

                //check if the directory exists
                if (!Directory.Exists(_sDirectorypath))
                {
                    Directory.CreateDirectory(_sDirectorypath);
                }
                //filename = string.Concat(_sDirectorypath + "\\" + "Exam_Id" + sExamSettingId + "\\" + "Student_Id" + sStudentId + "\\" + "Question" + sQuestionId + ".log"); //create log file When Semester Marks Insert ,..
                filename = string.Concat(_sDirectorypath, "\\", "SemesterMarks_Log"); //create log file When Semester Marks Insert ,..
                StreamWriter sw = File.AppendText(filename);
                sw.WriteLine(sMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                string sErrorMessage = ex.Message;
            }
        }
        public void Dispose()
        {
            GC.Collect();
        }

    }
}
