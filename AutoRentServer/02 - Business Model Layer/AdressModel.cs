using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    class AdressModel
    {
        public int AdressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AdressLine { get; set; }
        public string PostalZipCode { get; set; }

        public AdressModel(Adress adress)
        {
            AdressId = adress.AdressId;
            Country = adress.Country;
            City = adress.City;
            AdressLine = adress.AdressLine;
            PostalZipCode = adress.PostalZipCode;
        }
    }
}
