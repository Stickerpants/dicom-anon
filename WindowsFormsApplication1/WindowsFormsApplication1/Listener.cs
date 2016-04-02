using Dicom.Network;
using Dicom.Log;

namespace WindowsFormsApplication1
{
    class Listener
    {
        DicomServer<DicomCStoreProvider> server;
        int port;

        public Listener(int port = 5000)
        {
            port = 5000;

            //use the designated DICOM port as the default
            server = new DicomServer<DicomCStoreProvider>(port, null, null, ConsoleLogger.Instance);

        }

        public void stopListening()
        {
            server.Stop();
        }
        
    }
}
