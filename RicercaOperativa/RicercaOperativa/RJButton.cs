using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Markup;

namespace RicercaOperativa {
    public partial class RJButton: Button {
        public RJButton () {
            // InitializeComponent();
            SetNormalValues();
        }

        private void SetNormalValues () {
            this.Font = new Font("Verdana", 8F, FontStyle.Bold);
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            this.Margin = new Padding(4, 1, 4, 1);
            this.Padding = new Padding(4);
            this.MinimumSize = new Size(150, 35);
            this.Cursor = Cursors.Arrow;
        }

        private void SetValuesOnFocus () {
            //Increase the font size and colors on focus
            this.Font = new Font("Verdana", 10F, FontStyle.Bold);

            this.BackColor = Color.Green;
            this.ForeColor = Color.White;

            //Set the cursor to Hand type
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint (PaintEventArgs pe) {
            base.OnPaint(pe);
        }

        protected override void OnMouseHover (EventArgs e) {
            base.OnMouseHover(e);
            SetValuesOnFocus();
        }

        protected override void OnMouseLeave (EventArgs e) {
            base.OnMouseLeave(e);
            SetNormalValues();
        }
    }
}
