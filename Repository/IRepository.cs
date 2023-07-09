using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();
    }
}
