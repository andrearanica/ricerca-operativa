
namespace RicercaOperativa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.lbl_errorUP = new System.Windows.Forms.Label();
            this.lbl_errorD = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createTable = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_nordOvest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3225, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(647, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ricerca operativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero di U.P.";
            // 
            // txt_up
            // 
            this.txt_up.Location = new System.Drawing.Point(221, 136);
            this.txt_up.Margin = new System.Windows.Forms.Padding(2);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(182, 29);
            this.txt_up.TabIndex = 2;
            this.txt_up.TextChanged += new System.EventHandler(this.txt_up_TextChanged);
            // 
            // lbl_errorUP
            // 
            this.lbl_errorUP.AutoSize = true;
            this.lbl_errorUP.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorUP.Location = new System.Drawing.Point(499, 138);
            this.lbl_errorUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorUP.Name = "lbl_errorUP";
            this.lbl_errorUP.Size = new System.Drawing.Size(0, 24);
            this.lbl_errorUP.TabIndex = 3;
            // 
            // lbl_errorD
            // 
            this.lbl_errorD.AutoSize = true;
            this.lbl_errorD.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorD.Location = new System.Drawing.Point(499, 177);
            this.lbl_errorD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorD.Name = "lbl_errorD";
            this.lbl_errorD.Size = new System.Drawing.Size(0, 24);
            this.lbl_errorD.TabIndex = 6;
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(221, 172);
            this.txt_d.Margin = new System.Windows.Forms.Padding(2);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(182, 29);
            this.txt_d.TabIndex = 5;
            this.txt_d.TextChanged += new System.EventHandler(this.txt_d_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero di Destinazioni";
            // 
            // btn_createTable
            // 
            this.btn_createTable.Location = new System.Drawing.Point(408, 136);
            this.btn_createTable.Name = "btn_createTable";
            this.btn_createTable.Size = new System.Drawing.Size(84, 65);
            this.btn_createTable.TabIndex = 7;
            this.btn_createTable.Text = "Invia";
            this.btn_createTable.UseVisualStyleBackColor = true;
            this.btn_createTable.Click += new System.EventHandler(this.btn_createTable_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(16, 231);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(1880, 635);
            this.table.TabIndex = 8;
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(857, 136);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(80, 65);
            this.btn_test.TabIndex = 9;
            this.btn_test.Text = "Riempi";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_nordOvest
            // 
            this.btn_nordOvest.Location = new System.Drawing.Point(943, 136);
            this.btn_nordOvest.Name = "btn_nordOvest";
            this.btn_nordOvest.Size = new System.Drawing.Size(116, 65);
            this.btn_nordOvest.TabIndex = 10;
            this.btn_nordOvest.Text = "Nord-Ovest";
            this.btn_nordOvest.UseVisualStyleBackColor = true;
            this.btn_nordOvest.Click += new System.EventHandler(this.btn_nordOvest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 878);
            this.Controls.Add(this.btn_nordOvest);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_createTable);
            this.Controls.Add(this.lbl_errorD);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_errorUP);
            this.Controls.Add(this.txt_up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🚀 Ricerca operativa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_up;
        private System.Windows.Forms.Label lbl_errorUP;
        private System.Windows.Forms.Label lbl_errorD;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createTable;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_nordOvest;
    }
}

