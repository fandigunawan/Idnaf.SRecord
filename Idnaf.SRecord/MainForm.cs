using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Idnaf.SRecord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            textBoxPath.Enabled = false;
            buttonGetDir.Enabled = false;
            string strBuff = "";
            byte[] baBuffer = SrecParser.ParseSRec(textBoxPath.Text);
            StreamWriter sw = new StreamWriter("temp.tmp", false);
            //sw.Write("Address| 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F\r\n");
            //sw.Write("-------+------------------------------------------------");
            for (int i = 0; i < baBuffer.Length; i++)
            {
                if (i % 16 == 0)
                {
                    strBuff = "0x" + i.ToString("X4") + " | " + baBuffer[i].ToString("X2");
                    
                }
                else
                {
                    if ((i % 16) == 15)
                    {
                        strBuff = " " + baBuffer[i].ToString("X2") + "\r\n";
                    }
                    else
                    {

                        strBuff = " " + baBuffer[i].ToString("X2");
                    }
                    
                }
                sw.Write(strBuff);

            }
            sw.Flush();
            sw.Close();
            richTextBoxHex.LoadFile("temp.tmp",RichTextBoxStreamType.PlainText);
            File.Delete("temp.tmp");
            textBoxPath.Enabled = true;
            buttonGetDir.Enabled = true;
        }

        private void buttonGetDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "S Record (*.s19)|*.s19|All file (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxHex.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Memory dump (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxHex.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxHex.Clear();
        }

        private void gotoAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint iAddress;
            GotoAddress goaddr = new GotoAddress();
            goaddr.ShowDialog();
            iAddress = goaddr.iAddress;
            if (iAddress == 0)
                return;
            iAddress = iAddress - (iAddress % 16);
            string strSearchedText = "0x" + iAddress.ToString("X4");
            
            int iFoundPlace = richTextBoxHex.Find(strSearchedText,0,RichTextBoxFinds.None);

            richTextBoxHex.Focus();
            

        }
    }
}