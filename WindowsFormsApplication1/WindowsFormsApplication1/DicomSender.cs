using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dicom.Network;
using Dicom;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    class DicomSender
    {
        DicomClient client;

        public DicomSender()
        {
            client = new DicomClient();
        }

        public void sendDicom(DicomFile file, String targetIP="10.7.201.228", int port = 5000, Boolean useTLS = false, String CallingAE = "Tony", String CalledAE = "AE_TITLE")
        {

            //adds dicom file to be sent with new request
            client.AddRequest(new DicomCStoreRequest(file));

            //send file to destination specified 
            try 
                {
                client.Send(targetIP, port, useTLS, CallingAE, CalledAE);
            }
            catch(SocketException e){
                MessageBox.Show("Error thing: " + e.Message);
            }
        }

    }
}
