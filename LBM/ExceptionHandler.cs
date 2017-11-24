using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBM
{
    public class ExceptionHandler
    {
        public ExceptionHandler() { }

        public static string GetExceptionDetails(Exception exc)
        {
            string errMsg = exc.Message;
            errMsg += Environment.NewLine;
            if (exc.InnerException != null)
            {
                errMsg += exc.InnerException.Message;
                errMsg += Environment.NewLine;
            }
            errMsg += exc.StackTrace;    
            return errMsg;
        }
    }
}
