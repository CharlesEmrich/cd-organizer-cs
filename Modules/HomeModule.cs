
using System;
using Nancy;
using CdOrganizer.Objects;
using System.Collections.Generic;

namespace CdOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      //TODO: Add ability to add CDs to genres which don't already exist.
      //TODO: Add ability to search collection by artist.
      Get["/"] = _ => {
        Dictionary<string, object> indexDict = new Dictionary <string, object> {{"genres", Genre.GetAll()},
                                                                                {"cds", Cd.GetAll()}};
        return View["index.cshtml", indexDict];
      };
      Get["/filter/"] = _ => {
        Dictionary<string, object> indexDict = new Dictionary <string, object> {{"genres", Genre.GetAll()},
                                                                                {"cds", Cd.GetAll()},
                                                                                {"query", Genre.Find(int.Parse(Request.Query["genre"]))}};
        return View["index.cshtml", indexDict];
      };
      Post["/genre/new"] = _ => {
        Dictionary<string, object> indexDict = new Dictionary <string, object> {{"genres", Genre.GetAll()},
                                                                                {"cds", Cd.GetAll()}};
        Genre newGenre = new Genre(Request.Form["genre-name"]);
        return View["index.cshtml", indexDict];
      };
      Post["/cd/new"] = _ => {
        Dictionary<string, object> indexDict = new Dictionary <string, object> {{"genres", Genre.GetAll()},
                                                                                {"cds", Cd.GetAll()}};
        Cd newCd = new Cd(Request.Form["cd-title"],
                          Request.Form["cd-artist"],
                          int.Parse(Request.Form["cd-release-year"]),
                          Genre.Find(Request.Form["cd-genre"]));
        return View["index.cshtml", indexDict];
      };
    }
  }
}
