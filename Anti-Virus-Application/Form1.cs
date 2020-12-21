using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace Anti_Virus_Application {
    public partial class scanButton : System.Windows.Forms.Form {
        public scanButton() {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e) { }

        private string GetMD5FromFile(string filepath){
            using (var md5 = MD5.Create()) {
                using (var stream = File.OpenRead(filepath)) {
                    filePathTextbox.Text = filepath;
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-",String.Empty).ToLower();
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Textfiles | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                MD5Textbox.Text = GetMD5FromFile(ofd.FileName);
            }
        }

        private void scan_Click(object sender, EventArgs e) {
            var md5sig = File.ReadAllLines("Database.txt");
            if (md5sig.Contains(MD5Textbox.Text)) {
                Status.Text = "infected File";
                Status.ForeColor = Color.Red;
            } else {
                Status.Text = "Clear";
                Status.ForeColor = Color.Green;
            }
        }

    }
}
