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
using System.Data.SqlClient;
using System.Net.Mail;

namespace WindowsApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //once the application launches all tabs but the home tab
            //will be hidden until user login
            InitializeComponent();
            //tabPatientInfo.Visibility = Visibility.Hidden;
            //tabNewPatient.Visibility = Visibility.Hidden;
            //tabAppointment.Visibility = Visibility.Hidden;
            //tabMessage.Visibility = Visibility.Hidden;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

       
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.To.Add("");
                MailAddress address = new MailAddress("healthguardist440w@gmail.com");
                msg.From = address;
                msg.Subject = txtTo.Text + ": " + txtSubject.Text;

                SmtpClient client = new SmtpClient("smtp.live.com", 587);

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("healthguardist440w@gmail.com", "ist440Wspring");
                client.Credentials = credentials;
                client.EnableSsl = true;

                client.Send(msg);

                txtResult.Text = "Your message was sent!";

                //Clear the form
                
            }
            catch
            {
                //If the message failed at some point, let the user know
                txtResult.Text = "Your message failed to send, please try again.";

                //Clear the form
                

            }
        }

        

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            txtConfirm.Text = txtPatient.Text + " is scheduled for: " + txtAppDate.Text + " at " + txtTime.Text;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow win = new LoginWindow();
            win.Show();
            this.Close();
        }

       
    }
}
