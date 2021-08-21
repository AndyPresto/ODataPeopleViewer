﻿using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODataPeopleViewer.OData.Model;

namespace ODataPeopleViewer.OData
{
    public interface IOData
    {
        public Task<GetPeopleResponse> GetPeople(GetPeopleRequest request);
    }

    public class OData : IOData
    {
        private readonly string _serviceRoot;
        private DefaultContainer _context;

        public OData()
        {
            _serviceRoot = "https://services.odata.org/V4/TripPinServiceRW/";
            _context = new DefaultContainer(new Uri(_serviceRoot));
        }

        public async Task<GetPeopleResponse> GetPeople(GetPeopleRequest request)
        {
            var response = new GetPeopleResponse();
           
            var result = await _context.People.ExecuteAsync();
            response.People = result.ToList();

            return response;
        }
    }
}
