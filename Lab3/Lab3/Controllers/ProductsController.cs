﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        // GET: Products

        public string Index()

        {

            return "Produts/Index is displayed()";

        }



        //GET: /Products/Browse



        public string Browse()

        {



            return "Browse displayed()";

        }

        //GET: /Products/Details/105

        public string Details(string id)

        {

            string message = HttpUtility.HtmlEncode("Products.Browse, Id = " + id);



            return message;



        }

        //GET:/Products/Location/Zip/44134

        public string Zip(int zip)

        {

            string message = "Location displayed is 44134";

            return message;





        }

    }

}