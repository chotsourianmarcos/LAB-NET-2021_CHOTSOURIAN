using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TP5_Chotsourian.MVC.Models;

namespace TP5_Chotsourian.MVC.Controllers
{
    public class CivilizationsController : Controller
    {
        // GET: Civilizations
        public ActionResult Index()

        {
            List<CivilizationsView> result = null;
            string response = string.Empty;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://hp-api.herokuapp.com/api/characters");
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "GET";
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            httpResponse.Close();
            result = Deserialize<List<CivilizationsView>>(response);
            return View(result);
        }

        public static T Deserialize<T>(string jsonData)
        {
            JsonSerializer json = new JsonSerializer();
            return json.Deserialize<T>(new JsonTextReader(new StringReader(jsonData)));
        }
    
        }
    
}