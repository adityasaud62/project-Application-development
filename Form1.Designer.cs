namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AGbox = new System.Windows.Forms.GroupBox();
            this.updatebutt = new System.Windows.Forms.Button();
            this.aaweek = new System.Windows.Forms.TextBox();
            this.addbutt = new System.Windows.Forms.Button();
            this.Cweek = new System.Windows.Forms.TextBox();
            this.cweekend = new System.Windows.Forms.TextBox();
            this.clearbutt = new System.Windows.Forms.Button();
            this.aweek = new System.Windows.Forms.TextBox();
            this.aweekend = new System.Windows.Forms.TextBox();
            this.aaweekend = new System.Windows.Forms.TextBox();
            this.weekdayslabel = new System.Windows.Forms.Label();
            this.weekendlabel = new System.Windows.Forms.Label();
            this.agedlabel = new System.Windows.Forms.Label();
            this.adultlabel = new System.Windows.Forms.Label();
            this.childlabel = new System.Windows.Forms.Label();
            this.grouplabel = new System.Windows.Forms.Label();
            this.durationlabel = new System.Windows.Forms.Label();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.detailsview = new System.Windows.Forms.DataGridView();
            this.durbox = new System.Windows.Forms.ComboBox();
            this.delbutt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AGbox.SuspendLayout();
            this.detailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(972, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Visitor Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(529, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Price Rate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AGbox
            // 
            this.AGbox.Controls.Add(this.updatebutt);
            this.AGbox.Controls.Add(this.aaweek);
            this.AGbox.Controls.Add(this.addbutt);
            this.AGbox.Controls.Add(this.Cweek);
            this.AGbox.Controls.Add(this.cweekend);
            this.AGbox.Controls.Add(this.clearbutt);
            this.AGbox.Controls.Add(this.aweek);
            this.AGbox.Controls.Add(this.aweekend);
            this.AGbox.Controls.Add(this.aaweekend);
            this.AGbox.Controls.Add(this.weekdayslabel);
            this.AGbox.Controls.Add(this.weekendlabel);
            this.AGbox.Controls.Add(this.agedlabel);
            this.AGbox.Controls.Add(this.adultlabel);
            this.AGbox.Controls.Add(this.childlabel);
            this.AGbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGbox.ForeColor = System.Drawing.Color.GhostWhite;
            this.AGbox.Location = new System.Drawing.Point(363, 106);
            this.AGbox.Margin = new System.Windows.Forms.Padding(4);
            this.AGbox.Name = "AGbox";
            this.AGbox.Padding = new System.Windows.Forms.Padding(4);
            this.AGbox.Size = new System.Drawing.Size(817, 208);
            this.AGbox.TabIndex = 20;
            this.AGbox.TabStop = false;
            // 
            // updatebutt
            // 
            this.updatebutt.BackColor = System.Drawing.Color.LightGray;
            this.updatebutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutt.ForeColor = System.Drawing.Color.Black;
            this.updatebutt.Location = new System.Drawing.Point(609, 82);
            this.updatebutt.Margin = new System.Windows.Forms.Padding(4);
            this.updatebutt.Name = "updatebutt";
            this.updatebutt.Size = new System.Drawing.Size(181, 54);
            this.updatebutt.TabIndex = 26;
            this.updatebutt.Text = "Update";
            this.updatebutt.UseVisualStyleBackColor = false;
            this.updatebutt.Click += new System.EventHandler(this.updatebutt_Click_1);
            // 
            // aaweek
            // 
            this.aaweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaweek.Location = new System.Drawing.Point(141, 144);
            this.aaweek.Margin = new System.Windows.Forms.Padding(4);
            this.aaweek.Multiline = true;
            this.aaweek.Name = "aaweek";
            this.aaweek.Size = new System.Drawing.Size(172, 40);
            this.aaweek.TabIndex = 25;
            this.aaweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbutt
            // 
            this.addbutt.BackColor = System.Drawing.Color.LightGray;
            this.addbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutt.ForeColor = System.Drawing.Color.Black;
            this.addbutt.Location = new System.Drawing.Point(609, 27);
            this.addbutt.Margin = new System.Windows.Forms.Padding(4);
            this.addbutt.Name = "addbutt";
            this.addbutt.Size = new System.Drawing.Size(181, 54);
            this.addbutt.TabIndex = 17;
            this.addbutt.Text = "Add Visitor";
            this.addbutt.UseVisualStyleBackColor = false;
            this.addbutt.Click += new System.EventHandler(this.addbutt_Click_1);
            // 
            // Cweek
            // 
            this.Cweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cweek.Location = new System.Drawing.Point(141, 48);
            this.Cweek.Margin = new System.Windows.Forms.Padding(4);
            this.Cweek.Multiline = true;
            this.Cweek.Name = "Cweek";
            this.Cweek.Size = new System.Drawing.Size(172, 40);
            this.Cweek.TabIndex = 23;
            this.Cweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cweek.TextChanged += new System.EventHandler(this.Cweek_TextChanged);
            // 
            // cweekend
            // 
            this.cweekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cweekend.Location = new System.Drawing.Point(359, 49);
            this.cweekend.Margin = new System.Windows.Forms.Padding(4);
            this.cweekend.Multiline = true;
            this.cweekend.Name = "cweekend";
            this.cweekend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cweekend.Size = new System.Drawing.Size(172, 40);
            this.cweekend.TabIndex = 24;
            this.cweekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearbutt
            // 
            this.clearbutt.BackColor = System.Drawing.Color.LightGray;
            this.clearbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutt.ForeColor = System.Drawing.Color.Black;
            this.clearbutt.Location = new System.Drawing.Point(609, 139);
            this.clearbutt.Margin = new System.Windows.Forms.Padding(4);
            this.clearbutt.Name = "clearbutt";
            this.clearbutt.Size = new System.Drawing.Size(181, 54);
            this.clearbutt.TabIndex = 0;
            this.clearbutt.Text = "Clear All";
            this.clearbutt.UseVisualStyleBackColor = false;
            this.clearbutt.Click += new System.EventHandler(this.clearbutt_Click_1);
            // 
            // aweek
            // 
            this.aweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aweek.Location = new System.Drawing.Point(141, 96);
            this.aweek.Margin = new System.Windows.Forms.Padding(4);
            this.aweek.Multiline = true;
            this.aweek.Name = "aweek";
            this.aweek.Size = new System.Drawing.Size(172, 40);
            this.aweek.TabIndex = 22;
            this.aweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aweekend
            // 
            this.aweekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aweekend.Location = new System.Drawing.Point(359, 145);
            this.aweekend.Margin = new System.Windows.Forms.Padding(4);
            this.aweekend.Multiline = true;
            this.aweekend.Name = "aweekend";
            this.aweekend.Size = new System.Drawing.Size(172, 40);
            this.aweekend.TabIndex = 21;
            this.aweekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aaweekend
            // 
            this.aaweekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaweekend.Location = new System.Drawing.Point(359, 97);
            this.aaweekend.Margin = new System.Windows.Forms.Padding(4);
            this.aaweekend.Multiline = true;
            this.aaweekend.Name = "aaweekend";
            this.aaweekend.Size = new System.Drawing.Size(172, 40);
            this.aaweekend.TabIndex = 19;
            this.aaweekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weekdayslabel
            // 
            this.weekdayslabel.AutoSize = true;
            this.weekdayslabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekdayslabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weekdayslabel.Location = new System.Drawing.Point(125, 0);
            this.weekdayslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weekdayslabel.Name = "weekdayslabel";
            this.weekdayslabel.Size = new System.Drawing.Size(202, 34);
            this.weekdayslabel.TabIndex = 18;
            this.weekdayslabel.Text = "Normal Days";
            // 
            // weekendlabel
            // 
            this.weekendlabel.AutoSize = true;
            this.weekendlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weekendlabel.Location = new System.Drawing.Point(384, 0);
            this.weekendlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weekendlabel.Name = "weekendlabel";
            this.weekendlabel.Size = new System.Drawing.Size(125, 34);
            this.weekendlabel.TabIndex = 17;
            this.weekendlabel.Text = "Holiday";
            // 
            // agedlabel
            // 
            this.agedlabel.AutoSize = true;
            this.agedlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agedlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.agedlabel.Location = new System.Drawing.Point(9, 145);
            this.agedlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agedlabel.Name = "agedlabel";
            this.agedlabel.Size = new System.Drawing.Size(93, 34);
            this.agedlabel.TabIndex = 14;
            this.agedlabel.Text = "Aged";
            // 
            // adultlabel
            // 
            this.adultlabel.AutoSize = true;
            this.adultlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adultlabel.Location = new System.Drawing.Point(9, 100);
            this.adultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adultlabel.Name = "adultlabel";
            this.adultlabel.Size = new System.Drawing.Size(93, 34);
            this.adultlabel.TabIndex = 13;
            this.adultlabel.Text = "Adult\r\n";
            // 
            // childlabel
            // 
            this.childlabel.AutoSize = true;
            this.childlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.childlabel.Location = new System.Drawing.Point(9, 54);
            this.childlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.childlabel.Name = "childlabel";
            this.childlabel.Size = new System.Drawing.Size(90, 34);
            this.childlabel.TabIndex = 12;
            this.childlabel.Text = "Child";
            this.childlabel.Click += new System.EventHandler(this.childlabel_Click);
            // 
            // grouplabel
            // 
            this.grouplabel.AutoSize = true;
            this.grouplabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplabel.ForeColor = System.Drawing.SystemColors.Window;
            this.grouplabel.Location = new System.Drawing.Point(167, 133);
            this.grouplabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grouplabel.Name = "grouplabel";
            this.grouplabel.Size = new System.Drawing.Size(107, 34);
            this.grouplabel.TabIndex = 1;
            this.grouplabel.Text = "Group";
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.durationlabel.Location = new System.Drawing.Point(147, 228);
            this.durationlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(141, 34);
            this.durationlabel.TabIndex = 2;
            this.durationlabel.Text = "Duration";
            // 
            // detailsGB
            // 
            this.detailsGB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.detailsGB.Controls.Add(this.detailsview);
            this.detailsGB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGB.ForeColor = System.Drawing.Color.White;
            this.detailsGB.Location = new System.Drawing.Point(37, 321);
            this.detailsGB.Margin = new System.Windows.Forms.Padding(4);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Padding = new System.Windows.Forms.Padding(4);
            this.detailsGB.Size = new System.Drawing.Size(1143, 260);
            this.detailsGB.TabIndex = 25;
            this.detailsGB.TabStop = false;
            this.detailsGB.Text = "Details";
            this.detailsGB.Enter += new System.EventHandler(this.detailsGB_Enter);
            // 
            // detailsview
            // 
            this.detailsview.BackgroundColor = System.Drawing.Color.Lavender;
            this.detailsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsview.Location = new System.Drawing.Point(15, 30);
            this.detailsview.Margin = new System.Windows.Forms.Padding(4);
            this.detailsview.Name = "detailsview";
            this.detailsview.RowHeadersWidth = 51;
            this.detailsview.Size = new System.Drawing.Size(1123, 223);
            this.detailsview.TabIndex = 19;
            // 
            // durbox
            // 
            this.durbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.durbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durbox.FormattingEnabled = true;
            this.durbox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5+ Hours"});
            this.durbox.Location = new System.Drawing.Point(108, 266);
            this.durbox.Margin = new System.Windows.Forms.Padding(4);
            this.durbox.Name = "durbox";
            this.durbox.Size = new System.Drawing.Size(224, 33);
            this.durbox.TabIndex = 4;
            // 
            // delbutt
            // 
            this.delbutt.BackColor = System.Drawing.Color.Lavender;
            this.delbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutt.ForeColor = System.Drawing.Color.Black;
            this.delbutt.Location = new System.Drawing.Point(185, 588);
            this.delbutt.Margin = new System.Windows.Forms.Padding(4);
            this.delbutt.Name = "delbutt";
            this.delbutt.Size = new System.Drawing.Size(121, 39);
            this.delbutt.TabIndex = 22;
            this.delbutt.Text = "Delete Single ";
            this.delbutt.UseVisualStyleBackColor = false;
            this.delbutt.Click += new System.EventHandler(this.delbutt_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Reset All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupbox
            // 
            this.groupbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.FormattingEnabled = true;
            this.groupbox.Items.AddRange(new object[] {
            "Only One",
            "2-5 ",
            "6-10 ",
            "10+ "});
            this.groupbox.Location = new System.Drawing.Point(108, 171);
            this.groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(224, 33);
            this.groupbox.TabIndex = 3;
            this.groupbox.SelectedIndexChanged += new System.EventHandler(this.groupbox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AGbox);
            this.panel1.Controls.Add(this.detailsGB);
            this.panel1.Controls.Add(this.delbutt);
            this.panel1.Controls.Add(this.durbox);
            this.panel1.Controls.Add(this.grouplabel);
            this.panel1.Controls.Add(this.durationlabel);
            this.panel1.Controls.Add(this.groupbox);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 663);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 673);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AGbox.ResumeLayout(false);
            this.AGbox.PerformLayout();
            this.detailsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AGbox;
        private System.Windows.Forms.Button updatebutt;
        private System.Windows.Forms.TextBox aaweek;
        private System.Windows.Forms.Button addbutt;
        private System.Windows.Forms.TextBox Cweek;
        private System.Windows.Forms.TextBox cweekend;
        private System.Windows.Forms.Button clearbutt;
        private System.Windows.Forms.TextBox aweek;
        private System.Windows.Forms.TextBox aweekend;
        private System.Windows.Forms.TextBox aaweekend;
        private System.Windows.Forms.Label weekdayslabel;
        private System.Windows.Forms.Label weekendlabel;
        private System.Windows.Forms.Label agedlabel;
        private System.Windows.Forms.Label adultlabel;
        private System.Windows.Forms.Label childlabel;
        private System.Windows.Forms.Label grouplabel;
        private System.Windows.Forms.Label durationlabel;
        private System.Windows.Forms.GroupBox detailsGB;
        private System.Windows.Forms.DataGridView detailsview;
        private System.Windows.Forms.ComboBox durbox;
        private System.Windows.Forms.Button delbutt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox groupbox;
        private System.Windows.Forms.Panel panel1;
    }
}

