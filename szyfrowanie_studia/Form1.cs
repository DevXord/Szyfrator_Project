using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace szyfrowanie_studia
{
    public partial class Form1 : Form
    {
        private string filePath = "c:\\";
        private const string FILTER_FILE = "Txt files (*.txt)|*.txt";
        private const int FILTER_INDEX = 1;
        Crypt crypt = new Crypt();
        SymmetricAlgorithm sa = new TripleDESCryptoServiceProvider();
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        #region Metody
        private void createCode(ref string result, byte[] encryptMsg)
        {
            foreach (var c in encryptMsg)
            {
                int randint = rd.Next(0, 6);
                char addChar = ((randint == 0) ? 'A' : (randint == 1) ? 'B' : (randint == 2) ? 'C' : (randint == 3) ? 'D' : (randint == 4) ? 'E' : (randint == 5) ? 'F' : 'F');
                result += Convert.ToString(c) + addChar;
            }
        }
        private void uncodeMessage(ref byte[] messageByte, string strCode)
        {
            int j = 0;
            string bytestring = "";
            for (int i = 0; i < strCode.Length; i++)
            {
                if (strCode[i] == 'A' || strCode[i] == 'B' || strCode[i] == 'C' || strCode[i] == 'D' || strCode[i] == 'E' || strCode[i] == 'F')
                {
                    messageByte[j] = Convert.ToByte(bytestring);
                    bytestring = "";
                    j++;
                    
                }
                else
                    bytestring += strCode[i];
            }
        }
        private void sendProgramMessage(char type, string message)
        {
            switch (type)
            {
                case 'C':
                case 'c':
                    results_lb.Text = "" + message;
                    break;
                case 'S':
                case 's':
                    results_lb.ForeColor = Color.DarkGreen;
                    results_lb.Text = "Success - " + message;
                    break;
            }
        }
        private int getLengthByString(ref string code)
        {
            string reults = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == 'F')
                {
                    code = code.Remove(0, i + 1);
                    break;
                }
                else
                    reults += code[i];
            }
            return Convert.ToInt32(reults);
        }
        private void configurateStream(ref SaveFileDialog obj1)
        {
            obj1.InitialDirectory = filePath;
            obj1.Filter = FILTER_FILE;
            obj1.FilterIndex = FILTER_INDEX;
            obj1.RestoreDirectory = true;
        }
        private void configurateStream(ref OpenFileDialog obj2)
        {
            obj2.InitialDirectory = filePath;
            obj2.Filter = FILTER_FILE;
            obj2.FilterIndex = FILTER_INDEX;
            obj2.RestoreDirectory = true;
        }
        private void resetValue()
        {
            enc_bt.Enabled = false;
            save_bt.Enabled = false;
            openFile_tb.Text = "";
            results_tb.Text = "";
            filePath = "c:\\";
            label1.Text = "File Open:";
            label2.Text = "Results:";
            clear_bt.Enabled = false;
            code1_rb.Enabled = true;
            code2_rb.Enabled = true;
            sendProgramMessage('c', "");
        }
        #endregion
        #region Obsługa zdarzeń Click / CheckedChanged
        private void open_bt_Click(object sender, EventArgs e)  
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var fileContent = string.Empty;
            configurateStream(ref ofd);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                resetValue();
                filePath = ofd.FileName;
                var fileStream = ofd.OpenFile();
                using (StreamReader rdr = new StreamReader(fileStream))
                {
                    fileContent = rdr.ReadToEnd();

                }
                label1.Text += " "+ofd.SafeFileName;
                openFile_tb.Text = fileContent;
                enc_bt.Enabled = true;
                clear_bt.Enabled = true;

                if (fileContent.StartsWith("1C") || fileContent.StartsWith("2C"))
                {
                    enc_bt.Text = "Decrypt";
                    code1_rb.Enabled = false;
                    code2_rb.Enabled = false;
                }
                else
                {
                    enc_bt.Text = "Encrypt";
                    code1_rb.Enabled = true;
                    code2_rb.Enabled = true;
                }
            }
        }
        private void save_bt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            configurateStream(ref sfd);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(results_tb.Text);
                    sw.Flush();
                    sw.Close();
                }
                resetValue();
                sendProgramMessage('s', "Saved");
            }
        }
        private void enc_bt_Click(object sender, EventArgs e)
        {
            var codeContent = openFile_tb.Text;
            var check1 = code1_rb.Checked;
            var check2 = code2_rb.Checked;
            string result = "";
            byte[] encryptMsg;

            //kontener, w którym będą zapisywane utworzone klucze RSA
            var csp = new CspParameters
            {
                KeyContainerName = "KontenerRSA",
                Flags = CspProviderFlags.UseArchivableKey | CspProviderFlags.NoPrompt | CspProviderFlags.UseMachineKeyStore
            };

            if (codeContent.StartsWith("1C"))
            {
                string csub = codeContent.Remove(0, 2);
                int sizeCode = getLengthByString(ref csub);
                encryptMsg = new byte[sizeCode];
                uncodeMessage(ref encryptMsg, csub);
                var msg2 = crypt.DecryptRSA(encryptMsg, csp);
                results_tb.Text = Convert.ToString(Encoding.UTF8.GetString(msg2));
                sendProgramMessage('s', "Decrypted");
                label2.Text += " RSA";


            }
            else if (codeContent.StartsWith("2C"))
            {
                string csub = codeContent.Remove(0, 2);
                int sizeCode = getLengthByString(ref csub);
                encryptMsg = new byte[sizeCode];
                uncodeMessage(ref encryptMsg, csub);
                var msg2 = crypt.Decrypt(sa, encryptMsg);
                results_tb.Text = msg2;
                sendProgramMessage('s', "Decrypted");
                label2.Text += " AES";
            }
            else
            {

                if (check1)
                {
                    encryptMsg = crypt.EncryptRSA(Encoding.UTF8.GetBytes(codeContent), csp);
                    result = "1C" + (encryptMsg.Length) + "F";
                    createCode(ref result, encryptMsg);
                    results_tb.Text = result;
                    sendProgramMessage('s', "Crypted");
                    label2.Text += " RSA";
                }
                if (check2)
                {
                    encryptMsg = crypt.Encrypt(sa, codeContent);
                    result = "2C" + (encryptMsg.Length) + "F";
                    createCode(ref result, encryptMsg);
                    results_tb.Text = result;
                    sendProgramMessage('s', "Crypted");
                    label2.Text += " AES";
                }

            }
            enc_bt.Enabled = false;
            save_bt.Enabled = true;
        }
        private void clear_bt_Click(object sender, EventArgs e)
        {
            resetValue();
        }
        private void code1_rb_CheckedChanged(object sender, EventArgs e)
        {
            resetValue();
        }
        private void code2_rb_CheckedChanged(object sender, EventArgs e)
        {
            resetValue(); 
        }
        #endregion
        
    }
}
