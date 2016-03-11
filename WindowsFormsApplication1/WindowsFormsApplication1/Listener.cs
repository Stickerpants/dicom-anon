using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dicom.Network;

namespace WindowsFormsApplication1
{
    class Listener
    {
        DicomServer<DicomCStoreProvider> listener;
        int port;

        public Listener(int port = 5000)
        {
            port = 5000;

            //use the designated DICOM port as the default
            listener = new DicomServer<DicomCStoreProvider>(port);

        }

        public void stopListening()
        {
            listener.Stop();
        }

        public void startListening()
        {
            listener = new DicomServer<DicomCStoreProvider>(port);
        }
        
        //getter & setter for the port to make it configurable
        public int Port { get; set;}

    }
}
