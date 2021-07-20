using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevBlog.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}
