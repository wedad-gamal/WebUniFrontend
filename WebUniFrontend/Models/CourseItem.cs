namespace WebUniFrontend.Models
{
    public class CourseItem
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Footer { get; set; }

        public CourseItem()
        {

        }
        public CourseItem(string image, string title, string description, string footer)
        {
            Image = image;
            Title = title;
            Description = description;
            Footer = footer;
        }
    }

}