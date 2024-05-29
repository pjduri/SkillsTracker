using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker;

[Route("/skills/")]
public class SkillsController : Controller
{
    [HttpGet]
    public IActionResult DisplayLanguageOptions()
    {
        string html =
            "<h1>Skills Tracker</h1>"
            + "<h2>Currently learning:</h2>"
            + "<ol>"
            + "<li>JavaScript</li>"
            + "<li>C#</li>"
            + "<li>Java</li>"
            + "</ol>"
            + "<form action='skills/form'>"
            + "<input type='submit' value='Go!' />"
            + "</form>";
        return Content(html, "text/html");
    }

    [HttpGet("form")]
    public IActionResult DisplayForm()
    {
        string html =
            "<form method='post'>"
            + "<label>Date:<br>"
            + "<input name='date' type='date' />"
            + "</label><br/>"
            + "<label>JavaScript"
            + "<select name='javascript'>"
            + "<option value='Learning Basics'>Beginner</option>"
            + "<option value='Making Apps'>Intermediate</option>"
            + "<option value='JavaScript Genius!!'>Master</option>"
            + "</select>"
            + "</label><br/>"
            + "<label>C#"
            + "<select name='csharp'>"
            + "<option value='Learning Basics'>Beginner</option>"
            + "<option value='Making Apps'>Intermediate</option>"
            + "<option value='C How Sharp I Am?'>Master</option>"
            + "</select>"
            + "</label><br/>"
            + "<label>Java"
            + "<select name='java'>"
            + "<option value='Learning Basics'>Beginner</option>"
            + "<option value='Making Apps'>Intermediate</option>"
            + "<option value='I eat Beans for breakfast!'>Master</option>"
            + "</select>"
            + "</label><br/>"
            + "<input type='submit' />"
            + "</form>";
        return Content(html, "text/html");
    }

    [HttpPost("form")]
    public IActionResult DisplayProgress(
        string date,
        string javascript,
        string csharp,
        string java
    )
    {
        string html =
            $"<h1>{date}</h1>"
            + "<ol>"
            + $"<li><b>JavaScript:</b> {javascript}</li>"
            + $"<li><b>C#:</b> {csharp}</li>"
            + $"<li><b>Java:</b> {java}</li>"
            + "</ol>";
        return Content(html, "text/html");
    }
}