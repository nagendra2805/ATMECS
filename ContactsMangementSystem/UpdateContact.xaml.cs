using ContactsMangementSystem.Interfaces;
using ContactsMangementSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactsMangementSystem
{
    /// <summary>
    /// Interaction logic for UpdateContact.xaml
    /// </summary>
    public partial class UpdateContact : Window
    {
        private readonly IContactService _contactService;
        private List<Contact> contacts;
        private MainWindow _mainWindow;
        public UpdateContact(IServiceProvider service)
        {
            InitializeComponent();
            _contactService = service.GetRequiredService<IContactService>();
            _mainWindow = service.GetRequiredService<MainWindow>();
        }
            

        public void DisplayContact(Contact contact)
        {
                FName.Text = contact.FirstName.ToString();
                LName.Text = contact.LastName.ToString();
                dob.Text = contact.DateofBirth?.ToString("dd/MM/yyyy");
                emailid.Text = contact.EmailIds[0].ToString();
                alternateEmailId.Text = contact.EmailIds[1].ToString();
                mobileno.Text = contact.MobileNumbers[0].ToString();
                alternatemobileno.Text = contact.MobileNumbers[1].ToString();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                FirstName = FName.Text,
                LastName = LName.Text,
                DateofBirth = DateTime.ParseExact(dob.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                EmailIds = new List<string>()
                {
                    emailid.Text,alternateEmailId.Text
                },
                MobileNumbers = new List<string>() { mobileno.Text, alternatemobileno.Text }
            };
            try
            {
                var requestUrl = "http://localhost:5001/api/Contact/CreateorUpdateContact";
                contacts = _contactService.CallContatcAPI(requestUrl, contact);

                if (contacts != null)
                {
                    _mainWindow.updateList(contacts);
                    MessageBox.Show("Contact has been successfuly Updated.");
                    this.Close();
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again we encountered an error :"+ ex.Message);
            }
            
            
        }
    }
}
