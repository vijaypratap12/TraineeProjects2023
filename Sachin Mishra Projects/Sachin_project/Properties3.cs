using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project
{
    internal class Properties3
    {
        string _email;
        double _salary;

        public string Email
        {
            get {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public double Salary
        { 
            get { 
                return _salary;
            } 
            set 
            { 
                _salary = value;
            } 
        }
    }
}
