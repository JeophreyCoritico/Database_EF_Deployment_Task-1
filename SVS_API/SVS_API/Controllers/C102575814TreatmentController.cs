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
    public class C102575814TreatmentController : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/C102575814Treatment
        public IQueryable<C102575814Treatment> GetC102575814Treatment()
        {
            return db.C102575814Treatment;
        }

        // GET: api/C102575814Treatment/5
        [ResponseType(typeof(C102575814Treatment))]
        public async Task<IHttpActionResult> GetC102575814Treatment(DateTime id)
        {
            C102575814Treatment c102575814Treatment = await db.C102575814Treatment.FindAsync(id);
            if (c102575814Treatment == null)
            {
                return NotFound();
            }

            return Ok(c102575814Treatment);
        }

        // PUT: api/C102575814Treatment/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Treatment(DateTime id, C102575814Treatment c102575814Treatment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Treatment.Date)
            {
                return BadRequest();
            }

            db.Entry(c102575814Treatment).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814TreatmentExists(id))
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

        // POST: api/C102575814Treatment
        [ResponseType(typeof(C102575814Treatment))]
        public async Task<IHttpActionResult> PostC102575814Treatment(C102575814Treatment c102575814Treatment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Treatment.Add(c102575814Treatment);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814TreatmentExists(c102575814Treatment.Date))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Treatment.Date }, c102575814Treatment);
        }

        // DELETE: api/C102575814Treatment/5
        [ResponseType(typeof(C102575814Treatment))]
        public async Task<IHttpActionResult> DeleteC102575814Treatment(DateTime id)
        {
            C102575814Treatment c102575814Treatment = await db.C102575814Treatment.FindAsync(id);
            if (c102575814Treatment == null)
            {
                return NotFound();
            }

            db.C102575814Treatment.Remove(c102575814Treatment);
            await db.SaveChangesAsync();

            return Ok(c102575814Treatment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814TreatmentExists(DateTime id)
        {
            return db.C102575814Treatment.Count(e => e.Date == id) > 0;
        }
    }
}