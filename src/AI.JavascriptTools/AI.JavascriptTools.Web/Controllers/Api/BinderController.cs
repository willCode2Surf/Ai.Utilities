using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AI.JavascriptTools.Web.Models;

namespace AI.JavascriptTools.Web.Controllers.Api
{
    public class BinderController : ApiController
    {
        public BinderModel Get()
        {
            return new BinderModel()
                {
                    Name = new Name()
                        {
                            FirstName = "Paul",
                            LastName = "Kavanaugh"
                        },
                    Address = new Address()
                        {
                            Street = "5064 Westgrove",
                            City = "Dallas",
                            State = "TX",
                            Zipcode = "75248"
                        },
                    Phone = "972-834-2779"
                };
        }
    }
}
