using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business.User
{
    public class Admin : UI.User 
    {
        public int adminID { get; set; }

        public Admin (int ID)
        {
            this.adminID = ID;
        }
    }
    
    
}

