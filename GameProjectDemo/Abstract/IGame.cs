namespace GameProjectDemo.Abstract
{
    public interface IGame:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; } //1 = Action , 2 = Football
        public double Price { get; set; }
    }
}