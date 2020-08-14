using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace TrainReservation
{
    /// <summary>
    /// Interaction logic for ListTrain.xaml
    /// </summary>
    public partial class ListTrain : Page
    {
        TrainEntities db;

        public ListTrain()
        {
            InitializeComponent();

          
          
        }

        public ListTrain(TrainEntities db,DateTime fulltime,Station station1,Station station2)
        {
            InitializeComponent();
            this.db = db;

            DateTimeFormatInfo dateformat = new CultureInfo("pl-PL").DateTimeFormat;

            var linqsearchTravel = from x in db.Connection
                                   where x.Id_station == station1.Id_station & x.Id_station2 == station2.Id_station 
                                   & x.km>=0
                                   select x;
            int numberOfConnection = linqsearchTravel.Count();
            
            listView.ItemsSource = linqsearchTravel.ToList();
            

        }
    }
}
