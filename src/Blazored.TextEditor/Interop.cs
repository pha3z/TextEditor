using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazored.TextEditor
{
    public static class Interop
    {
        internal static ValueTask<object> CreateQuill(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            ElementReference toolbar,
            bool readOnly,
            string placeholder,
            string theme,
            string[] formats,
            string debugLevel)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.createQuill",
                    quillElement, toolbar, readOnly,
                    placeholder, theme, formats, debugLevel);
            }
            catch(Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }

        internal static ValueTask<string> GetText(
            IJSRuntime jsRuntime,
            ElementReference quillElement)
        {
            try
            {
                return jsRuntime.InvokeAsync<string>(
                    "QuillFunctions.getQuillText",
                    quillElement);
            }
            catch (Exception ex)
                { throw new BlazoredQuillGetContentException("GetContentException", ex); }
        }

        internal static ValueTask<string> GetHTML(
            IJSRuntime jsRuntime,
            ElementReference quillElement)
        {
            try { 
            return jsRuntime.InvokeAsync<string>(
                "QuillFunctions.getQuillHTML", 
                quillElement);
            }
            catch (Exception ex)
                { throw new BlazoredQuillGetContentException("GetContentException", ex); }
        }

        internal static ValueTask<string> GetContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement)
        {
            try
            {
                return jsRuntime.InvokeAsync<string>(
                    "QuillFunctions.getQuillContent",
                    quillElement);
            }
            catch (Exception ex)
                { throw new BlazoredQuillGetContentException("GetContentException", ex); }
        }

        internal static ValueTask<object> LoadQuillContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string Content)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.loadQuillContent",
                    quillElement, Content);
            }
            catch (Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }

        internal static ValueTask<object> LoadQuillHTMLContent(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string quillHTMLContent)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.loadQuillHTMLContent",
                    quillElement, quillHTMLContent);
            }
            catch (Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }

        internal static ValueTask<object> EnableQuillEditor(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            bool mode)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.enableQuillEditor",
                    quillElement, mode);
            }
            catch (Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }

        internal static ValueTask<object> InsertQuillImage(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string imageURL)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.insertQuillImage",
                    quillElement, imageURL);
            }
            catch (Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }

        internal static ValueTask<object> InsertQuillText(
            IJSRuntime jsRuntime,
            ElementReference quillElement,
            string text)
        {
            try
            {
                return jsRuntime.InvokeAsync<object>(
                    "QuillFunctions.insertQuillText",
                    quillElement, text);
            }
            catch (Exception ex)
                { throw new BlazoredQuillException("InteropException", ex); }
        }
    }
}