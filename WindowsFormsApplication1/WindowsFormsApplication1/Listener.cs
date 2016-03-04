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
        DicomServer<DicomCEchoProvider> listener;
        DicomClient client;
        DicomAssociation assoc;
        DicomCMoveResponse cMove;
        

        public Listener()
        {
            //use the designated DICOM port as the default
            listener = new DicomServer<DicomCEchoProvider>(104);
            assoc = new DicomAssociation();

        }

    }
}
