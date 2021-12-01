using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared
{
    public class UserPreview
    {
        [Display(Name = "User Id")]
        public string Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Profile Image")]
        public string Picture { get; set; }
    }
}
