using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YazarVeAlintilari.Data;

namespace YazarVeAlintilari.ViewComponents
{
    public class SozYazdirViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext _db;
        public SozYazdirViewComponent(UygulamaDbContext Db)
        {
            _db = Db;
        }
        //public async Task<IViewComponentResult> InvokeAsync(int Id)
        //{
        //    Yazar? yazar = await _db.Yazars.FindAsync(Id);
        //    return View(yazar);

        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Yazar> Yazars = await _db.Yazars.ToListAsync();
            return View(Yazars);

        }

    }
}
