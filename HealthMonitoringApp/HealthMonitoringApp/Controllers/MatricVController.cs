using BLL.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace HealthMonitoringApp.Controllers
{
    public class MatricVController : Controller
    {
        // GET: MatricV
        public ActionResult ShowAll()
        {
            var matricList = MatricService.Get();
            return View(matricList);
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = MatricService.GetX(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(string Id, string dcsn)
        {
            if (dcsn.Equals("Yes"))
            {
                MatricService.Delete(Id);

            }
            return RedirectToAction("ShowAll");
        }
        [HttpGet]
        public void ExportClientsListToExcel(List<BLL.DTOs.MatricDTO> model)
        {
            var grid = new System.Web.UI.WebControls.GridView();

            grid.DataSource = from m in model
                              select new
                              {
                                  MatricId = m.MatricsId,
                                  UserId = m.UserId,
                                  Name = m.Name,
                                  Weight = $"{m.Weight} KG",
                                  BloodPressure = $"{m.BloodPressure} mm/Hg",
                                  BloodTemperature = $"{m.BloodTemperature} °C",
                                  BloodSugarLevel = $"{m.BloodSugarLevel} mm/dL",
                                  CreatedAt = m.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss")
                              };

            grid.DataBind();

            
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=Exported_Matrics.xls");
            Response.ContentType = "application/excel";
            using (var sw = new StringWriter())
            {
                using (var htw = new HtmlTextWriter(sw))
                {
                    grid.RenderControl(htw);
                }

                Response.Write(sw.ToString());
            }

            Response.End();
        }
        [HttpGet]
        public ActionResult ExportToExcel()
        {
           
            var matrics = MatricService.Get(); 

            ExportClientsListToExcel(matrics);

            return RedirectToAction("ShowAll"); 

        }
    }
}