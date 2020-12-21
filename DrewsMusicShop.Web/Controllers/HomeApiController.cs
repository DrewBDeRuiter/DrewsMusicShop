using DrewsMusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DrewsMusicShop.Data;
using DrewsMusicShop.Entity;
using AutoMapper;
using Autofac;


namespace DrewsMusicShop.Controllers
{
    public class HomeApiController : ApiController
    {
        private readonly IMapper _mapper;

        public HomeApiController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IHttpActionResult Get()
        {
            IHttpActionResult ret;
            GuitarViewModel gvm = new GuitarViewModel();

            MockData md = new MockData();
            List<Guitar> gList = md.GetAllGuitars().ToList();
            
            var model = _mapper.Map<GuitarViewModel>(gList);


            //if (model.Count() > 0)
            //{
            //    ret = Ok(gvm);
            //}
            //else
            //{
            //    ret = NotFound();
            //}
            ret = Ok(gvm);
            return ret ;
        }
    }
}
