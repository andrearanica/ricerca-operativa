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
using System.Threading;

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
            table.Columns.Add("Tot UP", "Tot UP");
            table.Rows.Add("Tot D", "");
            
            // Block row headers
            for (int i = 0; i < table.Rows.Count; i++) {
                table.Rows[i].Cells[0].ReadOnly = true;
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
            if (checkUP() && checkD() && table.Rows.Count > 0 && table.Columns.Count > 0) {
                for (int i = 0; i < up; i++) {
                    for (int j = 1; j <= d; j++) {
                        table.Rows[i].Cells[j].Value = r.Next(0, 10);
                    }
                }
            } else {
                MessageBox.Show("Devi creare una tabella per riempire i dati");
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

        private void nordOvest () {
            // int o = int.Parse(table.Rows[up].Cells[0].Value.ToString()) - int.Parse(table.Rows[0].Cells[d].Value.ToString());
            // MessageBox.Show(table.Rows[up].Cells[1].Value.ToString() + " - " + table.Rows[0].Cells[d + 1].Value.ToString());
            int cost = 0;
            // lbl_showCost.Text = "Risolvo con il metodo Nord Ovest\n";
            ShowMethod SM = new ShowMethod();
            SM.Show();
            while (table.Columns.Count > 2) {
                int upValue = int.Parse(table.Rows[0].Cells[table.Columns.Count - 1].Value.ToString());
                int dValue = int.Parse(table.Rows[table.Rows.Count - 1].Cells[1].Value.ToString());
                if (dValue > upValue) {
                    cost += int.Parse(table.Rows[0].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[table.Columns.Count - 1].Value.ToString());
                    table.Rows[table.Rows.Count - 1].Cells[1].Value = dValue - upValue;
                    table.Rows[0].Cells[table.Columns.Count - 1].Value = 0;
                    table.Rows.RemoveAt(0);
                } else if (dValue == upValue) {
                    cost += int.Parse(table.Rows[0].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[1].Value.ToString());
                    table.Rows.RemoveAt(0);
                    table.Columns.RemoveAt(1);
                } else {
                    cost += int.Parse(table.Rows[table.Rows.Count - 1].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[table.Columns.Count].Value.ToString());
                    table.Rows[0].Cells[table.Columns.Count - 1].Value = upValue - dValue;
                    table.Columns.RemoveAt(1);
                }
                SM.add(cost.ToString());
                MessageBox.Show("");
            }
        }

        private void btn_nordOvest_Click(object sender, EventArgs e) {
            if (table.Rows.Count > 0 && table.Columns.Count > 0) {
                nordOvest();
            } else {
                MessageBox.Show("Devi creare una tabella per utilizzare questo metodo");
            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btn_createTable_Click(object sender, EventArgs e) {
            if (checkInput() && int.Parse(txt_up.Text) >= 2 && int.Parse(txt_d.Text) >= 2) {
                createTable(d, up);
            } else {
                MessageBox.Show("Devi inserire almeno due unità produttive e due destinazioni");
            }
        }
    }
}
