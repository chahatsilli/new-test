using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

     public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){
 
            if(Request.Form["ADD"]=="ADD"){
 
                ViewData["summation"]=double.Parse(Request.Form["num1"])+double.Parse(Request.Form["num2"]);
 
            }
              else if (Request.Form["SUB"] == "SUB")
                    {
                        ViewData["summation"] =double.Parse(Request.Form["num1"])-double.Parse(Request.Form["num2"]);
 
                    }
              else if (Request.Form["SQU"] == "SQU")
                    {
                        ViewData["summation"] =double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"]);
 
                    }
                    else if (Request.Form["CUBE"] == "CUBE")
                    {
                        ViewData["summation"] =double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"])*double.Parse(Request.Form["num2"]);
 
                    }
                  
                  
                }
 
        }
    
 
 
    }
 