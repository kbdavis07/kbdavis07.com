using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KB.Models
{
    public class Contact
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ContactDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Reason for Contact")]
        public Topics Topic { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Message")]
        public string Message { get; set; }

       
        public enum Topics
        {
            [Display(Name = "Have a question you want to ask me?")]
            Question,
            [Display(Name = "Want to hire me?")]
            Hire,
            [Display(Name = "Have feedback for this website?")]
            Feedback
        }




    }
}