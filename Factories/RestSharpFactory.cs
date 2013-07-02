﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrestaSharp.Serializers
{
    public abstract class RestSharpFactory
    {

        protected string BaseUrl{get;set;}
        protected string Account{get;set;}
        protected string Password{get;set;}

        public RestSharpFactory(string BaseUrl, string Account, string Password)
        {
            this.BaseUrl = BaseUrl;
            this.Account = Account;
            this.Password = Password;
        }

        protected T Execute<T>(RestRequest Request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = this.BaseUrl;
            client.Authenticator = new HttpBasicAuthenticator(this.Account, this.Password);
            Request.AddParameter("Account", this.Account, ParameterType.UrlSegment); // used on every request
            var response = client.Execute<T>(Request);
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var Exception = new ApplicationException(message, response.ErrorException);
                throw Exception;
            }
            return response.Data;
        }

        protected void ExecuteAsync<T>(RestRequest Request) where T : new()
        {
            var client = new RestClient(this.BaseUrl);
            try
            {
                client.ExecuteAsync(Request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine(response.ToString());
                    }
                    else
                    {
                        Console.WriteLine(response.ToString());
                    }
                });
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }

    }
}
