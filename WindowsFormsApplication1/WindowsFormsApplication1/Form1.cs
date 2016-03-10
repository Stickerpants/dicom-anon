using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            local_ip_text.Text = LocalIPAddress().ToString();
        }

        //finds your IP address
        public IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        //When local ae label is double clicked, label disappears, text box appears and lets you edit text
        private void local_ae_text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            local_ae_text.Visible = false;
            local_ae_textbox.Visible = true;
            local_ae_textbox.Text = local_ae_text.Text;
        }

        //When target ae text is double clicked, label disappears, text box appears and lets you edit text
        private void target_ae_text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            target_ae_text.Visible = false;
            target_ae_textbox.Visible = true;
            target_ae_textbox.Text = target_ae_text.Text;
        }
        
        //syncs local value from text box to label
        private void local_ae_textbox_TextChanged(object sender, EventArgs e)
        {
            local_ae_text.Text = local_ae_textbox.Text;
        }

        //syncs target value from text box to label
        private void target_ae_textbox_TextChanged(object sender, EventArgs e)
        {
            target_ae_text.Text = target_ae_textbox.Text;
        }
        
        //when Enter is pressed, local textbox disappears and label appears
        private void local_ae_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                local_ae_textbox.Visible = false;
                local_ae_text.Visible = true;
            }
        }

        //when Enter is pressed, target textbox disappears and label appears
        private void target_ae_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                target_ae_textbox.Visible = false;
                target_ae_text.Visible = true;
            }
        }

        //when textbox is not in focus, textbox disappears and text reappears
        private void local_ae_textbox_Leave(object sender, EventArgs e)
        {
            local_ae_textbox.Visible = false;
            local_ae_text.Visible = true;
        }

        //when textbox is not in focus, textbox disappears and text reappears
        private void target_ae_textbox_Leave(object sender, EventArgs e)
        {
            target_ae_textbox.Visible = false;
            target_ae_text.Visible = true;
        }

        //when target ip text is double clicked, text disappears and textbox appears and lets user edit
        private void target_ip_text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            target_ip_text.Visible = false;
            target_ip_textbox.Visible = true;
            target_ip_textbox.Text = target_ip_text.Text;
        }

        //syncs target value from text box to label
        private void target_ip_textbox_TextChanged(object sender, EventArgs e)
        {
            target_ip_text.Text = target_ip_textbox.Text;
        }

        //when Enter is pressed, target textbox disappears and label appears
        private void target_ip_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                target_ip_textbox.Visible = false;
                target_ip_text.Visible = true;
            }
        }

        //when textbox is not in focus, textbox disappears and text reappears
        private void target_ip_textbox_Leave(object sender, EventArgs e)
        {
            target_ip_textbox.Visible = false;
            target_ip_text.Visible = true;
        }
        //when user selects '[Custom]', combobox disappears and textbox appears letting the user change the value
        private void local_port_combobox_TextChanged(object sender, EventArgs e)
        {
            if(local_port_combobox.Text == "[Custom]")
            {
                local_port_textbox.Visible = true;
                local_port_combobox.Visible = false;
            }
        }
        //Syncs the value being changed from textbox to combobox
        private void local_port_textbox_TextChanged(object sender, EventArgs e)
        {
            local_port_combobox.Text = local_port_textbox.Text;
        }
        //when user hits Enter, textbox disappears and combobox reappears
        private void local_port_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                local_port_textbox.Visible = false;
                local_port_combobox.Visible = true;
            }
        }
        //when textbox is out of focus, textbox disappears and combobox reappears
        private void local_port_textbox_Leave(object sender, EventArgs e)
        {
            local_port_textbox.Visible = false;
            local_port_combobox.Visible = true;
        }
        //when user selects '[Custom]', combobox disappears and textbox appears letting the user change the value
        private void target_port_combobox_TextChanged(object sender, EventArgs e)
        {
            if (target_port_combobox.Text == "[Custom]")
            {
                target_port_textbox.Visible = true;
                target_port_combobox.Visible = false;
            }
        }
        //Syncs the value being changed from textbox to combobox
        private void target_port_textbox_TextChanged(object sender, EventArgs e)
        {
               target_port_combobox.Text = target_port_textbox.Text;
        }
        //when user hits Enter, textbox disappears and combobox reappears
        private void target_port_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                target_port_textbox.Visible = false;
                target_port_combobox.Visible = true;
            }
        }
        //when textbox is out of focus, textbox disappears and combobox reappears
        private void target_port_textbox_Leave(object sender, EventArgs e)
        {
              target_port_textbox.Visible = false;
              target_port_combobox.Visible = true;
        }
    }
}
