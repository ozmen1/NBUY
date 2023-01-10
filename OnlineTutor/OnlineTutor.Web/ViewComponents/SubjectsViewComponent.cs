using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;

namespace OnlineTutor.Web.ViewComponents
{
    public class SubjectsViewComponent : ViewComponent
    {
        private readonly ISubjectService _subjectManager;
        public SubjectsViewComponent(ISubjectService subjectManager)
        {
            _subjectManager = subjectManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subjects = await _subjectManager.GetSubjectsByCategoryAsync(id);
            return View(subjects);
        }
    }
}
