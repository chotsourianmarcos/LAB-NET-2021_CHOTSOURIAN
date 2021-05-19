using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Chotsourian.Entities;

namespace TP5_Chotsourian.Logic
{
    interface IABMLogic<Entity, IDType>
    {
        void Add(Entity newEntity);
        void Delete(IDType id);
        void Update(Entity name);

    }
}
