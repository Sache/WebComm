using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coursework
{
   public class Server
   {
      private static string CustomMsg { get; set; }
      public static string UriToRequest { get; set; }

      public static HttpListener StartServer(string ip, string port)
      {
         HttpListener server = new HttpListener(); // a web server on a loopback address
         server.Prefixes.Add("http://"+ ip + ":" + port + "/");
         //server.Prefixes.Add("http://localhost/");
         server.Start();
         Console.WriteLine("INFO: Server Started...");
         return server;
      }

      public static void CommandHandler(object listener)
      {
         while (true)
         {
            HttpListener webListener = (HttpListener)listener;
            try
            {
               HttpListenerContext accessRequest = webListener.GetContext();

               // Get Request
               StreamReader clientSentPost = new StreamReader(accessRequest.Request.InputStream); // Incoming 
               string sentData = clientSentPost.ReadToEnd();


               // Send Response
               HttpListenerResponse responseToClient = accessRequest.Response;
               byte[] buffer = null; //  Outgoing 
               string page = accessRequest.Request.Url.AbsolutePath;
               if (page != null)
               {
                  switch (page)
                  {
                     case "/adduser.php":
                         buffer = WebRequester(UriToRequest + page.Replace("/", ""), sentData);
                        break;

                     case "/SendData":
                        if (String.IsNullOrEmpty(CustomMsg))
                        {
                           string file = Directory.GetCurrentDirectory() + accessRequest.Request.Url.LocalPath;
                           file = "0test.xml";
                           TextReader readText = new StreamReader(file);
                           buffer = Encoding.UTF8.GetBytes(readText.ReadToEnd());
                           readText.Dispose();
                           break;
                        }
                        else
                        {
                           buffer = Encoding.UTF8.GetBytes(CustomMsg);
                           CustomMsg = null;
                           break;
                        }

                     default:
                        buffer = WebRequester(UriToRequest + page.Replace("/", ""), sentData);
                        break;
                  }
                  if (buffer.Length > 1)
                  {
                     responseToClient.ContentLength64 = buffer.Length;
                     Stream streamCreate = responseToClient.OutputStream; // Stream 
                     streamCreate.Write(buffer, 0, buffer.Length);
                  }

               }

               accessRequest.Response.Close();
            }
            catch (Exception e)
            {
               Console.WriteLine(e);
               webListener.GetContext().Response.Close();
            }

         }
      }

      public static void CustomMsgResponse(string val)
      {
         if (!String.IsNullOrEmpty(val))
         {
            CustomMsg = val;
         }

      }

      public static byte[] WebRequester(string url, string postData)
      {
         if (!String.IsNullOrEmpty(url))
         {
            //Web Request 
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader responseStream = new StreamReader(response.GetResponseStream()))
            {
               byte[] bytes = Encoding.UTF8.GetBytes(responseStream.ReadToEnd());
               return bytes;
            };

         }
         return null;
      }

   }
}