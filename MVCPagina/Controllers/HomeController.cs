using MVCPagina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MVCPagina.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var listaServicios = new List<ServicioModel>();

            //listaServicios.Add(getServicio());
            //listaServicios.Add(getServicio());
            //listaServicios.Add(getServicio());
            //return View(listaServicios);
            return View();
        }

        //private ServicioModel getServicio() 
        //{
        //    ServicioModel servicio = new ServicioModel();
        //    servicio.Nombre = "Básico";
        //    servicio.Features.Add("Una pagina");
        //    servicio.Features.Add("Mantenimiento por 2 meses");
        //    servicio.Features.Add("Alta en buscadores");
        //    servicio.Features.Add("Estilo personalizado");
        //    servicio.Features.Add("Sin administracion personal");
        //    servicio.Precio = "$1400";
        //    servicio.CantidadIconos = 1;

        //    return servicio;

        //}

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        } 

        public ActionResult Mensaje()
        {
            ViewBag.Message = "El mail ha sido enviado correctamente.";
            return View("Contact");
        }
        public  ActionResult Error()
        {
            ViewBag.Error = "Lo sentimos, en este momento el servidor no pudo enviar su consulta. Intente mas tarde por favor.";
            return View("Contact");
        }
        public ActionResult EnviarMail(string name, string email, string phone, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(email);
                mail.To.Add("andres.yk.ipod@gmail.com");
                mail.Subject = "A&S Solutions. Consulta desde la página - " + phone;
                string Body = message;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mail);
                return RedirectToAction("Mensaje");
            }
            catch (Exception e)
            {
                ViewBag.Message = "No se ha podido enviar el mensaje: " + e.Message;
                return RedirectToAction("Error");
            }
        }

    }
}