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
using MVCAud4.Models;

namespace MVCAud4.Controllers
{
    public class ClientsApiController : ApiController
    {
        private MyDbContext db = new MyDbContext();

        // GET: api/ClientApi
        public IEnumerable<ClientDto> GetClients()
        {
            return db.Clients.Select(client => new ClientDto()
            {
                Id = client.Id,
                Address = client.Address,
                Age = client.Age,
                IsSubscribed = client.IsSubscribed,
                MemberCard = client.MemberCard,
                Name = client.Name,
                Telephone = client.Telephone
            }).ToList();
        }

        // GET: api/ClientApi/5
        [ResponseType(typeof(ClientDto))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(new ClientDto()
            {
                Id = client.Id,
                Address = client.Address,
                Age = client.Age,
                IsSubscribed = client.IsSubscribed,
                MemberCard = client.MemberCard,
                Name = client.Name,
                Telephone = client.Telephone
            });
        }

        // PUT: api/ClientApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.Id)
            {
                return BadRequest();
            }

            db.Entry(client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/ClientApi
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clients.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.Id }, client);
        }

        // DELETE: api/ClientApi/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            db.Clients.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Clients.Count(e => e.Id == id) > 0;
        }
    }
}