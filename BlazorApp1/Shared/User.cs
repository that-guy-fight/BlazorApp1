using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared
{
    public class User
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

        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Display(Name = "Date of Birth")]
        public string? DateOfBirth { get; set; }
        
        [Display(Name = "Register Date")]
        public string? RegisterDate { get; set; }

        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }

        [Display(Name = "Location")]
        public object? Location { get; set; }
    }
}
