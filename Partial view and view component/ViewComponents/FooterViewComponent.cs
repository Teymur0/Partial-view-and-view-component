using Microsoft.AspNetCore.Mvc;

namespace Partial_view_and_view_component.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
