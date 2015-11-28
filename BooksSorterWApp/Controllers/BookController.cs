using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BooksSorterWApp.Models;

namespace BooksSorterWApp.Controllers
{

    [RoutePrefix("api/v1/public")]
    public class BookController : ApiController
    {
        private readonly BookDBContext _db = new BookDBContext();


        [HttpGet]
        [Route("books")]
        //http://localhost:59169/api/v1/public/books
        // Busca todos os books no banco via EF
        public IQueryable<Book> GetBooks()
        {
            return _db.Books;
        }

        // Libera recursos automaticamente
        protected override void Dispose(bool disponsing)
        {
            if (disponsing)
            {
                _db.Dispose();
            }

            base.Dispose(disponsing);
        }
    }


}
