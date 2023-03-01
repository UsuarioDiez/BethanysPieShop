namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository=new MockCategoryRepository();

        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie(){PieId=1,Name="Strawberry Pie",Price=15.95M,ShortDescription="Strawberry Pie", LongDescription="Get the best out of this season with the red fruits delicious pie",Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg",ImageThumbnailUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg"},
            new Pie(){PieId=1,Name="Cheese-Lemon Pie",Price=30.90M,ShortDescription="Cheese-Lemon", LongDescription="You won't be able to get only one bite",Category=_categoryRepository.AllCategories.ToList()[1],ImageUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg",ImageThumbnailUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg"},
            new Pie(){PieId=1,Name="Hearth Shaped Pie",Price=90.65M,ShortDescription="Hearth Pie", LongDescription="What says 'I love you' more than an expensive hearth shaped tasteless dry cake?",Category=_categoryRepository.AllCategories.ToList()[2],ImageUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg",ImageThumbnailUrl="https://cdn.pixabay.com/photo/2018/05/01/18/21/eclair-3366430_960_720.jpg"},
        };

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie? GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
