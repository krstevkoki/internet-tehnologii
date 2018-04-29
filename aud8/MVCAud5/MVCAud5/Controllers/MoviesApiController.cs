using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVCAud5.Models;

namespace MVCAud5.Controllers
{
    public class MoviesApiController : ApiController
    {
        private MyDbContext db = new MyDbContext();

        // GET: api/MoviesApi
        public IEnumerable<MoviesDto> GetMovies()
        {
            return db.Movies.Select(movie => new MoviesDto()
            {
                Id = movie.Id,
                DownloadURL = movie.DownloadURL,
                ImageUrl = movie.ImageUrl,
                Name = movie.Name,
                Rating = movie.Rating
            }).ToList();
        }

        // GET: api/MoviesApi/5
        [ResponseType(typeof(Movie))]
        public IHttpActionResult GetMovie(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // PUT: api/MoviesApi/5
        [ResponseType(typeof(void))]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult PutMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movie.Id)
            {
                return BadRequest();
            }

            db.Entry(movie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MoviesApi
        [ResponseType(typeof(Movie))]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult PostMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movies.Add(movie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new {id = movie.Id}, movie);
        }

        // DELETE: api/MoviesApi/5
        [ResponseType(typeof(Movie))]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult DeleteMovie(int id)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movie);
            db.SaveChanges();

            return Ok(movie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool MovieExists(int id)
        {
            return db.Movies.Count(e => e.Id == id) > 0;
        }
    }
}