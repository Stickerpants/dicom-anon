using System;
using Dicom.Log;
using System.Text;
using Dicom.Network;
using Dicom;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class DicomCStoreProvider : DicomService, IDicomServiceProvider, IDicomCStoreProvider
    {
        public DicomCStoreProvider(INetworkStream stream, Encoding fallbackEncoding, Logger log)
            : base((System.IO.Stream)stream, fallbackEncoding, log)
        {
        }

        public DicomCStoreResponse OnCStoreRequest(DicomCStoreRequest request)
        {

            DicomFile file = request.File;

            //call anonymization method
            //update crosswalk (might be part of anonymization)
            //send file to host
            testing(file);

            DicomSender send = new DicomSender();
            send.sendDicom(file);
            MessageBox.Show("recieved dicom file: " + file.Dataset.Get<String>(DicomTag.DateTime));
            return new DicomCStoreResponse(request, DicomStatus.Success);

        }

        public void OnCStoreRequestException(string tempFileName, Exception e)
        {
            throw new NotImplementedException();
        }

        public void OnReceiveAbort(DicomAbortSource source, DicomAbortReason reason)
        {
        }

        public void OnConnectionClosed(Exception exception)
        {
        }

        public void OnReceiveAssociationReleaseRequest()
        {
            SendAssociationReleaseResponse();
        }

        public void OnReceiveAssociationRequest(DicomAssociation association)
        {

            MessageBox.Show("got here");
            foreach (var pc in association.PresentationContexts)
            {
                if (pc.AbstractSyntax == DicomUID.Verification) pc.SetResult(DicomPresentationContextResult.Accept);
                else pc.SetResult(DicomPresentationContextResult.RejectAbstractSyntaxNotSupported);
            }
            SendAssociationAccept(association);

        }

        //test method to confirm DICOM received
        public void testing(DicomFile file)
        {
            MessageBox.Show("file received getting date tag: /r/n"+file.Dataset.Get<String>(DicomTag.Date));
        }
    }
}
