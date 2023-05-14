using WebUniFrontend.Models;

namespace WebUniFrontend.Application.Contract
{
    public interface ICourseServices
    {
        List<CourseItem> GetCoursesShortCart();
        List<DetailedCourseItem> GetCoursesLongCart();





    }
}
