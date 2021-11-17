using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorServer.Pages.TestPages;

public partial class TestCounter
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
