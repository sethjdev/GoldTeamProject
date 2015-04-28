using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId {get; set;}
        public int ProductId {get; set;}
        public int MessagesId {get; set;}
        
        public int UserID {get; set;}
        public virtual User user { get; set; }

    }
}