using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project
{
    internal class Properties1
    {
        string _name;
        int _age;
        public string Name {
            get{
                return _name;
            }
            set { 
                _name = value;
            } 
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
