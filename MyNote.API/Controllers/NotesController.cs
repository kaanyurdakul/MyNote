using MyNote.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MyNote.API.Controllers
{
    public class NotesController : BaseApiController
    {
        public IHttpActionResult List()
        {
            return Ok(db.Notes.Select(x => new NoteDTO { Baslik = x.Title, Yazar = x.Author }).ToList());
        }

        public class NoteDTO
        {
            public string Baslik { get; set; }

            public ApplicationUser Yazar { get; set; }
        }
    }
}
