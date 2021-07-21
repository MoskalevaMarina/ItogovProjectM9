using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message) : base(message)
        { }
    }
}

