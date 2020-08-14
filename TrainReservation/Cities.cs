using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservation
{
    class Cities
    {
        public string CityName { get; set; }


        public Cities()
        { }

        public Cities(string city)
        {
            this.CityName = city;
        }


        public IEnumerable<Cities> CitiesList()
        {

            List<Cities> Listcieties = new List<Cities>();
            //Cities city = new Cities();


            Listcieties.Add(new Cities("Katowice"));
            Listcieties.Add(new Cities("Zawiercie"));
            Listcieties.Add(new Cities("Włoszczowa"));
            Listcieties.Add(new Cities("Opoczno"));
            Listcieties.Add(new Cities("Warszawa Zachodnia"));
            Listcieties.Add(new Cities("Warszawa Centralna"));
            Listcieties.Add(new Cities("Warszawa Wschodnia"));
            Listcieties.Add(new Cities("Gdańsk"));

            return Listcieties;
        }




    }


    

}
