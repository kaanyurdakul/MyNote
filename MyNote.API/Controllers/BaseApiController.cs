using MyNote.API.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace MyNote.API.Controllers
{
    public class BaseApiController : ApiController, IDisposable    
    {
        public ApplicationDbContext db { get; set; }
        public BaseApiController()
        {
            db = new ApplicationDbContext();
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}