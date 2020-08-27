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
        Frame frame1;

        public ListTrain()
        {
            InitializeComponent();

          
          
        }

        public ListTrain(Frame frame1, TrainEntities db,DateTime fulltime,Station station1,Station station2)
        {
            InitializeComponent();
            this.db = db;
            this.frame1 = frame1;

            DateTimeFormatInfo dateformat = new CultureInfo("pl-PL").DateTimeFormat;

            var linqsearchTravel = from x in db.Connection
                                   where x.Id_station == station1.Id_station & x.Id_station2 == station2.Id_station 
                                   & x.km>=0
                                   select x;
            int numberOfConnection = linqsearchTravel.Count();
            
            listView.ItemsSource = linqsearchTravel.ToList();
            

        }

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            ChosePlace chosePlace1 = new ChosePlace();
            frame1.Content = chosePlace1;

        }
    }
}
