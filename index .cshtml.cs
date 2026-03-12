using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void OnGet()
    {
        Name = "Desmond";
        Age = 20;
    }
}