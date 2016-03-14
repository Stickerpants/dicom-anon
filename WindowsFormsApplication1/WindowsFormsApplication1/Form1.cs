using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dicom.Imaging;
using Dicom;
using System.IO;
using Dicom.IO.Buffer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string[] FileList;
        private int currentFile = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void appendToInfo(string text)
        {
            this.informationBox.Text += text;
        }

        private void directoryOpen_Click(object sender, EventArgs e)
        {
            FileList = Directory.GetFiles(this.directoryBox.Text);
            currentFile = 0;
            updateDisplay();
        }

        private void directoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                directoryOpen_Click(sender, e);
            }
        }

        private void goLeft_Click(object sender, EventArgs e)
        {
            moveImage(-1);
            updateDisplay();
        }

        private void goRight_Click(object sender, EventArgs e)
        {
            moveImage(1);
            updateDisplay();
        }

        private void moveImage(int stride)
        {
            if (FileList == null) { return; }

            currentFile = (currentFile + stride) % FileList.Length;
            if (currentFile < 0)
            {
                // Need to wrap on left
                currentFile = FileList.Length + currentFile;
            }
        }

        private void updateDisplay()
        {
            if (FileList == null) { return; }

            // Change displayed image
            var newFile = FileList[currentFile];
            var image = new DicomImage(newFile);
            this.imageDisplay.Image = image.RenderImage().AsBitmap();

            // Change filename display
            this.currentFileLabel.Text = Path.GetFileName(newFile);

            // Change metadata display
            var data = DicomFile.Open(newFile);
            this.informationBox.Clear();
            new DicomDatasetWalker(data.FileMetaInfo).Walk(new DumpWalker(this));
            new DicomDatasetWalker(data.Dataset).Walk(new DumpWalker(this));
        }

        /*var dataRep = data.Dataset
            .Select(x => String.Format("{0}: {1}\r\n", x.Tag.DictionaryEntry.Name, String.Join(@"\", ((DicomElement) x).Get<string[]>())))
            .Aggregate((seed, e) => seed + e); 
        this.informationBox.Text = dataRep;*/

        /*
            x.Tag.ToString() + ": " + x.ValueRepresentation.ToString() + */

        private class DumpWalker : IDicomDatasetWalker
        {
            int _level = 0;

            public DumpWalker(Form1 form)
            {
                Form = form;
                Level = 0;
            }

            public Form1 Form
            {
                get;
                set;
            }

            public int Level
            {
                get { return _level; }
                set
                {
                    _level = value;
                    Indent = String.Empty;
                    for (int i = 0; i < _level; i++)
                        Indent += "    ";
                }
            }

            private string Indent
            {
                get;
                set;
            }

            public void OnBeginWalk()
            {
            }

            public bool OnElement(DicomElement element)
            {
                var tag = String.Format("{0}{1}  {2}", Indent, element.Tag.ToString().ToUpper(), element.Tag.DictionaryEntry.Name);

                string value = "<large value not displayed>";
                if (element.Length <= 2048)
                    value = String.Join("\\", element.Get<string[]>());

                if (element.ValueRepresentation == DicomVR.UI && element.Count > 0)
                {
                    var uid = element.Get<DicomUID>(0);
                    var name = uid.Name;
                    if (name != "Unknown")
                        value = String.Format("{0} ({1})", value, name);
                }

                Form.appendToInfo(String.Join(
                    " ",
                    tag,
                    element.ValueRepresentation.Code,
                    element.Length.ToString(),
                    value) + "\r\n");
                return true;
            }

            public bool OnBeginSequence(DicomSequence sequence)
            {
                var tag = String.Format("{0}{1}  {2}", Indent, sequence.Tag.ToString().ToUpper(), sequence.Tag.DictionaryEntry.Name);

                Form.appendToInfo(String.Join(" ", tag, "SQ", String.Empty, String.Empty) + "\r\n");

                Level++;
                return true;
            }

            public bool OnBeginSequenceItem(DicomDataset dataset)
            {
                var tag = String.Format("{0}Sequence Item:", Indent);

                Form.appendToInfo(String.Join(" ", tag, String.Empty, String.Empty, String.Empty) + "\r\n");

                Level++;
                return true;
            }

            public bool OnEndSequenceItem()
            {
                Level--;
                return true;
            }

            public bool OnEndSequence()
            {
                Level--;
                return true;
            }

            public bool OnBeginFragment(DicomFragmentSequence fragment)
            {
                var tag = String.Format("{0}{1}  {2}", Indent, fragment.Tag.ToString().ToUpper(), fragment.Tag.DictionaryEntry.Name);

                Form.appendToInfo(String.Join(" ", tag, fragment.ValueRepresentation.Code, String.Empty, String.Empty) + "\r\n");

                Level++;
                return true;
            }

            public bool OnFragmentItem(IByteBuffer item)
            {
                var tag = String.Format("{0}Fragment", Indent);

                Form.appendToInfo(String.Join(" ", tag, String.Empty, item.Size.ToString(), String.Empty) + "\r\n");
                return true;
            }

            public bool OnEndFragment()
            {
                Level--;
                return true;
            }

            public void OnEndWalk()
            {
            }

            public Task<bool> OnFragmentItemAsync(IByteBuffer item)
            {
                return null;
            }

            public Task<bool> OnElementAsync(DicomElement element)
            {
                return null;
            }
        }
    }
}
