using System;
using Dicom.Log;
using Dicom.Network;
using Dicom;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public class DicomCStoreProvider : DicomService, IDicomServiceProvider, IDicomCStoreProvider, IDicomCEchoProvider
    {
        private static DicomTransferSyntax[] AcceptedTransferSyntaxes = new DicomTransferSyntax[] {
                DicomTransferSyntax.ExplicitVRLittleEndian,
                DicomTransferSyntax.ExplicitVRBigEndian,
                DicomTransferSyntax.ImplicitVRLittleEndian
            };

        private static DicomTransferSyntax[] AcceptedImageTransferSyntaxes = new DicomTransferSyntax[] {
				// Lossless
				DicomTransferSyntax.JPEGLSLossless,
                DicomTransferSyntax.JPEG2000Lossless,
                DicomTransferSyntax.JPEGProcess14SV1,
                DicomTransferSyntax.JPEGProcess14,
                DicomTransferSyntax.RLELossless,
			
				// Lossy
				DicomTransferSyntax.JPEGLSNearLossless,
                DicomTransferSyntax.JPEG2000Lossy,
                DicomTransferSyntax.JPEGProcess1,
                DicomTransferSyntax.JPEGProcess2_4,

				// Uncompressed
				DicomTransferSyntax.ExplicitVRLittleEndian,
                DicomTransferSyntax.ExplicitVRBigEndian,
                DicomTransferSyntax.ImplicitVRLittleEndian
            };

        public DicomCStoreProvider(Stream stream, Logger log)
            : base(stream, log)
        {
        }

        public DicomCStoreResponse OnCStoreRequest(DicomCStoreRequest request)
        {

            DicomFile file = request.File;

            //call anonymization method
            //update crosswalk (might be part of anonymization)
            //send file to host
            
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

            if (association.CalledAE != "STORESCP")
            {
                SendAssociationReject(DicomRejectResult.Permanent, DicomRejectSource.ServiceUser, DicomRejectReason.CalledAENotRecognized);
                return;
            }

            foreach (var pc in association.PresentationContexts)
            {
                if (pc.AbstractSyntax == DicomUID.Verification)
                    pc.AcceptTransferSyntaxes(AcceptedTransferSyntaxes);
                else if (pc.AbstractSyntax.StorageCategory != DicomStorageCategory.None)
                    pc.AcceptTransferSyntaxes(AcceptedImageTransferSyntaxes);
            }

            SendAssociationAccept(association);

        }

        public DicomCEchoResponse OnCEchoRequest(DicomCEchoRequest request)
        {
            return new DicomCEchoResponse(request, DicomStatus.Success);
        }
        
    }
}
