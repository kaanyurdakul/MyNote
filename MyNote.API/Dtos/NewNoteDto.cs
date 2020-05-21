using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyNote.API.Dtos
{
    public class NewNoteDto
    {
        [Required(ErrorMessage ="")]
        [StringLength(100, ErrorMessage ="")]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? NotificationTime { get; set; }

    }
}