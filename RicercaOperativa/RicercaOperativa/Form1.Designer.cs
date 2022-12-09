
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
            this.lbl_errorUP = new System.Windows.Forms.Label();
            this.lbl_errorD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createTable = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_nordOvest = new System.Windows.Forms.Button();
            this.txt_up = new System.Windows.Forms.NumericUpDown();
            this.txt_d = new System.Windows.Forms.NumericUpDown();
            this.btn_minimiCosti = new System.Windows.Forms.Button();
            this.list_showMethod = new System.Windows.Forms.ListBox();
            this.btn_allMethods = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
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
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ricerca operativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(88, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero di U.P.";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(88, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero di Destinazioni";
            // 
            // btn_createTable
            // 
            this.btn_createTable.BackColor = System.Drawing.Color.Maroon;
            this.btn_createTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_createTable.Location = new System.Drawing.Point(384, 129);
            this.btn_createTable.Name = "btn_createTable";
            this.btn_createTable.Size = new System.Drawing.Size(134, 68);
            this.btn_createTable.TabIndex = 7;
            this.btn_createTable.Text = "Crea \r\ntabella";
            this.btn_createTable.UseVisualStyleBackColor = false;
            this.btn_createTable.Click += new System.EventHandler(this.btn_createTable_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(88, 244);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 25;
            this.table.Size = new System.Drawing.Size(611, 412);
            this.table.StandardTab = true;
            this.table.TabIndex = 8;
            this.table.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_CellBeginEdit);
            this.table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellEndEdit);
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // btn_test
            // 
            this.btn_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_test.BackColor = System.Drawing.Color.Maroon;
            this.btn_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_test.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_test.Location = new System.Drawing.Point(589, 133);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(116, 60);
            this.btn_test.TabIndex = 9;
            this.btn_test.Text = "Riempi";
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_nordOvest
            // 
            this.btn_nordOvest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nordOvest.BackColor = System.Drawing.Color.Maroon;
            this.btn_nordOvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nordOvest.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_nordOvest.Location = new System.Drawing.Point(711, 132);
            this.btn_nordOvest.Name = "btn_nordOvest";
            this.btn_nordOvest.Size = new System.Drawing.Size(116, 61);
            this.btn_nordOvest.TabIndex = 10;
            this.btn_nordOvest.Text = "Nord-Ovest";
            this.btn_nordOvest.UseVisualStyleBackColor = false;
            this.btn_nordOvest.Click += new System.EventHandler(this.btn_nordOvest_Click);
            // 
            // txt_up
            // 
            this.txt_up.Location = new System.Drawing.Point(299, 133);
            this.txt_up.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(79, 29);
            this.txt_up.TabIndex = 12;
            this.txt_up.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(299, 165);
            this.txt_d.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(79, 29);
            this.txt_d.TabIndex = 13;
            this.txt_d.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_minimiCosti
            // 
            this.btn_minimiCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimiCosti.BackColor = System.Drawing.Color.Maroon;
            this.btn_minimiCosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_minimiCosti.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_minimiCosti.Location = new System.Drawing.Point(833, 133);
            this.btn_minimiCosti.Name = "btn_minimiCosti";
            this.btn_minimiCosti.Size = new System.Drawing.Size(116, 60);
            this.btn_minimiCosti.TabIndex = 14;
            this.btn_minimiCosti.Text = "Minimi costi";
            this.btn_minimiCosti.UseVisualStyleBackColor = false;
            this.btn_minimiCosti.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_showMethod
            // 
            this.list_showMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_showMethod.FormattingEnabled = true;
            this.list_showMethod.ItemHeight = 24;
            this.list_showMethod.Location = new System.Drawing.Point(711, 244);
            this.list_showMethod.Name = "list_showMethod";
            this.list_showMethod.Size = new System.Drawing.Size(360, 412);
            this.list_showMethod.TabIndex = 15;
            // 
            // btn_allMethods
            // 
            this.btn_allMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_allMethods.BackColor = System.Drawing.Color.Maroon;
            this.btn_allMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_allMethods.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_allMethods.Location = new System.Drawing.Point(955, 133);
            this.btn_allMethods.Name = "btn_allMethods";
            this.btn_allMethods.Size = new System.Drawing.Size(116, 60);
            this.btn_allMethods.TabIndex = 16;
            this.btn_allMethods.Text = "Tutti i metodi";
            this.btn_allMethods.UseVisualStyleBackColor = false;
            this.btn_allMethods.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1193, 705);
            this.Controls.Add(this.btn_allMethods);
            this.Controls.Add(this.list_showMethod);
            this.Controls.Add(this.btn_minimiCosti);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_up);
            this.Controls.Add(this.btn_nordOvest);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_createTable);
            this.Controls.Add(this.lbl_errorD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_errorUP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1209, 744);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🚀 Ricerca operativa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_errorUP;
        private System.Windows.Forms.Label lbl_errorD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createTable;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_nordOvest;
        private System.Windows.Forms.NumericUpDown txt_up;
        private System.Windows.Forms.NumericUpDown txt_d;
        private System.Windows.Forms.Button btn_minimiCosti;
        private System.Windows.Forms.ListBox list_showMethod;
        private System.Windows.Forms.Button btn_allMethods;
    }
}

