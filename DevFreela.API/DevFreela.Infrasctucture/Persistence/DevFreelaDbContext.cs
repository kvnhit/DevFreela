
using DevFreela.Core.Entities;

namespace DevFreela.Infrasctucture.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de projeto 3", 1, 1, 30000)
            };
            Users = new List<User>
            {
                new User("Kevin Bezerra", "kevinteste@gmail.com", new DateTime(1998, 1, 19)),
                new User("Roberto Craveiro", "roberto@gmail.com", new DateTime(1989, 3, 24)),
                new User("Anderson Silva", "anderson@gmail.com", new DateTime(1990, 5, 12)),
            };
            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects{ get; set; }
        public List<User> Users{ get; set; }
        public List<Skill> Skills{ get; set; }
    }
}
