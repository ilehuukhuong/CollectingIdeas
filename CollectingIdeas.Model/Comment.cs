using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectingIdeas.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool isName { get; set; }
        public int IdeaId { get; set; }
        public DateTime CreateDatetime { get; set; } = DateTime.Now;
        [ValidateNever]
        [Required]
        public string IdentityUserId { get; set; }
        [ValidateNever]
        [ForeignKey("IdentityUserId")]
        public IdentityUser IdentityUser { get; set; }
    }
}
