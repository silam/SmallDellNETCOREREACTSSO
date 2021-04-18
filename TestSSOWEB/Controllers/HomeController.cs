using Saml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSSOWEB.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if (true)
            {
                if (!Request.IsAuthenticated)
                {
                    //TODO: specify the SAML provider url here, aka "Endpoint"
                    var samlEndpoint = "https://login.microsoftonline.com/cdd071d0-805d-4b10-bac9-ee8225b4cbdc/saml2"; //"http://saml-provider-that-we-use.com/login/";

                    var request = new AuthRequest(
                        "599e9d7b-b868-4aaf-b422-85fe1d29c37e", //TODO: put your app's "unique ID" here
                        "https://localhost:44370/Home/SamlConsume" //TODO: put Assertion Consumer URL (where the provider should redirect users after authenticating)
                        );

                    //redirect the user to the SAML provider
                    return Redirect(request.GetRedirectUrl(samlEndpoint));
                }
                else
                    return View();
            }
            else
                return View();
        }
                
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SamlConsume()
        {
            // 1. TODO: specify the certificate that your SAML provider gave you
            string samlCertificate = @"-----BEGIN CERTIFICATE-----
MIIC8DCCAdigAwIBAgIQM3I45fFZSqxJuCRQNTFVojANBgkqhkiG9w0BAQsFADA0MTIwMAYDVQQD
EylNaWNyb3NvZnQgQXp1cmUgRmVkZXJhdGVkIFNTTyBDZXJ0aWZpY2F0ZTAeFw0yMDA2MDYyMTUz
NTJaFw0yMzA2MDYyMTUzNTJaMDQxMjAwBgNVBAMTKU1pY3Jvc29mdCBBenVyZSBGZWRlcmF0ZWQg
U1NPIENlcnRpZmljYXRlMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA4S1LqOCOEf/Q
/HtbvtcuCmPl8GKG0VCUde8vSVJuKc++jrwUq7J5lpUkTqHIbYLoFSucw5XjZNAVzdY8bUCDFjcU
1GEiWGTAGSbR+BZ7tfu9OatbU/0pMBSZCP1lN8yGt7NinBIb+ZAY5xAALxqm7r3Qjo7/pIHI1zCT
UpkG5w02KS895SZLocjUj3F6KEWpBlK7b+vOmjtYPzJ0xortpQI6yG+xzGkNjJKRazg7q/myLR1B
KKofJivqY9HGpqUT4pU8FECRDSJ2Cu4l3NJrkOJo8fHxr4vzQXbmp9jwVifMgIn4WlgRsSQTiJGN
itZwmypcXdyEsyVL9ZZRGIARVQIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQCv8WhSTI9HVXZM9N0B
1hzfV1LunQHeWgHniHDTEN2dJ28x00fGknsy7VFT/Ptj7jOLnGJcfCl6AmBYzHm+K5NyuZwyi9Ok
RNA42/X6SJluTQdtHhgGKKd8wUR98eocAljoFVZGJhJV9s+Gb30sylBdiKEXY3Gy4yr2C1TKnAe1
r4YA9Ov+bgE25OKrFwg5NkWc6qhNmE2peZ8qOaDuWOXdUz2tnb3s5XVefgr00cdipyCxdsE6jKj5
5BXbr7NmU/GYPgdcp+qITLd3yeikfME0RglShutnclBpqixl7KZJBx2UCl9FznhjgMz1XsoGE1FP
Gjjil5tGAGy70hE9QpDU
-----END CERTIFICATE-----";

            // 2. Let's read the data - SAML providers usually POST it into the "SAMLResponse" var
            Saml.Response samlResponse = new Response(samlCertificate, Request.Form["SAMLResponse"]);

            // 3. We're done!
            if (samlResponse.IsValid())
            {
                //WOOHOO!!! user is logged in

                //Some more optional stuff for you
                //let's extract username/firstname etc
                string username, email, firstname, lastname;
                try
                {
                    username = samlResponse.GetNameID();
                    email = samlResponse.GetEmail();
                    firstname = samlResponse.GetFirstName();
                    lastname = samlResponse.GetLastName();
                }
                catch (Exception ex)
                {
                    //insert error handling code
                    //no, really, please do
                    return null;
                }

                //user has been authenticated, put your code here, like set a cookie or something...
                //or call FormsAuthentication.SetAuthCookie() or something
            }
            ViewBag.Message = "You Logged in.";

            return View();
        }

    }
}