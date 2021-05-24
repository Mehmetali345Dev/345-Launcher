using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _345_Launcher
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        
        #region All the codes
        
        private void gün_but_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("İndirme tamamlandı", "Başarılı" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //Success message
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //File link and download folder
            string filePath = Path.GetDirectoryName(Application.ExecutablePath);
            string indir = filePath + @".\345 Launcher.exe";
            DownloadFileWithProgress("https://launcher.mehmetali345.xyz/assets/345%20Launcher.exe", indir, Pb_File, label1);
        }
        
        private void DownloadFileWithProgress(string DownloadLink, string TargetPath, Guna.UI2.WinForms.Guna2ProgressBar progress, Label labelProgress)
        {
            //Start Download
            // Function will return the number of bytes processed
            // to the caller. Initialize to 0 here.
            int bytesProcessed = 0;

            // Assign values to these objects here so that they can
            // be referenced in the finally block
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            // Use a try/catch/finally block as both the WebRequest and Stream
            // classes throw exceptions upon error
            try
            {
                // Create a request for the specified remote file name
                WebRequest request = WebRequest.Create(DownloadLink);
                if (request != null)
                {
                    // Send the request to the server and retrieve the
                    // WebResponse object 

                    // Get the Full size of the File
                    double TotalBytesToReceive = 0;
                    var SizewebRequest = HttpWebRequest.Create(new Uri(DownloadLink));
                    SizewebRequest.Method = "HEAD";

                    using (var webResponse = SizewebRequest.GetResponse())
                    {
                        var fileSize = webResponse.Headers.Get("Content-Length");
                        TotalBytesToReceive = Convert.ToDouble(fileSize);
                    }

                    response = request.GetResponse();
                    if (response != null)
                    {
                        // Once the WebResponse object has been retrieved,
                        // get the stream object associated with the response's data
                        remoteStream = response.GetResponseStream();

                        // Create the local file

                        string filePath = TargetPath;


                        localStream = File.Create(filePath);

                        // Allocate a 1k buffer
                        byte[] buffer = new byte[1024];
                        int bytesRead = 0;

                        // Simple do/while loop to read from stream until
                        // no bytes are returned
                        do
                        {

                            // Read data (up to 1k) from the stream
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

                            // Write the data to the local file
                            localStream.Write(buffer, 0, bytesRead);

                            // Increment total bytes processed
                            bytesProcessed += bytesRead;


                            double bytesIn = double.Parse(bytesProcessed.ToString());
                            double percentage = bytesIn / TotalBytesToReceive * 100;
                            percentage = Math.Round(percentage, 0);


                            // Safe Update
                            //Increment the progress bar
                            if (progress.InvokeRequired)
                            {
                                progress.Invoke(new Action(() => progress.Value = int.Parse(Math.Truncate(percentage).ToString())));
                            }
                            else
                            {
                                progress.Value = int.Parse(Math.Truncate(percentage).ToString());
                            }

                            //Set the label progress Text
                            if (label1.InvokeRequired)
                            {
                                label1.Invoke(new Action(() => label1.Text = int.Parse(Math.Truncate(percentage).ToString()).ToString()));
                            }
                            else
                            {
                                label1.Text = int.Parse(Math.Truncate(percentage).ToString()).ToString() + "%";
                            }



                        } while (bytesRead > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                // Close the response and streams objects here 
                // to make sure they're closed even if an exception
                // is thrown at some point
                if (response != null) response.Close();
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
            }
        }

        #endregion

       
    }
    
}
