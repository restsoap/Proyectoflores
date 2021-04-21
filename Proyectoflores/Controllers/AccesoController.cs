﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectoflores.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Accesso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(int User, string Pass)
        {
            try
            {
                using (Models.proyectofloresEntities db = new Models.proyectofloresEntities())
                {
                    var oUser = (from d in db.usuario
                                 where d.cedula == User && d.password == Pass.Trim()
                                 select d).FirstOrDefault();
                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o contraseña invalida";
                        return View();
                    }

                    //creamos la sesion del usuario
                    Session["User"] = oUser;

                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

        }
    }
}