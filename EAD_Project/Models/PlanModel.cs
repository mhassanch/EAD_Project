namespace EAD_Project.Models
{
    public class PlanModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public PlanModel(int i, string t, double p)
        {
            id = i;
            title = t;
            price = p;
        }
    }
}
