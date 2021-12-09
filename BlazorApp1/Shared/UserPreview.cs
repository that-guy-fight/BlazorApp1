using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared
{
    public class UserPreview
    {
        [Display(Name = "User Id", Order = 4)]
        public string Id { get; set; }

        [Display(Name = "Title", Order = 1)]
        public string Title { get; set; }

        [Display(Name = "First Name", Order = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", Order = 3)]
        public string LastName { get; set; }

        [Display(Name = "Profile Image", Order = 0)]
        public string Picture { get; set; }
    }
}
