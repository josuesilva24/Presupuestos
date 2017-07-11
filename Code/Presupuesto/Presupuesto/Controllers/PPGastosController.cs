using Presupuesto.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Presupuesto.Controllers
{
    public class PPGastosController : Controller
    {
        // GET: PPGastos
     public  List<CargaGasto> lista = new List<CargaGasto>();

        public ActionResult Index(string tipo)
        {
            ViewBag.tipo = tipo.Equals("PS") ? "Presupuesto" : "Proyeccion";
            return View();
        }

        public JsonResult getProyeccionGastos()
        {
            return new JsonResult() { Data = lista /*Channel.getMoneda(anno)*/, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            DataSet ds = new DataSet();
            if (Request.Files["file"].ContentLength > 0)
            {
                string fileExtension =
                                     System.IO.Path.GetExtension(Request.Files["file"].FileName);

                if (fileExtension == ".xls" || fileExtension == ".xlsx")
                {
                    string fileLocation =  Server.MapPath("~/Content/") + Request.Files["file"].FileName;
                    if (System.IO.File.Exists(fileLocation))
                    {

                        System.IO.File.Delete(fileLocation);
                    }
                    Request.Files["file"].SaveAs(fileLocation);
                    string excelConnectionString = string.Empty;
                    excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                    //connection String for xls file format.
                    if (fileExtension == ".xls")
                    {
                        excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        fileLocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                    }
                    //connection String for xlsx file format.
                    else if (fileExtension == ".xlsx")
                    {
                        excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                    }
                    //Create Connection to Excel work book and add oledb namespace
                    OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                    excelConnection.Open();
                    DataTable dt = new DataTable();

                    dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dt == null)
                    {
                        return null;
                    }

                    String[] excelSheets = new String[dt.Rows.Count];
                    int t = 0;
                    //excel data saves in temp file here.
                    foreach (DataRow row in dt.Rows)
                    {
                        excelSheets[t] = row["TABLE_NAME"].ToString();
                        t++;
                    }
                    OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);


                    string query = string.Format("Select * from [{0}]", excelSheets[0]);
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                    {
                        dataAdapter.Fill(ds);
                    }
                }
                if (fileExtension.ToString().ToLower().Equals(".xml"))
                {
                    string fileLocation = Server.MapPath("~/Content/") + Request.Files["FileUpload"].FileName;
                    if (System.IO.File.Exists(fileLocation))
                    {
                        System.IO.File.Delete(fileLocation);
                    }

                    Request.Files["FileUpload"].SaveAs(fileLocation);
                    XmlTextReader xmlreader = new XmlTextReader(fileLocation);
                    // DataSet ds = new DataSet();
                    ds.ReadXml(xmlreader);
                    xmlreader.Close();
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {


                    lista.Add(new CargaGasto
                    {
                        CentroCosto = ds.Tables[0].Rows[i][0].ToString(),
                        CuentaContable = ds.Tables[0].Rows[i][2].ToString(),
                        Enero = decimal.Parse(ds.Tables[0].Rows[i][6].ToString()),
                        Febrero = decimal.Parse(ds.Tables[0].Rows[i][7].ToString()),
                        Marzo = decimal.Parse(ds.Tables[0].Rows[i][8].ToString()),
                        Abril = decimal.Parse(ds.Tables[0].Rows[i][9].ToString()),
                        Mayo = decimal.Parse(ds.Tables[0].Rows[i][10].ToString()),
                        Junio = decimal.Parse(ds.Tables[0].Rows[i][11].ToString()),
                        Julio = decimal.Parse(ds.Tables[0].Rows[i][12].ToString()),
                        Agosto = decimal.Parse(ds.Tables[0].Rows[i][13].ToString()),
                        Septiembre = decimal.Parse(ds.Tables[0].Rows[i][14].ToString()),
                        Octubre = decimal.Parse(ds.Tables[0].Rows[i][15].ToString()),
                        Noviembre = decimal.Parse(ds.Tables[0].Rows[i][16].ToString()),
                        Diciembre = decimal.Parse(ds.Tables[0].Rows[i][17].ToString()),

                    });   
                  
                }
            }
            return View();
        }




    }
   
}
