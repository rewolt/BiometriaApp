using BioMApp.Database;
using System;
using System.Linq;

namespace BioMApp.SQL
{
    public static class FilamentOpp
    {

        public static Filament GetRandomFilament()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 7);

            using (var entity = new BiomAppDatabaseEntities())
            {
                Filament filament = entity.Filaments.FirstOrDefault(x => x.Id == id);
                return filament;
            }
        }

    }
}
