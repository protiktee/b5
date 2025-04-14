using Inventory_b5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_b5.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Login(string txtUserName,string txtPassword)
        //{
        //    ViewBag.UserName = txtUserName;
        //    return View();
        //}
        public ActionResult Login(string txtUserName, string txtPassword)
        {

            BaseMember baseMember = new BaseMember();
            //DataTable dt=baseMember.ValidateMemberAsDataTable(txtUserName, txtPassword);
            //if (dt.Rows.Count > 0)
            //{
            //    Session["UserName"] = txtUserName;
            //    return Redirect(Url.Action("About", "Home"));
            //}

            List<BaseMember> lstMember=baseMember.ValidateMemberAsList(txtUserName, txtPassword);
            bool statusValid = false;
            foreach (BaseMember baseMember1 in lstMember)
            {
                if (baseMember1.Name == txtUserName && baseMember1.Password == txtPassword)
                {
                    statusValid = true; 
                }
            }
            if (statusValid)
            {
                Session["UserName"] = txtUserName;
                //return Redirect(Url.Action("About", "Home"));
            }
            
            return View();
        }
        public ActionResult Logout()
        {
            if (Session["UserName"] != null)
            {
                Session.Remove("UserName");
            }
            return Redirect(Url.Action("Login", "Auth"));
        }
    }
}