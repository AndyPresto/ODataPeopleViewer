using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.OData.Model
{
    public class GetPeopleResponse
    {
        public List<Person> People { get; set; }
    }
}
