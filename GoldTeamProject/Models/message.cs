using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject.Models
{
    public class Message
    {
        public int ID { get; set; }
        public DateTime DateSent { get; set; }
        public string Messages { get; set;}

        //public int TransactionID { get; set; }
    }
}