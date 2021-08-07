namespace GameProjectDemo.Abstract
{
    public interface ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
    }
}