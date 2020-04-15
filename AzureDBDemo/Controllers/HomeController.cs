using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureDBDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            */string conn = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            SqlConnection sconn = new SqlConnection(conn);
            sconn.Open();
            SqlCommand sc = new SqlCommand("select * from tbldemo", sconn);
            SqlDataReader reader= sc.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);/*

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}