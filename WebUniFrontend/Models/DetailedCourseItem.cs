namespace WebUniFrontend.Models
{
    public class DetailedCourseItem : CourseItem
    {
        public double Price { get; set; }
        public Instructor Instructor { get; set; }

        public DetailedCourseItem()
        {

        }
        public DetailedCourseItem(string image, double price, string instructorName, string jobTitle)
        {
            Price = price;
            Instructor = new Instructor();
            Instructor.Image = image;
            Instructor.Name = instructorName;
            Instructor.JobTitle = jobTitle;
        }

        public DetailedCourseItem(string image, string title, string description, string footer,
            double price, string instructorName, string jobTitle, string instructorIcon) : base(image, title, description, footer)
        {
            Price = price;
            Instructor = new Instructor();
            Instructor.Image = instructorIcon;
            Instructor.Name = instructorName;
            Instructor.JobTitle = jobTitle;
        }
    }
}
