using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.DataAccess;

namespace Study_Buddy.BusinessLogic
{
    public class AccountController
    {
        public static Account account { get; set; } = new Account("name","");
    }
}
