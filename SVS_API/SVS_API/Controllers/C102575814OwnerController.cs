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
    public class C102575814OwnerController : ApiController
    {
        private DADEntities db = new DADEntities();

        // GET: api/C102575814Owner
        public IQueryable<C102575814Owner> GetC102575814Owner()
        {
            return db.C102575814Owner;
        }

        // GET: api/C102575814Owner/5
        [ResponseType(typeof(C102575814Owner))]
        public async Task<IHttpActionResult> GetC102575814Owner(int id)
        {
            C102575814Owner c102575814Owner = await db.C102575814Owner.FindAsync(id);
            if (c102575814Owner == null)
            {
                return NotFound();
            }

            return Ok(c102575814Owner);
        }

        // PUT: api/C102575814Owner/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Owner(int id, C102575814Owner c102575814Owner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Owner.OwnerID)
            {
                return BadRequest();
            }

            db.Entry(c102575814Owner).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814OwnerExists(id))
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

        // POST: api/C102575814Owner
        [ResponseType(typeof(C102575814Owner))]
        public async Task<IHttpActionResult> PostC102575814Owner(C102575814Owner c102575814Owner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Owner.Add(c102575814Owner);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814OwnerExists(c102575814Owner.OwnerID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Owner.OwnerID }, c102575814Owner);
        }

        // DELETE: api/C102575814Owner/5
        [ResponseType(typeof(C102575814Owner))]
        public async Task<IHttpActionResult> DeleteC102575814Owner(int id)
        {
            C102575814Owner c102575814Owner = await db.C102575814Owner.FindAsync(id);
            if (c102575814Owner == null)
            {
                return NotFound();
            }

            db.C102575814Owner.Remove(c102575814Owner);
            await db.SaveChangesAsync();

            return Ok(c102575814Owner);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814OwnerExists(int id)
        {
            return db.C102575814Owner.Count(e => e.OwnerID == id) > 0;
        }
    }
}