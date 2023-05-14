using WebUniFrontend.Application.Contract;
using WebUniFrontend.Models;

namespace WebUniFrontend.Application.Services.CourseService
{
    public class CourseServicesTempData : ICourseServices
    {
        public List<DetailedCourseItem> GetCoursesLongCart()
        {
            List<DetailedCourseItem> items = new List<DetailedCourseItem>();

            items.Add(new DetailedCourseItem("/img/courses/1.jpg", "IT Development", "Lorem ipsum dolor sit amet, consectetur", "110 Students", 100, "William Parker", "Developer", "/img/authors/1.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/2.jpg", "Web Design", "Lorem ipsum dolor sit amet, consectetur", "120 Students", 110, "William Parker", "Developer", "/img/authors/2.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/3.jpg", "Illustration & Drawing", "Lorem ipsum dolor sit amet, consectetur", "130 Students", 120, "William Parker", "Developer", "/img/authors/3.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/4.jpg", "Social Media", "Lorem ipsum dolor sit amet, consectetur", "140 Students", 100, "William Parker", "Developer", "/img/authors/4.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/5.jpg", "Photoshop", "Lorem ipsum dolor sit amet, consectetur", "150 Students", 170, "William Parker", "Developer", "/img/authors/5.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/6.jpg", "Cryptocurrencies", "Lorem ipsum dolor sit amet, consectetur", "160 Students", 190, "William Parker", "Developer", "/img/authors/6.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/7.jpg", "IT Development 2", "Lorem ipsum dolor sit amet, consectetur", "170 Students", 200, "William Parker", "Developer", "/img/authors/7.jpg"));
            items.Add(new DetailedCourseItem("/img/courses/8.jpg", "HTML 5", "Lorem ipsum dolor sit amet, consectetur", "180 Students", 180, "William Parker", "Developer", "/img/authors/8.jpg"));

            return items;
        }

        public List<CourseItem> GetCoursesShortCart()
        {

            List<CourseItem> items = new List<CourseItem>();

            items.Add(new CourseItem("/img/categories/1.jpg", "IT Development", "Lorem ipsum dolor sit amet, consectetur", "100 Courses"));
            items.Add(new CourseItem("/img/categories/2.jpg", "Web Design", "Lorem ipsum dolor sit amet, consectetur", "120 Courses"));
            items.Add(new CourseItem("/img/categories/3.jpg", "Illustration & Drawing", "Lorem ipsum dolor sit amet, consectetur", "130 Courses"));
            items.Add(new CourseItem("/img/categories/4.jpg", "Social Media", "Lorem ipsum dolor sit amet, consectetur", "140 Courses"));
            items.Add(new CourseItem("/img/categories/5.jpg", "Photoshop", "Lorem ipsum dolor sit amet, consectetur", "150 Courses"));
            items.Add(new CourseItem("/img/categories/6.jpg", "Cryptocurrencies", "Lorem ipsum dolor sit amet, consectetur", "160 Courses"));

            return items;
        }
    }
}