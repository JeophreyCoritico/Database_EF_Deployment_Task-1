using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SVS_API.Models;

namespace SVS_API.Controllers
{
    public class C102575814PetController : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/C102575814Pet
        public IQueryable<C102575814Pet> GetC102575814Pet()
        {
            return db.C102575814Pet;
        }

        // GET: api/C102575814Pet/5
        [ResponseType(typeof(C102575814Pet))]
        public async Task<IHttpActionResult> GetC102575814Pet(string id)
        {
            C102575814Pet c102575814Pet = await db.C102575814Pet.FindAsync(id);
            if (c102575814Pet == null)
            {
                return NotFound();
            }

            return Ok(c102575814Pet);
        }

        // PUT: api/C102575814Pet/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Pet(string id, C102575814Pet c102575814Pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Pet.PetName)
            {
                return BadRequest();
            }

            db.Entry(c102575814Pet).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814PetExists(id))
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

        // POST: api/C102575814Pet
        [ResponseType(typeof(C102575814Pet))]
        public async Task<IHttpActionResult> PostC102575814Pet(C102575814Pet c102575814Pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Pet.Add(c102575814Pet);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814PetExists(c102575814Pet.PetName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Pet.PetName }, c102575814Pet);
        }

        // DELETE: api/C102575814Pet/5
        [ResponseType(typeof(C102575814Pet))]
        public async Task<IHttpActionResult> DeleteC102575814Pet(string id)
        {
            C102575814Pet c102575814Pet = await db.C102575814Pet.FindAsync(id);
            if (c102575814Pet == null)
            {
                return NotFound();
            }

            db.C102575814Pet.Remove(c102575814Pet);
            await db.SaveChangesAsync();

            return Ok(c102575814Pet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814PetExists(string id)
        {
            return db.C102575814Pet.Count(e => e.PetName == id) > 0;
        }
    }
}