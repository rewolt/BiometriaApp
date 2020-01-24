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

            Filament filament = new BiomAppDatabaseEntities().Filaments.FirstOrDefault(x => x.Id == id);

            return filament;
        }

    }
}
