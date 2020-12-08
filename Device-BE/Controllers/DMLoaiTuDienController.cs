using Device_BE.Models;
using Device_BE.Models.MDevice;
using Device_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device_BE.Controllers
{
    [Route("api/loaitudien")]
    [ApiController]
    public class DMLoaiTuDienController : ControllerBase
    {
        private readonly DeviceContext _context;
        public DMLoaiTuDienController(DeviceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<LoaiTuDienModel> getPage( SearchModel search)
        {
            var data = _context.CMLoaiTuDiens.Skip((search.pageIndex - 1) * search.pageSize).Take(search.pageSize);
            var query = from list in data
                        select list;
            if (!String.IsNullOrEmpty(search.sSearch))
            {
                query = query.Where(x => x.Ten.Contains(search.sSearch) || x.MaLoai.Contains(search.sSearch));
            }
              
            return query.Select(x => new LoaiTuDienModel
            {
                Id = x.Id,
                MaLoai = x.MaLoai,
                TenLoai = x.Ten
            }).ToList();

        }


        [HttpPost]
        public ActionResult<CMLoaiTuDien> Create(CMLoaiTuDien model)
        {
            _context.CMLoaiTuDiens.Add(model);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public ActionResult<CMLoaiTuDien> Update(CMLoaiTuDien model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return NoContent();
        }
        [Route("{id}")]
        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            var delete = await _context.CMLoaiTuDiens.FindAsync(id);
            if (delete == null)
            {
                return Ok("Xóa Không thành công");
            }
            _context.CMLoaiTuDiens.Remove(delete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
