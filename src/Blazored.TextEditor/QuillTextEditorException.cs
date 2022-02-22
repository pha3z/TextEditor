using System;
using System.Collections.Generic;
using System.Text;

namespace Blazored.TextEditor
{
    internal class QuillTextEditorException : Exception
    {
        public QuillTextEditorException(string message)
    : base(message)
        {
        }

        public QuillTextEditorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
