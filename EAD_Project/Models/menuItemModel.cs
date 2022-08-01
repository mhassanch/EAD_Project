namespace EAD_Project.Models
{
    public class menuItemModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int calories { get; set; }
        public string imagePath { get; set; }

        public menuItemModel(int id, int cal, string t, string descp, string img)
        {
            this.id = id;
            title = t;
            description = descp;
            imagePath = img;
            calories = cal;
        }
    }
}
