using Inventory_b5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_b5.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard NewEquipmentAssignment
        public ActionResult Index()
        { 
            BaseEquipment baseEquipment = new BaseEquipment();
            List<BaseEquipment> lstEquipment = baseEquipment.ListEquipment();

            //List<BaseEquipment> lstEquipment_laptop = new List<BaseEquipment>();
            //foreach (BaseEquipment obj in lstEquipment)
            //{
            //    if (obj.EquipmentName.Contains("Laptop"))
            //    {
            //        lstEquipment_laptop.Add(obj);
            //    }
            //}
            ViewBag.lstEquipment = lstEquipment;


            return View();
        }
        [HttpPost]
        public ActionResult Index(string btnSubmit, FormCollection formCollection)
        {
            BaseEquipment baseEquipment = new BaseEquipment();

            int ReturnStatus = 0;
            if (btnSubmit == "Update")
            {
                baseEquipment.EquipmentId= Convert.ToInt32(formCollection["EquipmentID"].ToString());
                baseEquipment.EquipmentName = formCollection["txtEquipName"].ToString();
                baseEquipment.Quantity = Convert.ToInt32(formCollection["txtQuantity"].ToString());
                baseEquipment.EntryDate = Convert.ToDateTime(formCollection["txtEntryDate"].ToString());
                baseEquipment.ReceiveDate = Convert.ToDateTime(formCollection["txtRcvDate"].ToString());
                ReturnStatus = baseEquipment.SaveEquipment();
            }
            if (btnSubmit == "Delete")
            {
                //
            }
            if (btnSubmit == "Save")
            {
                baseEquipment.EquipmentName = formCollection["txtEquipName"].ToString();
                baseEquipment.Quantity = Convert.ToInt32(formCollection["txtQuantity"].ToString());
                baseEquipment.EntryDate = Convert.ToDateTime(formCollection["txtEntryDate"].ToString());
                baseEquipment.ReceiveDate = Convert.ToDateTime(formCollection["txtRcvDate"].ToString());
                ReturnStatus=baseEquipment.SaveEquipment();
            }
            
            List<BaseEquipment> lstEquipment = baseEquipment.ListEquipment();

            //List<BaseEquipment> lstEquipment_laptop = new List<BaseEquipment>();
            //foreach (BaseEquipment obj in lstEquipment)
            //{
            //    if (obj.EquipmentName.Contains("Laptop"))
            //    {
            //        lstEquipment_laptop.Add(obj);
            //    }
            //}
            ViewBag.lstEquipment = lstEquipment;
            if (ReturnStatus > 0)
                ViewBag.OutMessage = "Operation Completed Successfully";
            return View();
        }
        //public ActionResult Save() { 
        //private void Load
        public ActionResult NewEquipmentAssignment()
        {
            BaseEquipment baseEquipment = new BaseEquipment();
            List<BaseEquipment> lstEquipment = baseEquipment.ListEquipment();

            //List<BaseEquipment> lstEquipment_laptop = new List<BaseEquipment>();
            //foreach (BaseEquipment obj in lstEquipment)
            //{
            //    if (obj.EquipmentName.Contains("Laptop"))
            //    {
            //        lstEquipment_laptop.Add(obj);
            //    }
            //}
            ViewBag.lstEquipment = lstEquipment;
            return View();
        }
        [HttpPost]
        public ActionResult NewEquipmentAssignment(FormCollection frmCol)
        { 
            int returnval= BaseEquipment.SaveEquipmentAssignment(frmCol);
            if (returnval > 0)
            {
                ViewBag.OutMessage = "Operation Completed Successfully";
                return Redirect(Url.Action("Index","Dashboard"));
            }
            ViewBag.OutMessage = "Operation failed";
            return View();
        }
    }
}