using ContactsMangementSystem.Interfaces;
using ContactsMangementSystem.Models;
using Microsoft.Extensions.DependencyInjection;
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

namespace ContactsMangementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Contact> contacts;
        private readonly IContactService _contactService;
        private readonly IServiceProvider _service;
        public MainWindow(IServiceProvider service)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _contactService = _service.GetRequiredService<IContactService>();
            Reset();
            
        }
        
        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = listView.SelectedValue;
            if (item != null)
            {
                UpdateContact uc = new UpdateContact(_service);
                uc.DisplayContact((Contact)item);
                uc.Show();
            }
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var Name = textBox.Text;
            string[] names = Name.Split(' ');
            if (names.Count() > 1)
                listView.ItemsSource = contacts.Where(x => x.FirstName.Equals(names[0], StringComparison.InvariantCultureIgnoreCase) && x.LastName.Equals(names[1], StringComparison.InvariantCultureIgnoreCase));
            else
                MessageBox.Show("Please provide LastName and FirstName");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            if (!String.IsNullOrWhiteSpace(fnametextbox.Text) && !String.IsNullOrWhiteSpace(lnametextbox.Text))
            {

                contact.FirstName = fnametextbox.Text;
                contact.LastName = lnametextbox.Text;
                contact.DateofBirth = datePicker.SelectedDate.Value;
                contact.EmailIds = new List<string>() { emailid.Text, alternateemailid.Text };
                contact.MobileNumbers = new List<string>() { mobileno.Text, alternatemobileno.Text };

                try
                {
                    var requestUrl = "http://localhost:5001/api/Contact/CreateorUpdateContact";
                    contacts = _contactService.CallContatcAPI(requestUrl, contact);
                    if (contacts != null)
                    {
                        updateList(contacts);
                        MessageBox.Show("Contact has created successfuly.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please try again we encountered an error :" + ex.Message);
                }
            }
            else
                MessageBox.Show("Please provide LastName and FirstName");

            
        }

        public void updateList(List<Contact> contacts)
        {
            listView.ItemsSource = contacts;
            Reset();
        }
        private void Reset()
        {
            fnametextbox.Clear();
            lnametextbox.Clear();
            emailid.Clear();
            alternateemailid.Clear();
            mobileno.Clear();
            alternatemobileno.Clear();
            datePicker.SelectedDate = null;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
    }

}
