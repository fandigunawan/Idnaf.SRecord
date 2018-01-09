using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Idnaf.SRecord
{
    public partial class GotoAddress : Form
    {
        public uint iAddress;
        public GotoAddress()
        {
            InitializeComponent();
            iAddress = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text.Length != 4)
                    throw new Exception();
                UInt16 i = Convert.ToUInt16(maskedTextBox1.Text,16);
                iAddress = i;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid address offset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}