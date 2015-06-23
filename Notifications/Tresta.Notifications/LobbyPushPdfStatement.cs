using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Configuration;

namespace Tresta.Notifications
{
    public class LobbyPushPdfStatement
    {
        public void PutStatement(string paymentId, string customerId, DateTime statementPosted, string statementLink)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.Headers.Add("content-type", "application/pdf");

            byte[] pdfStatement = File.ReadAllBytes(statementLink);
            string statementDate = statementPosted.ToString("o");
            byte[] pdfIdentitifer = Encoding.ASCII.GetBytes(customerId + paymentId + statementDate);
            string hmacSha = GenerateHmac(Combine(pdfIdentitifer, pdfStatement));

            NameValueCollection queryString = new NameValueCollection();
            queryString.Add("hmac", hmacSha);
            queryString.Add("statementDate", statementDate);
            webClient.QueryString = queryString;

            string serverAddress = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.statementRestAddress"); 
            string url = serverAddress + "/" + customerId + "/" + paymentId;
            Encoding.ASCII.GetString(webClient.UploadData(url, "PUT", pdfStatement));
            return;
        }

        private static byte[] Combine(byte[] a, byte[] b)
        {
            byte[] c = new byte[a.Length + b.Length];
            System.Buffer.BlockCopy(a, 0, c, 0, a.Length);
            System.Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }

        private static string GenerateHmac(byte[] message)
        {
            string signingKey = ConfigurationSettings.AppSettings.Get("Tresta.Notifications.statementSignatureKey");
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] signingKeyBytes = encoding.GetBytes(signingKey);

            HMACSHA1 hmac = new HMACSHA1(signingKeyBytes);
            byte[] hmacSha1 = hmac.ComputeHash(message);

            String hmacSha1HexString = BitConverter.ToString(hmacSha1);
            return hmacSha1HexString.Replace("-", "");
        }
    }
}
