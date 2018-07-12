using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vanilla_Vivo.Models;

namespace Vanilla_Vivo.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}