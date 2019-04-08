using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BioMApp.Database;

namespace BioMApp.SQL
{
    public static class FilamentOpp
    {

        public static Filament GetRandomFilament()
        {
            Random rnd = new Random();
            int id = rnd.Next(1,3);

            Filament filament = new BiomAppDatabaseEntities().Filaments.FirstOrDefault(x => x.Id == id);

            return filament;
        }

    }
}
