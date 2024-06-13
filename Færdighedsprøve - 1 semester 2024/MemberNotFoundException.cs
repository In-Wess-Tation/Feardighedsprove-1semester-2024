using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class MemberNotFoundException : Exception
    {


        public MemberNotFoundException() : base("Member not found")
        {

        }

        public MemberNotFoundException(string message) : base(message)
        {

        }




    }
}
