using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml;

namespace CoronaApp.Services.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public XmlDocument Properties { get; set; }
        public string LogEvent { get; set; }
    }
}
