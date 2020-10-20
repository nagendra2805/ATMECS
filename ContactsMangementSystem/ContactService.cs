using ContactsMangementSystem.Interfaces;
using ContactsMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using System.Windows;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ContactsMangementSystem
{
    public class ContactService :IContactService
    {
        private readonly HttpClient _httpclient;
        public ContactService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public List<Contact> CallContatcAPI(string requestUrl, Contact contact)
        {
            try
            {
                using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                httpRequestMessage.Content = new ByteArrayContent(JsonSerializer.SerializeToUtf8Bytes(contact));
                httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var httpResponse = _httpclient.SendAsync(httpRequestMessage).Result;

                return httpResponse.Content.ReadFromJsonAsync<List<Contact>>().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again we encountered an error :" + ex.Message);
                return null;
            }
            
        }
    }
}
