using cleanAf.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.infrastructure.Persistence
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users {get; set;} // dépendance au projet domain inférieur dans l'ognion
    }
}
