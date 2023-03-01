using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException()
        {

        }
        public WrongPasswordException(string fail) : base(fail)
        {

        }
    }
}
