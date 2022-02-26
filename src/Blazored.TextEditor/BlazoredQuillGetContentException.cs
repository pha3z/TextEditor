using System;
using System.Collections.Generic;
using System.Text;

namespace Blazored.TextEditor
{
    internal class BlazoredQuillGetContentException : Exception
    {
        public BlazoredQuillGetContentException(string message)
    : base(message)
        {
        }

        public BlazoredQuillGetContentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
