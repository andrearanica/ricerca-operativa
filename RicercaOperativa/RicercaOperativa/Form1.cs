using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace RicercaOperativa {
    public partial class Form1 : Form {
        // private int[,] matrix;
        int up, d;
        public Form1() {
            InitializeComponent();
        }
        private bool checkUP () {
            lbl_errorUP.Text = "";
            try {
                up = int.Parse(txt_up.Text);
                return true;
            } catch (Exception) {
                lbl_errorUP.Text = "Errore: dati non corretti";
                return false;
            }
        }
        private bool checkD () {
            lbl_errorD.Text = "";
            try {
                d = int.Parse(txt_d.Text);
                return true;
            } catch (Exception) {
                lbl_errorD.Text = "Errore: dati non corretti";
                return false;
            }
        }
        private bool checkInput () {
            if (checkUP() && checkD()) {
                return true;
            } else {
                return false;
            }
        }

        private void createTable (int d, int up) {
            table.Rows.Clear(); table.Columns.Clear();
            table.RowHeadersVisible = true;

            // Creo le righe e le colonne in base al numero di destinazioni e di up
            for (int i = 0; i <= d; i++) {
                table.Columns.Add("", "");
                table.Columns[i].HeaderText = "D" + (i);
            }
            table.Columns[0].HeaderText = "";
            for (int i = 0; i < up; i++) {
                table.Rows.Add("UP" + (i + 1).ToString(), "");
            }
        }

        private void txt_up_TextChanged(object sender, EventArgs e) {
            checkUP();
        }

        private void txt_d_TextChanged(object sender, EventArgs e) {
            checkD();
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Sistema che non può inserire lettere
        }

        private void btn_test_Click(object sender, EventArgs e) {
            Random r = new Random();
            try {
                if (checkUP() && checkD()) {
                    for (int i = 0; i < up; i++) {
                        for (int j = 1; j <= d; j++) {
                            table.Rows[i].Cells[j].Value = r.Next(0, 10);
                        }
                    }
                }
            } catch (System.ArgumentOutOfRangeException) {
                MessageBox.Show("Devi creare la tabella per riempirla", "Errore");
            }
        }

        private bool checkTable () {
            for (int i = 0; i < up; i++) {
                for (int j = 1; j <= d; j++) {
                    try {
                        if (table.Rows[i].Cells[j].Value.ToString() == "") {
                            return false;
                        }
                    } catch (Exception) { return false; }
                }
            }
            return true;
        }

        private void btn_nordOvest_Click(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_createTable_Click(object sender, EventArgs e) {
            if (checkInput()) {
                createTable(d, up);
            }
        }
    }
}
