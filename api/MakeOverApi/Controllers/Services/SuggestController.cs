﻿using MakeOverApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MakeOverApi.Controllers.HotDeals
{
    public class SuggestController : ApiController
    {

        [HttpPost]
        public ResponseDto Post(FaceDataRequestDto[] faceDto)
        {
            //return dynamic response here
            return new ResponseDto()
            {
                faceId = faceDto.FirstOrDefault().faceId,
                prodlist = new List<ProductCatalogue>()
                {
                    new ProductCatalogue()
                    {
                        imageUrl = "https://images-eu.ssl-images-amazon.com/images/I/71oh4nqgS0L._AC_SY230_.jpg",
                        title= "Magic Attitude Fisherman Denim Cap",
                        rating="4",
                        actualprice="Rs.599",
                        offerPrice="Rs.299"
                    },
                    new ProductCatalogue()
                    {
                        imageUrl = "https://images-eu.ssl-images-amazon.com/images/I/81Wlvm5weoL._AC_SY230_.jpg",
                        title= "KIDANIA Kids Cotton Fancy Hat/Cap for Girls",
                        rating="3",
                        actualprice="Rs.499",
                        offerPrice="Rs.199"
                    },
                      new ProductCatalogue()
                    {
                        imageUrl = "https://images-eu.ssl-images-amazon.com/images/I/81aTY-m4PKL._AC_SY230_.jpg",
                        title= "Zacharias Girl's Visor Tennis Cap",
                        rating="3.5",
                        actualprice="Rs.200",
                        offerPrice="Rs.299"
                    }
                }
            };
        }

    }
}
