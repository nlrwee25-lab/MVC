using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double Height { get; set; }

    [BindProperty]
    public double Radius { get; set; }

    [BindProperty]
    public double Twist { get; set; }

    [BindProperty]
    public int Layers { get; set; }

    public double Volume { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        double layerHeight = Height / Layers;
        double volume = 0;

        for (int i = 0; i < Layers; i++)
        {
            double r = Radius * (1 - (double)i / Layers);
            double area = Math.PI * r * r;

            volume += area * layerHeight;
        }

        Volume = volume;
    }
}