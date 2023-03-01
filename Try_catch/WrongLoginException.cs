using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException()
        {

        }
        public WrongLoginException(string fail) : base(fail)
        {

        }
    }
}
