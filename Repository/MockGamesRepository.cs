using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<Game> _games;
        public MockGamesRepository()
        {
            _games= new List<Game>()
            {
                new Game()
                {
                    Name = "Farming simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018,11,19)
                },
                 new Game()
                {
                    Name = "Ведьмак",
                    Genre = "Action RPG",
                    ReleaseDate = new DateTime(2015,05,18)
                },
                 new Game()
                {
                    Name = "Destroy all humans",
                    Genre = "Action adventure",
                    ReleaseDate = new DateTime(2020,07,28)
                },
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
