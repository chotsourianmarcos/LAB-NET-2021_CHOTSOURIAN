using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TP5_Chotsourian.Logic;
using TP5_Chotsourian.API.Models;
using TP5_Chotsourian.Entities;

namespace TP5_Chotsourian.API.Controllers
{
    public class TerritoriesController : ApiController
    {
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();

        [HttpPost]
        public IHttpActionResult Add(TerritoriesAPI territoriesAPI) 
        {
            try
            {
                Territories territorie = new Territories()
                {
                    TerritoryID = territoriesAPI.TerritoryID,
                    TerritoryDescription = territoriesAPI.TerritoryDescription,
                    RegionID = territoriesAPI.RegionID,
                };
                territoriesLogic.Add(territorie);
                return Ok("El territorio ha sido añadido.");
            }
            catch
            {
                return BadRequest("Hubo un error, verifique los datos.");
            }
                
        }

        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            try
            {
                territoriesLogic.Delete(id);
                return Ok("El territorio ha sido borrado.");
            }
            catch
            {
                return BadRequest("Hubo un error, verifique los datos.");
            }
            
        }

        [HttpPatch]
        public IHttpActionResult Update(TerritoriesAPI territoriesApi)
        {
            try
            {
                Territories territorie = new Territories()
                {
                    TerritoryID = territoriesApi.TerritoryID,
                    TerritoryDescription = territoriesApi.TerritoryDescription,
                    RegionID = territoriesApi.RegionID,
                };
                territoriesLogic.Update(territorie);
                return Ok("El territorio ha sido modificado.");
            }
            catch
            {
                return BadRequest("Hubo un error, verifique los datos.");
            }
            
        }

        [HttpGet]
        public List<TP5_Chotsourian.API.Models.TerritoriesAPI> Get()
        {
                List<TerritoriesAPI> territoriesAPI = territoriesLogic.GetAll().Select(t => new TerritoriesAPI
                {
                    TerritoryID = t.TerritoryID,
                    TerritoryDescription = t.TerritoryDescription,
                    RegionID = t.RegionID,
                }).ToList();
                return territoriesAPI;
                
        }



    }
}
