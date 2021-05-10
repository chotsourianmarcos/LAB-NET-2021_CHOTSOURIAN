using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP5_Chotsourian.Entities;
using TP5_Chotsourian.Logic;
using TP5_Chotsourian.MVC.Models;

namespace TP5_Chotsourian.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        public ActionResult Index()
        {
            List<TerritoriesView> territoriesView = territoriesLogic.GetAll().Select(t => new TerritoriesView
            {
                TerritoryID = t.TerritoryID,
                TerritoryDescription = t.TerritoryDescription,
                RegionID = t.RegionID,
            }).ToList();

            return View(territoriesView);
        }

        public ActionResult InsertUpdate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertUpdate(TerritoriesView territoriesView)
        {
            Territories territoryEntity = new Territories
            {
                TerritoryID = territoriesView.TerritoryID,
                TerritoryDescription = territoriesView.TerritoryDescription,
                RegionID = territoriesView.RegionID,
            };
            try
            {
                if (territoriesLogic.GetAll().Any(a => a.TerritoryID == territoriesView.TerritoryID))
                {
                    territoriesLogic.Update(territoryEntity);
                }
                else
                {
                    territoriesLogic.Add(territoryEntity);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            try
            {
                territoriesLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}