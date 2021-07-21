using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM9
{
  public  class MyException : Exception
    {
        public MyException()
        { }

        public MyException (string message): base(message)
        { }
    }
}
