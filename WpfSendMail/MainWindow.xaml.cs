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
using System.Net;
using System.Net.Mail;

namespace WpfSendMail
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string server = tbServer.Text;
            MailAddress from = new MailAddress(tbFrom.Text);
            MailAddress to = new MailAddress(tbTo.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "TEST";
            m.Body = "Hello";

            SmtpClient smtp = new SmtpClient(server, 25);
            try
            {
                smtp.Send(m);
                MessageBox.Show("Сообщение успешно отправлено");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            



        }
    }
}
