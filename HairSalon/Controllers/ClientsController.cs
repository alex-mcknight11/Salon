using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Clients> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Clients client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Clients thisClients = _db.Clients.FirstOrDefault(clients => clients.ClientsId == id);
      return View(thisClients);
    }
    public ActionResult Edit(int id)
    {
      var thisClients = _db.Clients.FirstOrDefault(clients => clients.ClientsId == id);
      return View(thisClients);
    }

    [HttpPost]
    public ActionResult Edit(Clients clients)
    {
      _db.Entry(clients).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisClients = _db.Clients.FirstOrDefault(clients => clients.ClientsId == id);
      return View(thisClients);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClients = _db.Clients.FirstOrDefault(clients => clients.ClientsId == id);
      _db.Clients.Remove(thisClients);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}