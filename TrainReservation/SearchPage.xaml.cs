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

namespace TrainReservation
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        Frame frame1;
        TrainEntities db;

        public SearchPage()
        {
            InitializeComponent();
        }

        public SearchPage(Frame frame1,TrainEntities db)
        {
            InitializeComponent();
            this.frame1 = frame1;
            this.db = db;

            DateTime timeNow = DateTime.Now;

            datapic1.SelectedDate = timeNow;
            txt_hour.Text = timeNow.Hour.ToString();
            txt_minute.Text = timeNow.Minute.ToString();

            Cities city = new Cities();




            cmb_from.ItemsSource = db.Station.ToList();
            cmb_to.ItemsSource = db.Station.ToList();



        }


       

        private void btn_Search_Click_1(object sender, RoutedEventArgs e)
        {
            string date = "";
            if (cmb_from.SelectedIndex > -1 & cmb_to.SelectedIndex > -1)
            {
                 date = "z: " + cmb_from.Text.ToString() + "  do : " + cmb_to.Text.ToString() + " dnia: " + datapic1.SelectedDate.ToString() + " o godz: " + txt_hour.Text + " min: " + txt_minute.Text;
                
                int hour = int.Parse(txt_hour.Text);
                int minute = int.Parse(txt_minute.Text);
                DateTime fulltime = new DateTime(datapic1.SelectedDate.Value.Year, datapic1.SelectedDate.Value.Month, datapic1.SelectedDate.Value.Day,hour,minute,0);


                //MessageBox.Show(fulltime.ToString());

                Station stationfrom = (Station)cmb_from.SelectedItem;

                Station stationTo = (Station)cmb_to.SelectedItem;

                ListTrain listTrain1 = new ListTrain(frame1,db,fulltime,stationfrom,stationTo);
                frame1.Content = listTrain1;
            }

           
        }



        //button 1 up click
        private void btn_up1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txt_hour.Text);
                if (number < 24)
                    number++;
                else
                    number = 1;

                txt_hour.Text = number.ToString();

            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
        }



        //Button 1 down clik
        private void btn_down1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txt_hour.Text);
                if (number > 1)
                    number--;
                else
                    number = 24;

                txt_hour.Text = number.ToString();

            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
        }



        //button 2 up click
        private void btn_up2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txt_minute.Text);
                if (number < 59)
                    number++;
                else
                    number = 0;


                txt_minute.Text = number.ToString();

            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
        }



        //button 2 down click
        private void btn_down2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txt_minute.Text);
                if (number > 0)
                    number--;
                else
                    number = 59;

                txt_minute.Text = number.ToString();

            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
        }

    }
}
