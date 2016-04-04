using System;
using System.Windows.Forms;
using Dicom.Network;
using Dicom;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    class DicomSender
    {
        DicomClient client;
        String targetIP;
        int port;
        Boolean useTLS;
        String callingAE;
        String calledAE;

        public DicomSender(String targetIP, int port, String callingAE, String calledAE, Boolean useTLS = false)
        {
            this.targetIP = targetIP;
            this.port = port;
            this.useTLS = useTLS;
            this.callingAE = callingAE;
            this.calledAE = calledAE;

            client = new DicomClient();
        }

        public void sendDicom(DicomFile file)
        {
            
            //adds dicom file to be sent with new request
            client.AddRequest(new DicomCStoreRequest(file));

            //send file to destination specified 
            try{
                client.Send(targetIP, port, useTLS, callingAE, calledAE);
            }
            catch(SocketException e){
                MessageBox.Show("Error: " + e.Message);
            }
        }

    }
}
