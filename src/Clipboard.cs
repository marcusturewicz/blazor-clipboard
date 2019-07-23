using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorClipboard
{
    public class Clipboard
    {
        public static Task<string> WriteTextAsync(IJSRuntime jsRuntime, string text)
        {
            // Implemented in cliboard.js
            return jsRuntime.InvokeAsync<string>(
                "clipboard.copy",
                text);
        }        
    }
}
