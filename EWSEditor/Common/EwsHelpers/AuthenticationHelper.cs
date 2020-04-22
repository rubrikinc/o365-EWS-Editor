using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EWSEditor.Common.Extensions;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Identity.Client;
using Microsoft.Build.Execution;
using EWSEditor.Forms;
using System.Xml;
using System.Net;
using Microsoft.Exchange.WebServices.Autodiscover;
using System.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;  // Needed for oAuth

namespace EWSEditor.Common
{
    public class AuthenticationHelper
    {

        //public  bool Do_OAuth(ref ExchangeService oService, ref string MailboxBeingAccessed, ref string AccountAccessingMailbox,
        //    string sAuthority, string sAppId, string sRedirectURL, string sServername)
        //{
        //    bool bRet = false;


        //    // See // https://msdn.microsoft.com/en-us/library/office/dn903761(v=exchg.150).aspx
        //    // get authentication token
        //    string authority = sAuthority;
        //    string clientID = sAppId;
        //    Uri clientAppUri = new Uri(sRedirectURL);
        //    string serverName = sServername;

        //    AuthenticationContext authenticationContext = new AuthenticationContext(authority, false);
        //    PlatformParameters oPlatformParameters = new PlatformParameters(PromptBehavior.Always);
        //    AuthenticationResult authenticationResult =   authenticationContext.AcquireTokenAsync(serverName, clientID, clientAppUri, oPlatformParameters).Result; 

        //      //System.Diagnostics.Debug.WriteLine(authenticationResult.UserInfo.DisplayableId);
        //      MailboxBeingAccessed = authenticationResult.UserInfo.DisplayableId;
        //    AccountAccessingMailbox = authenticationResult.UserInfo.DisplayableId;  // oAuth at this time does not support delegate or impersonation access - may need to change this in the future.

        //    // Add authenticaiton token to requests
        //    oService.Credentials = new OAuthCredentials(authenticationResult.AccessToken);

        //    bRet = true;
        //    return bRet;

        //}


        public ExchangeCredentials Do_OAuth(ref string MailboxBeingAccessed, ref string AccountAccessingMailbox,
            string sAuthority, string sAppId, string sRedirectURL, string sServername, ref string sBearerToken, PromptBehavior oPromptBehavior)
        {

            ExchangeCredentials oExchangeCredentials = null;

            // See // https://msdn.microsoft.com/en-us/library/office/dn903761(v=exchg.150).aspx
            // get authentication token
            string authority = sAuthority;
            string clientID = sAppId;
            Uri clientAppUri = new Uri(sRedirectURL);
            string serverName = sServername;
            AuthenticationContext authenticationContext = new AuthenticationContext(authority, false);
            PlatformParameters oPlatformParameters = new PlatformParameters(oPromptBehavior);
            Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult authenticationResult = authenticationContext.AcquireTokenAsync(serverName, clientID, clientAppUri, oPlatformParameters).Result;

            sBearerToken = authenticationResult.AccessToken;
            // Add authenticaiton token to requests
            oExchangeCredentials = new OAuthCredentials(authenticationResult.AccessToken);
            //oExchangeCredentials = new OAuthCredentials(sBearerToken);
            MailboxBeingAccessed = "josh.lim@rdnn14.onmicrosoft.com";
            AccountAccessingMailbox = "admin.o365@rdnn14.onmicrosoft.com";
            //MailboxBeingAccessed = authenticationResult.UserInfo.DisplayableId;
            //AccountAccessingMailbox = authenticationResult.UserInfo.DisplayableId;  // oAuth at this time does not support delegate or impersonation access - may need to change this in the future.

            return oExchangeCredentials;

        }

        public ExchangeCredentials Do_OAuth(string sTenantId, string sAppId, string sAppSecret, string sAuthority, string sScope,ref string sBearerToken)
        {

            ExchangeCredentials oExchangeCredentials = null;

            // See // https://msdn.microsoft.com/en-us/library/office/dn903761(v=exchg.150).aspx
            // get authentication token
            string authority;
            string clientID = sAppId;
            string sBearerTokenTmp = "";
            string clientSecret;

            //clientSecret = "0C3ViAL-b7d:TwEPWv3SZoqZsyrkhz-]";
            //clientSecret = "2824da3b-32df-4011-80a7-c251caad6bf4";

            //AuthenticationContext authenticationContext = new AuthenticationContext(authority, false);
            //PlatformParameters oPlatformParameters = new PlatformParameters(oPromptBehavior);
            //Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult authenticationResult = authenticationContext.AcquireTokenAsync(serverName, clientID, clientAppUri, oPlatformParameters).Result;

            //sBearerToken = authenticationResult.AccessToken;
            //sBearerTokenTmp = "eyJ0eXAiOiJKV1QiLCJub25jZSI6IlRINUdacExXYUw1S19LMmxhZnpaeWZlTHVvOWhXWGcyNVJHeENFTFdwZ3MiLCJhbGciOiJSUzI1NiIsIng1dCI6IllNRUxIVDBndmIwbXhvU0RvWWZvbWpxZmpZVSIsImtpZCI6IllNRUxIVDBndmIwbXhvU0RvWWZvbWpxZmpZVSJ9.eyJhdWQiOiJodHRwczovL291dGxvb2sub2ZmaWNlLmNvbSIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0LzA1YTVkNmUzLTZmNGEtNDU4NC1hYTAzLTc2ODY3MGU5MTg5OC8iLCJpYXQiOjE1ODY4OTk1NDksIm5iZiI6MTU4Njg5OTU0OSwiZXhwIjoxNTg2OTAzNDQ5LCJhaW8iOiI0MmRnWU5DNnE3cGdTaSszS1ArNUZPYk5WakgxQUE9PSIsImFwcF9kaXNwbGF5bmFtZSI6IkVXU0VkaXRvciIsImFwcGlkIjoiMzAwZTI3YzYtODg4Mi00ZjE2LTg5MjYtYmY2YTFhYjNlMjYxIiwiYXBwaWRhY3IiOiIxIiwiaWRwIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvMDVhNWQ2ZTMtNmY0YS00NTg0LWFhMDMtNzY4NjcwZTkxODk4LyIsIm9pZCI6IjBjODQwYzVjLWE0ZDUtNDczNi04NWQzLWQxOTQ3YmYxOGYwMCIsInJvbGVzIjpbIlRhc2tzLlJlYWQiLCJVc2VyLlJlYWQuQWxsIiwiZnVsbF9hY2Nlc3NfYXNfYXBwIiwiTWFpbC5SZWFkV3JpdGUiLCJNYWlsYm94U2V0dGluZ3MuUmVhZFdyaXRlIiwiQ2FsZW5kYXJzLlJlYWQiLCJQbGFjZS5SZWFkLkFsbCIsIlVzZXIuUmVhZEJhc2ljLkFsbCIsIkNvbnRhY3RzLlJlYWRXcml0ZSIsIk1haWxib3guTWlncmF0aW9uIiwiTWFpbC5SZWFkIiwiQ2FsZW5kYXJzLlJlYWRXcml0ZS5BbGwiLCJNYWlsLlNlbmQiLCJUYXNrcy5SZWFkV3JpdGUiLCJDb250YWN0cy5SZWFkIiwiQ2FsZW5kYXJzLlJlYWQuQWxsIiwiTWFpbGJveFNldHRpbmdzLlJlYWQiLCJFeGNoYW5nZS5NYW5hZ2VBc0FwcCJdLCJzaWQiOiIyOGZlMTAzNi0wNTY2LTQzMzItYTIyYS0xMzgyN2M1YzgzNTYiLCJzdWIiOiIwYzg0MGM1Yy1hNGQ1LTQ3MzYtODVkMy1kMTk0N2JmMThmMDAiLCJ0aWQiOiIwNWE1ZDZlMy02ZjRhLTQ1ODQtYWEwMy03Njg2NzBlOTE4OTgiLCJ1dGkiOiJ2UWVUWEk5Q2RVeTdqQW9OelNrSEFBIiwidmVyIjoiMS4wIn0.nZ2sPZ5mOVOxRhRxNxdcuQ_eGsaHD_Jtiv7scj2RvDwoUGtvBvkXo2Hi_xVVMe2QTv2k-MUDBjJElCTWyw_TGpVz89WvvmQwHXVHUTGIJVIPRZaOUg9lbtIzSmfo2TwrZ_00lztDtncFmITzpTKfaU5Y5KHw_TlHSBzF8yS1grpmnyyiZwcY62SrtQeg3e_4Eu3LNGePyUqQoAiwrXun5IE7RiwwNK7QfE9cpoDzjgQIEd3deALfqe-Y8kWRl4-cK1oonqInLueuVMWQ7-96dS1PwQHca9eMyKyxcj3zKV0yW42k3T0xXBD5kR9xByd6py9TBD2Hjg9QyW3kuEDQmg";
            //sBearerTokenTmp = authenticationResult.AccessToken;
            sBearerToken = sBearerTokenTmp;

            //IConfidentialClientApplication app;

            //string scope = "https://outlook.office.com/";
            string[] scopes = new string[] { $"{sScope}" };
            //authority = "https://login.microsoftonline.com/"+ sTenantId;
            authority = sAuthority + sTenantId;
            clientSecret = sAppSecret;
            Microsoft.Identity.Client.AuthenticationResult result = ConfidentialClientApplicationBuilder.Create(clientID)
                    .WithClientSecret(clientSecret)
                    .WithAuthority(new Uri(authority))
                    .Build().AcquireTokenForClient(scopes).ExecuteAsync().Result;


            sBearerToken = result.AccessToken;
            oExchangeCredentials = new OAuthCredentials(sBearerToken);
             //MailboxBeingAccessed = "";
             //AccountAccessingMailbox = "";
            //MailboxBeingAccessed = result.UserInfo.DisplayableId;
            //AccountAccessingMailbox = authenticationResult.UserInfo.DisplayableId;  // oAuth at this time does not support delegate or impersonation access - may need to change this in the future.
            return oExchangeCredentials;
        }



        public ExchangeCredentials Do_OAuth( ref string MailboxBeingAccessed, ref string AccountAccessingMailbox,
            string sAuthority, string sAppId, string sRedirectURL, string sServername, ref string sBearerToken)
        {

            return Do_OAuth(ref MailboxBeingAccessed, ref AccountAccessingMailbox,sAuthority, sAppId, sRedirectURL, sServername, ref sBearerToken, PromptBehavior.Always);

            //ExchangeCredentials oExchangeCredentials = null;

            //// See // https://msdn.microsoft.com/en-us/library/office/dn903761(v=exchg.150).aspx
            //// get authentication token
            //string authority = sAuthority;
            //string clientID = sAppId;
            //Uri clientAppUri = new Uri(sRedirectURL);
            //string serverName = sServername;

            //AuthenticationContext authenticationContext = new AuthenticationContext(authority, false);
            //PlatformParameters oPlatformParameters = new PlatformParameters(PromptBehavior.Always);
            //AuthenticationResult authenticationResult = authenticationContext.AcquireTokenAsync (serverName, clientID, clientAppUri, oPlatformParameters).Result;

            //sBearerToken = authenticationResult.AccessToken;

            //// Add authenticaiton token to requests
            //oExchangeCredentials = new OAuthCredentials(authenticationResult.AccessToken);

            //MailboxBeingAccessed = authenticationResult.UserInfo.DisplayableId;
            //AccountAccessingMailbox = authenticationResult.UserInfo.DisplayableId;  // oAuth at this time does not support delegate or impersonation access - may need to change this in the future.

           // return oExchangeCredentials;

        }

    }
}
