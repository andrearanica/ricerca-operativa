using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RicercaOperativa {
    public partial class ShowMethod : Form {
        public string message = "";
        public ShowMethod () {
            InitializeComponent();
        }

        public void add (String message) {
            listBox1.Items.Add("Nuovo costo: " + message);
        }

        private void ShowMethod_Load(object sender, EventArgs e) {
            // listBox1.Items.Add("Nuovo costo: " + message);
        }
    }
}
