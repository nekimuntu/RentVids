using RentVids.Models;
using RentVids.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentVids.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> movies = new List<Movie>
            {
                new Movie {Name="Inception"},
                new Movie {Name="Tree Factory"},
                new Movie {Name="Star Wars"}
            };
        // GET: Movie
        public ActionResult Random()
            //ViewResult should be return but ActionResult is broader
        {
            Movie movie = new Movie() { Name = "Star wars"};
            var customers = new List<Customer> { 
                new Customer {Name = "Tay"},
                new Customer {Name = "Yannick"},
                new Customer {Name = "Kimuntu"},
                new Customer {Name = "Pablo"},
                new Customer {Name = "Karin"},
                new Customer {Name = "Isidor"}
            };
            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;
            return View(viewModel);
            //return new ViewResult();
            //Another way to call the view
            //return Content("Hello world") plain text
            //return HttpNotFound(); 
            //return new EmptyResult();
            //return RedirectToAction("Index","Home",new {page =1, sortBy ="name"} );
        }
        //We add to the route the constraints d4 and between 1 -12
        [Route("Movie/Release/{year}/{month:regex(\\d{2}:range(1,12)}")]
        public ActionResult ByReleaseDate(int year,byte month)
        {
            var movie = new Movie() { Id=1, Name = "Waking Life" };
            ViewData["movie"] = movie;
            return View(ViewData["movie"]);
            //return Content("year "+year+" month "+month);
        }

        public ActionResult Edit(string s)
        {
            return Content(s);
            //It doesnt works because the parametetr is not called Id
            // You needs to specify an other route for using differents parameters (RouteConfig .RegisterRoute)
            //or Decorate the controller [Route("Movie/Edit")]
        }
        [Route("Movie/")]
        public ActionResult Index()
        {

            return View(this.movies);
            
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(String.Format("PageInde={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}