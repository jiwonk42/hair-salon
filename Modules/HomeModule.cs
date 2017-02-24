using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace HairSalon
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Stylist> AllStylists = Stylist.GetAll();
        return View["index.cshtml", AllStylists];
      };
      Get["/clients"] = _ => {
        List<Client> AllClients = Client.GetAll();
        return View["clients.cshtml", AllClients];
      };
      Get["/stylists"] = _ => {
        List<Stylist> AllStylists = Stylist.GetAll();
        return View["stylists.cshtml", AllStylists];
      };
      Get["/stylists/new"] = _ => {
        return View["stylists_form.cshtml"];
      };

      // success.cshtml -> stylists.cshtml
      Post["/stylists/new"] = _ => {
        Stylist newStylist = new Stylist(Request.Form["stylist-name"], Request.Form["stylist-specialize"]);
        newStylist.Save();
        return View["stylists.cshtml"];
      };
      Get["/clients/new"] = _ => {
        List<Stylist> AllStylists = Stylist.GetAll();
        return View["clients_form.cshtml", AllStylists];
      };

      // success.cshtml -> clients.cshtml
      Post["/clients/new"] = _ => {
        Client newClient = new Client(Request.Form["client-name"], Request.Form["client-phone"], Request.Form["client-address"], Request.Form["stylist-id"]);
        newClient.Save();
        return View["clients.cshtml"];
      };
    }
  }
}
