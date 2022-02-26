using System;
using System.Collections.Generic;
using System.Text;

namespace Blazored.TextEditor
{
    internal class BlazoredQuillException : Exception
    {
        public BlazoredQuillException(string message)
    : base(message)
        {
        }

        public BlazoredQuillException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
