using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gronsfield
{
    public partial class Form1 : Form
    {
        string ua, en;
        public Form1()
        {
            InitializeComponent();
            ua = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            en = "abcdefghijklmnopqrstuvwxyz";
            ModecomboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var abc = "";
            if (radioua.Checked)
            {
                abc = ua;
            }
            else
            {
                abc = en;
            }



            int key;
            var is_key = int.TryParse(KeytextBox.Text, out key);
            if (is_key && !MsgTextBox.Text.Trim().Equals(""))
            {
                bool encrypt = true;
                if (ModecomboBox.SelectedIndex == 1)
                {
                    encrypt = false;
                }
                MsgTextBox.Text = encryptdecrypt(abc,encrypt,KeytextBox.Text,MsgTextBox.Text);

            }
            else
            {
                MessageBox.Show("The key or message is not valid!", "Erorr");
            }
        }

        public static string encryptdecrypt(string alp, bool encrypt,string key,string msg)
        {
            string result = "";
            string text = Regex.Replace(msg, @"\s+", string.Empty);
            string abc = alp, newKey = key;

            //bool encode = false;

            int op = encrypt ? +1 : -1, offset, indexOf = 0;
            while (newKey.Length < text.Length)
            {
                newKey += key;
            }
            if (newKey.Length > text.Length)
            {
                newKey = newKey.Substring(0, newKey.Length - (newKey.Length - text.Length));
            }

            for (int i = 0; i < text.Length; i++)
            {
                indexOf = abc.IndexOf(text[i]);
                if (indexOf != -1)
                {
                    offset = abc.IndexOf(text[i]) + (Convert.ToInt32(newKey[i]) - 48) * op;
                    if (offset > abc.Length)
                        offset = offset - abc.Length;
                    else if (offset < 0)
                        offset = abc.Length + offset;
                    result += abc[offset];
                }
                else
                    result += text[i];
            }
            return result;
        
    } 
    }
}
