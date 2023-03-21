using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madhu_MCN_Trainee
{
    public class SampleModal
    {
        public static void Main(string[] args)
        {
            person per = new person();
            male me = new male();
            female fe = new female();
            per.person_name = "priyanshu";
            per.person_id = 23;
            per.person_address = "mcn h-217";
            
            me.male_name = "sachin";
            me.male_id =24;
            me.male_address = "mcn h-217";
            
            fe.female_name = "simran";
            fe.female_id = 25;
            fe.female_address = "mcn h-217";


            Console.WriteLine(per.person_name +" whose id is "+ per.person_id+" lives in "+per.person_address);
            Console.WriteLine(me.male_name+ " whose id is "+ me.male_id+ " lives in "+ me.male_address);
            Console.WriteLine(fe.female_name+" whose id is "+ fe.female_id+ " lives in "+fe.female_address);
            
        }
    }
}
