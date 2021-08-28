using FixIt.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixIt
{
    public class SetupService
    {
        public static void Init(ApplicationDbContext context)
        {
            context.Database.Migrate();
        }
    }
}
