using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Menu.Model
{
    public class PrintPersonsToConsoleRequest
    {
        public List<Person> Persons { get; set; }
    }
}
