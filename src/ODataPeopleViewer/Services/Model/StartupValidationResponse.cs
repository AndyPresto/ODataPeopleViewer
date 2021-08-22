using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Services.Model
{
    public class StartupValidationResponse
    {
        public bool ValidationsPassed { get; set; }

        public string ErrorMessage { get; set; }
    }
}
