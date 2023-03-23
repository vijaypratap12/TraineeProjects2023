using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project
{
    internal class Properties2
    {
        string _address;
        string _mobile;

        public string Address
        {
            get { return _address; }    
            set { _address = value; }
        }

        public string Mobile {
            get { return _mobile; }
            set {  _mobile = value; }
        }
    }
}
