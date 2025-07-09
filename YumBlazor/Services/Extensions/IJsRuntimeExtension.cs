using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class IJsRuntimeExtension
    {
        public static async Task ToastrSucess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}
