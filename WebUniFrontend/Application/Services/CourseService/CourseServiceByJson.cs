using Newtonsoft.Json;
using WebUniFrontend.Application.Contract;
using WebUniFrontend.Models;

namespace WebUniFrontend.Application.Services.CourseService
{
    public class CourseServiceByJson : ICourseServices
    {
        public List<DetailedCourseItem> GetCoursesLongCart()
        {
            var jsonData = File.ReadAllText($"{Environment.CurrentDirectory}/Data/CoursesLongCart.json");
            List<DetailedCourseItem> items = JsonConvert.DeserializeObject<List<DetailedCourseItem>>(jsonData);

            return items;
        }

        public List<CourseItem> GetCoursesShortCart()
        {
            var jsonData = File.ReadAllText($"{Environment.CurrentDirectory}/Data/CoursesShortCart.json");
            List<CourseItem> items = JsonConvert.DeserializeObject<List<CourseItem>>(jsonData);

            return items;
        }
    }
}
