namespace Grouppps
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
            this.loadbtn = new Guna.UI2.WinForms.Guna2Button();
            this.studnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.attendancetbl = new System.Windows.Forms.DataGridView();
            this.clrbtn = new Guna.UI2.WinForms.Guna2Button();
            this.delbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.datetimepick = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.studnumtxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.attendancetbl)).BeginInit();
            this.SuspendLayout();
            // 
            // loadbtn
            // 
            this.loadbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadbtn.ForeColor = System.Drawing.Color.White;
            this.loadbtn.Location = new System.Drawing.Point(463, 311);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(73, 29);
            this.loadbtn.TabIndex = 17;
            this.loadbtn.Text = "LOAD";
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // studnametxt
            // 
            this.studnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studnametxt.DefaultText = "";
            this.studnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studnametxt.FillColor = System.Drawing.Color.Black;
            this.studnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studnametxt.Location = new System.Drawing.Point(79, 176);
            this.studnametxt.Name = "studnametxt";
            this.studnametxt.PasswordChar = '\0';
            this.studnametxt.PlaceholderText = "STUDENT NAME";
            this.studnametxt.SelectedText = "";
            this.studnametxt.Size = new System.Drawing.Size(200, 36);
            this.studnametxt.TabIndex = 16;
            // 
            // attendancetbl
            // 
            this.attendancetbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attendancetbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendancetbl.Location = new System.Drawing.Point(369, 111);
            this.attendancetbl.Name = "attendancetbl";
            this.attendancetbl.Size = new System.Drawing.Size(342, 150);
            this.attendancetbl.TabIndex = 15;
            // 
            // clrbtn
            // 
            this.clrbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clrbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clrbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clrbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clrbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clrbtn.ForeColor = System.Drawing.Color.White;
            this.clrbtn.Location = new System.Drawing.Point(559, 311);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(73, 29);
            this.clrbtn.TabIndex = 14;
            this.clrbtn.Text = "CLEAR";
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.Location = new System.Drawing.Point(648, 311);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(73, 29);
            this.delbtn.TabIndex = 13;
            this.delbtn.Text = "DELETE";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(369, 311);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(73, 29);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "ADD";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // datetimepick
            // 
            this.datetimepick.Checked = true;
            this.datetimepick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetimepick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepick.Location = new System.Drawing.Point(79, 252);
            this.datetimepick.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepick.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepick.Name = "datetimepick";
            this.datetimepick.Size = new System.Drawing.Size(200, 36);
            this.datetimepick.TabIndex = 11;
            this.datetimepick.Value = new System.DateTime(2024, 4, 24, 22, 57, 46, 338);
            // 
            // studnumtxt
            // 
            this.studnumtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studnumtxt.DefaultText = "";
            this.studnumtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studnumtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studnumtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studnumtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studnumtxt.FillColor = System.Drawing.Color.Black;
            this.studnumtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studnumtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studnumtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studnumtxt.Location = new System.Drawing.Point(79, 111);
            this.studnumtxt.Name = "studnumtxt";
            this.studnumtxt.PasswordChar = '\0';
            this.studnumtxt.PlaceholderText = "STUDENT NUMBER";
            this.studnumtxt.SelectedText = "";
            this.studnumtxt.Size = new System.Drawing.Size(200, 36);
            this.studnumtxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.studnametxt);
            this.Controls.Add(this.attendancetbl);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.datetimepick);
            this.Controls.Add(this.studnumtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.attendancetbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loadbtn;
        private Guna.UI2.WinForms.Guna2TextBox studnametxt;
        private System.Windows.Forms.DataGridView attendancetbl;
        private Guna.UI2.WinForms.Guna2Button clrbtn;
        private Guna.UI2.WinForms.Guna2Button delbtn;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepick;
        private Guna.UI2.WinForms.Guna2TextBox studnumtxt;
    }
}

