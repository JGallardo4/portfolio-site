using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    /// <summary>
    /// Relevant technologies used in the
    /// projects displayed on the site.
    /// </summary>
    public enum Tag
    {
        // REVIEW: The display annotation added to each of these enums will allow you to display the
        // name rather than the enum in the view.
        [Display(Name = "C#")]
        CSHARP,

        [Display(Name = ".NET Core MVC")]
        MVC,

        [Display(Name = ".NET Core")]
        DOTNET_CORE,

        [Display(Name = ".NET Framework")]
        DOTNET_FRAMEWORK,

        [Display(Name = "Python")]
        PYTHON
    }
}
