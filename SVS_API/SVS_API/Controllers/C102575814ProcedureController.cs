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
    public class C102575814ProcedureController : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/C102575814Procedure
        public IQueryable<C102575814Procedure> GetC102575814Procedure()
        {
            return db.C102575814Procedure;
        }

        // GET: api/C102575814Procedure/5
        [ResponseType(typeof(C102575814Procedure))]
        public async Task<IHttpActionResult> GetC102575814Procedure(int id)
        {
            C102575814Procedure c102575814Procedure = await db.C102575814Procedure.FindAsync(id);
            if (c102575814Procedure == null)
            {
                return NotFound();
            }

            return Ok(c102575814Procedure);
        }

        // PUT: api/C102575814Procedure/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutC102575814Procedure(int id, C102575814Procedure c102575814Procedure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c102575814Procedure.ProcedureID)
            {
                return BadRequest();
            }

            db.Entry(c102575814Procedure).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!C102575814ProcedureExists(id))
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

        // POST: api/C102575814Procedure
        [ResponseType(typeof(C102575814Procedure))]
        public async Task<IHttpActionResult> PostC102575814Procedure(C102575814Procedure c102575814Procedure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.C102575814Procedure.Add(c102575814Procedure);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (C102575814ProcedureExists(c102575814Procedure.ProcedureID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = c102575814Procedure.ProcedureID }, c102575814Procedure);
        }

        // DELETE: api/C102575814Procedure/5
        [ResponseType(typeof(C102575814Procedure))]
        public async Task<IHttpActionResult> DeleteC102575814Procedure(int id)
        {
            C102575814Procedure c102575814Procedure = await db.C102575814Procedure.FindAsync(id);
            if (c102575814Procedure == null)
            {
                return NotFound();
            }

            db.C102575814Procedure.Remove(c102575814Procedure);
            await db.SaveChangesAsync();

            return Ok(c102575814Procedure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool C102575814ProcedureExists(int id)
        {
            return db.C102575814Procedure.Count(e => e.ProcedureID == id) > 0;
        }
    }
}