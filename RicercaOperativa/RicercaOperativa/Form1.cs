using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace RicercaOperativa {
    public partial class Form1 : Form {
        // private int[,] matrix;
        int up, d;
        string[,] matrix;

        public Form1() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private bool checkUP () {
            lbl_errorUP.Text = "";
            try {
                up = int.Parse(txt_up.Text);
                return true;
            } catch (Exception) {
                return false;
            }
        }
        private bool checkD () {
            lbl_errorD.Text = "";
            try {
                d = int.Parse(txt_d.Text);
                return true;
            } catch (Exception) {
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
            if (checkUP() && checkD() && table.Rows.Count > 2 && table.Columns.Count > 2) {
                for (int i = 0; i < up; i++) {
                    for (int j = 1; j <= d; j++) {
                        table.Rows[i].Cells[j].Value = r.Next(0, 10);
                    }
                }
                int n = 0;
                for (int i = 0; i < table.Rows.Count - 1; i++) {
                    int newN = r.Next(1, 10);
                    table.Rows[i].Cells[table.Columns.Count - 1].Value = newN;
                    n += newN;
                }
                table.Rows[table.Rows.Count - 1].Cells[table.Columns.Count - 1].Value = n;
                int total = int.Parse(table.Rows[table.Rows.Count - 1].Cells[table.Columns.Count - 1].Value.ToString()); int sum = 0;

                for (int i = 1; i < table.Columns.Count - 2; i++) {
                    table.Rows[table.Rows.Count - 1].Cells[i].Value = total / (table.Columns.Count - 2);
                    sum += int.Parse(table.Rows[table.Rows.Count - 1].Cells[i].Value.ToString());
                }

                table.Rows[table.Rows.Count - 1].Cells[table.Columns.Count - 2].Value = total - sum;
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

        private void setMatrix () {
            matrix = new string[table.Rows.Count, table.Columns.Count];
            foreach (DataGridViewRow row in table.Rows) {
                foreach (DataGridViewColumn col in table.Columns) {
                    matrix[row.Index, col.Index] = table.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }
        }

        private void restoreTable () {
            table.Rows.Clear(); table.Columns.Clear();
            // Add rows and columns
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i != 0 && i != matrix.GetLength(1))
                {
                    table.Columns.Add($"D{ i }", $"D{ i }");
                }
                else
                {
                    if (i == 0)
                    {
                        table.Columns.Add($"", $"");
                    }
                    else
                    {
                        table.Columns.Add($"Tot Up", $"Tot Up");
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++) table.Rows.Add();

            // Add values
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    table.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void nordOvest () {
            // int o = int.Parse(table.Rows[up].Cells[0].Value.ToString()) - int.Parse(table.Rows[0].Cells[d].Value.ToString());
            // MessageBox.Show(table.Rows[up].Cells[1].Value.ToString() + " - " + table.Rows[0].Cells[d + 1].Value.ToString());
            int cost = 0;
            // lbl_showCost.Text = "Risolvo con il metodo Nord Ovest\n";

            list_showMethod.Items.Add("INIZIO NORD-OVEST");
            list_showMethod.Items.Add("--------------------------------------------------");
            while (table.Columns.Count > 2) {
                int upValue = int.Parse(table.Rows[0].Cells[table.Columns.Count - 1].Value.ToString());
                int dValue = int.Parse(table.Rows[table.Rows.Count - 1].Cells[1].Value.ToString());

                if (dValue > upValue) {
                    cost += upValue * int.Parse(table.Rows[0].Cells[1].Value.ToString());
                    table.Rows[table.Rows.Count - 1].Cells[1].Value = dValue - upValue;
                    table.Rows[0].Cells[table.Columns.Count - 1].Value = 0;
                    list_showMethod.Items.Add($"{ table.Rows[0].Cells[0].Value } --> { table.Columns[1].HeaderText } | { upValue } unità  * { int.Parse(table.Rows[0].Cells[1].Value.ToString()) } = { upValue * int.Parse(table.Rows[0].Cells[1].Value.ToString()) }");
                    table.Rows.RemoveAt(0);
                } else if (dValue == upValue) {
                    // cost += int.Parse(table.Rows[0].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[1].Value.ToString());
                    cost += dValue * int.Parse( table.Rows[0].Cells[1].Value.ToString());
                    list_showMethod.Items.Add($"{ table.Rows[0].Cells[0].Value } --> { table.Columns[1].HeaderText } | { dValue } unità * { int.Parse(table.Rows[0].Cells[1].Value.ToString()) } = { dValue * int.Parse(table.Rows[0].Cells[1].Value.ToString()) }");
                    table.Rows.RemoveAt(0);
                    table.Columns.RemoveAt(1);
                } else {
                    cost += dValue * int.Parse(table.Rows[0].Cells[1].Value.ToString());
                    // cost += int.Parse(table.Rows[table.Rows.Count - 1].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[table.Columns.Count].Value.ToString());
                    list_showMethod.Items.Add($"{ table.Rows[0].Cells[0].Value } --> { table.Columns[1].HeaderText } | { dValue } unità * { int.Parse(table.Rows[0].Cells[1].Value.ToString()) } = { dValue * int.Parse(table.Rows[0].Cells[1].Value.ToString()) }");
                    table.Rows[0].Cells[table.Columns.Count - 1].Value = upValue - dValue;
                    table.Columns.RemoveAt(1);
                }
                var v = Task.Delay(1000);
                v.Wait();
            }
            list_showMethod.Items.Add($"Costo finale Nord-Ovest: { cost }");
            list_showMethod.Items.Add("--------------------------------------------------");
            restoreTable();
        }

        private bool checkTotals () {
            for (int i = 0; i < table.Rows.Count; i++) {
                for (int j = 0; j < table.Columns.Count; j++) {
                    if (table.Rows[i].Cells[j].Value == null) {
                        return false;
                    }
                }
            }
            int total = int.Parse(table.Rows[table.Rows.Count - 1].Cells[table.Columns.Count - 1].Value.ToString());
            int n = 0;
            for (int i = 1; i < table.Columns.Count - 1; i++) {
                n += int.Parse(table.Rows[table.Rows.Count - 1].Cells[i].Value.ToString());
            }
            if (n != total) return false;

            n = 0;
            for (int i = 0; i < table.Rows.Count - 1; i++) {
                n += int.Parse(table.Rows[i].Cells[table.Columns.Count - 1].Value.ToString());
            }
            if (n != total) return false;
            return true;
        }

        private void btn_nordOvest_Click(object sender, EventArgs e) {
            list_showMethod.Items.Clear();
            if (table.Rows.Count > 2 && table.Columns.Count > 2 && checkTotals()) {
                setMatrix();
                Thread t = new Thread(new ThreadStart(nordOvest));
                t.Start();
            } else {
                MessageBox.Show("Dati errati: controlla che i dati siano inseriti e che i totali corrispondano");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }

        private void minimiCosti () {
            int cost = 0, upValue = 0, dValue = 0;
            list_showMethod.Items.Add("INIZIO MINIMI COSTI");
            list_showMethod.Items.Add("--------------------------------------------------");
            int min = 1000, x = 0, y = 0;
            while (table.Columns.Count > 2) {
                min = 1000;
                for (int i = 0; i < table.Rows.Count - 1; i++) {
                    for (int j = 1; j < table.Columns.Count - 1; j++) {
                        if (int.Parse(table.Rows[i].Cells[j].Value.ToString()) < min) {
                            min = int.Parse(table.Rows[i].Cells[j].Value.ToString());
                            x = j;
                            y = i;
                            dValue = int.Parse(table[x, table.Rows.Count - 1].Value.ToString());
                            upValue = int.Parse(table[table.Columns.Count - 1, y].Value.ToString());
                        } else if (int.Parse(table.Rows[i].Cells[j].Value.ToString()) == min) {
                            if (int.Parse(table.Rows[table.Rows.Count - 1].Cells[j].Value.ToString()) > int.Parse(table.Rows[table.Rows.Count - 1].Cells[x].Value.ToString())) {
                                min = int.Parse(table.Rows[i].Cells[j].Value.ToString());
                                x = j;
                                y = i;
                                dValue = int.Parse(table[x, table.Rows.Count - 1].Value.ToString());
                                upValue = int.Parse(table[table.Columns.Count - 1, y].Value.ToString());
                            }
                        }
                    }
                }
                /*int upValue = int.Parse(table.Rows[y].Cells[table.Columns.Count - 1].Value.ToString());
                int dValue = int.Parse(table.Rows[table.Rows.Count - 1].Cells[x].Value.ToString());*/
                if (dValue > upValue) {
                    cost += upValue * int.Parse(table.Rows[y].Cells[x].Value.ToString());
                    table.Rows[table.Rows.Count - 1].Cells[x].Value = dValue - upValue;
                    table.Rows[y].Cells[table.Columns.Count - 1].Value = 0;
                    list_showMethod.Items.Add($"{ table.Rows[y].Cells[0].Value } --> { table.Columns[x].HeaderText } | {upValue} unità * {int.Parse(table.Rows[y].Cells[x].Value.ToString())} = { upValue * int.Parse(table.Rows[y].Cells[x].Value.ToString()) }");
                    table.Rows.RemoveAt(y);
                } else if (dValue == upValue) {
                    // cost += int.Parse(table.Rows[0].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[1].Value.ToString());
                    cost += dValue * int.Parse(table.Rows[y].Cells[x].Value.ToString());
                    list_showMethod.Items.Add($"{ table.Rows[y].Cells[0].Value } --> { table.Columns[x].HeaderText } | {dValue} unità * {int.Parse(table.Rows[y].Cells[x].Value.ToString())} = { dValue * int.Parse(table.Rows[y].Cells[x].Value.ToString()) }");
                    table.Rows.RemoveAt(y);
                    table.Columns.RemoveAt(x);
                } else {
                    cost += dValue * int.Parse(table.Rows[y].Cells[x].Value.ToString());
                    // cost += int.Parse(table.Rows[table.Rows.Count - 1].Cells[1].Value.ToString()) * int.Parse(table.Rows[0].Cells[table.Columns.Count].Value.ToString());
                    list_showMethod.Items.Add($"{ table.Rows[y].Cells[0].Value } --> { table.Columns[x].HeaderText } | {dValue} unità * {int.Parse(table.Rows[y].Cells[x].Value.ToString())} = { dValue * int.Parse(table.Rows[y].Cells[x].Value.ToString()) }");
                    table.Rows[y].Cells[table.Columns.Count - 1].Value = upValue - dValue;
                    table.Columns.RemoveAt(x);
                }
                var v = Task.Delay(1000);
                v.Wait();
            }
            list_showMethod.Items.Add($"Costo finale Minimi costi: { cost }");
            list_showMethod.Items.Add("--------------------------------------------------");
            restoreTable();
        }

        private void button1_Click(object sender, EventArgs e) {
            list_showMethod.Items.Clear();
            if (table.Rows.Count > 2 && table.Columns.Count > 2 && checkTotals()) {
                setMatrix();
                Thread t = new Thread(new ThreadStart(minimiCosti));
                t.Start();
            } else {
                MessageBox.Show("Dati errati: controlla che i dati siano inseriti e che i totali corrispondano");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            list_showMethod.Items.Clear();
            if (table.Rows.Count > 2 && table.Columns.Count > 2 && checkTotals()) {
                setMatrix();
                nordOvest();
                restoreTable();
                var v = Task.Delay(1000);
                v.Wait();
                minimiCosti();
                restoreTable();
            }
            else {
                MessageBox.Show("Dati errati: controlla che i dati siano inseriti e che i totali corrispondano");
            }
        }

        private void table_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            
        }

        private void table_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            DataGridViewTextBoxCell cell = table[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
            foreach (char c in cell.Value.ToString()) {
                if (!char.IsDigit(c)) {
                    cell.Value = "0";
                }
            }
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
