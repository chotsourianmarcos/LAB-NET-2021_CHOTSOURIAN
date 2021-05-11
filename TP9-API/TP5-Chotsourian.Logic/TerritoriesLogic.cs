using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Chotsourian.Data;
using TP5_Chotsourian.Entities;

namespace TP5_Chotsourian.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories, string>
    {
        public System.Data.Entity.DbSet<TP5_Chotsourian.Entities.Territories> GetAll()
        {
            return context.Territories;
        }

        public void Add(Territories newTerritory)
        {
            var territorynew = context.Territories.Find(newTerritory.TerritoryID);
            if (territorynew == null && context.Region.Any(a => a.RegionID == newTerritory.RegionID))
            {
                context.Territories.Add(newTerritory);
                context.SaveChanges();
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(string id)
        {
            var territoryAEliminar = context.Territories.Single(t => t.TerritoryID == id);

            context.Territories.Remove(territoryAEliminar);

            context.SaveChanges();
        }

        public void Update(Territories territory)
        {
            var territoryupdate = context.Territories.Find(territory.TerritoryID);

            if (territoryupdate != null && context.Region.Any(a => a.RegionID == territory.RegionID))
            {
                territoryupdate.TerritoryDescription = territory.TerritoryDescription;

                territoryupdate.RegionID = territory.RegionID;

                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }


        }

    }
}
