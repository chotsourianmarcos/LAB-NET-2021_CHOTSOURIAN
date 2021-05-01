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
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void Add(Territories newTerritory)
        {
            var territorynew = context.Territories.Find(newTerritory.TerritoryID);
            if (territorynew == null && newTerritory.RegionID > 0 && newTerritory.RegionID < 5)
            {
                context.Territories.Add(newTerritory);
                context.SaveChanges();
            }
            else { 
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

            if(territoryupdate != null && territory.RegionID > 0 && territory.RegionID < 5)
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













        //cuando haga la de products borrar por productname que tmb es string y escribirlo así tal cual para
        //poder hacer la interfaz genérica. y usar las mismas variables para cada clase.
        /* pendiente, declarar en abstracto y general todos los metodos, para que puedan ser capturados en la interfaz genérico,
         * después terminar AMB para territories y para products e implementarles la ínterfaz genérica a ambos.
         * ver si puedo sumar algún chiche más.
         ver notas cuaderno full. */
    }
}
