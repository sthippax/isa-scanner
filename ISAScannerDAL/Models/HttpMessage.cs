using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAScannerDAL.Models
{
    public class HttpMessage
    {
        public ErrorMessage GetOops()
        {
            ErrorMessage errmsg = new ErrorMessage();
            errmsg.message = "Oops something went wrong !!!";
            return errmsg;
        }    
        public string GetLogin(string s)
        {
            int stop = s.IndexOf("\\");
            return (stop > -1) ? s.Substring(stop + 1, s.Length - stop - 1) : null;
        }
    }
    /// <summary>
    /// return error message 
    /// </summary>
    public class ErrorMessage
    {
        public string message { get; set; }
    }
    /// <summary>
    /// return message status 
    /// </summary>
    public class MessageStatus
    {
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
