using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeWaaiBeheer
{
    public partial class Users
    {
        public string Fullname
        {
            get { return string.Format("{0} {1}",this.Firstname,string.Format("{0} {1}",this.Insertion,this.Surname)).Trim(); }
        }
    }
}
