using ODataPeopleViewer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Models
{
    public class Person
    {
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public PersonGender Gender { get; }
        public uint Age { get; }
        public List<string> Emails { get; }
        public string FavoriteFeature { get; }
        public AddressInfo AddressInfo { get; }
    }
}
