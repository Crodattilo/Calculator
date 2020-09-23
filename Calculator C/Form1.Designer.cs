namespace Calculator_C
{
    partial class Calculator
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Label = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.output = new System.Windows.Forms.TextBox();
            this.Button16 = new System.Windows.Forms.Button();
            this.Button17 = new System.Windows.Forms.Button();
            this.Button18 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this._Button15 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Label.Location = new System.Drawing.Point(210, 280);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 13);
            this.Label.TabIndex = 44;
            this.Label.Text = "Crodattilo";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LinkLabel
            // 
            this.LinkLabel.ActiveLinkColor = System.Drawing.Color.LightSalmon;
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.LinkLabel.Location = new System.Drawing.Point(9, 280);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(46, 13);
            this.LinkLabel.TabIndex = 43;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Website";
            this.LinkLabel.VisitedLinkColor = System.Drawing.Color.LightSkyBlue;
            this.LinkLabel.Click += new System.EventHandler(this.website);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.Control;
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(249, 38);
            this.output.TabIndex = 42;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button16
            // 
            this.Button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button16.FlatAppearance.BorderSize = 0;
            this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button16.ForeColor = System.Drawing.SystemColors.Control;
            this.Button16.Location = new System.Drawing.Point(216, 171);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(45, 96);
            this.Button16.TabIndex = 41;
            this.Button16.Text = "=";
            this.Button16.UseVisualStyleBackColor = false;
            this.Button16.Click += new System.EventHandler(this.op_res);
            // 
            // Button17
            // 
            this.Button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button17.FlatAppearance.BorderSize = 0;
            this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button17.ForeColor = System.Drawing.SystemColors.Control;
            this.Button17.Location = new System.Drawing.Point(165, 222);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(45, 45);
            this.Button17.TabIndex = 40;
            this.Button17.Text = "÷";
            this.Button17.UseVisualStyleBackColor = false;
            this.Button17.Click += new System.EventHandler(this.op_pres);
            // 
            // Button18
            // 
            this.Button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button18.FlatAppearance.BorderSize = 0;
            this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button18.ForeColor = System.Drawing.SystemColors.Control;
            this.Button18.Location = new System.Drawing.Point(114, 222);
            this.Button18.Name = "Button18";
            this.Button18.Size = new System.Drawing.Size(45, 45);
            this.Button18.TabIndex = 39;
            this.Button18.Text = ",";
            this.Button18.UseVisualStyleBackColor = false;
            this.Button18.Click += new System.EventHandler(this.button_click);
            // 
            // Button20
            // 
            this.Button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button20.FlatAppearance.BorderSize = 0;
            this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button20.ForeColor = System.Drawing.SystemColors.Control;
            this.Button20.Location = new System.Drawing.Point(12, 222);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(96, 45);
            this.Button20.TabIndex = 38;
            this.Button20.Text = "0";
            this.Button20.UseVisualStyleBackColor = false;
            this.Button20.Click += new System.EventHandler(this.button_click);
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button12.ForeColor = System.Drawing.SystemColors.Control;
            this.Button12.Location = new System.Drawing.Point(165, 171);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(45, 45);
            this.Button12.TabIndex = 37;
            this.Button12.Text = "×";
            this.Button12.UseVisualStyleBackColor = false;
            this.Button12.Click += new System.EventHandler(this.op_pres);
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button13.FlatAppearance.BorderSize = 0;
            this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button13.ForeColor = System.Drawing.SystemColors.Control;
            this.Button13.Location = new System.Drawing.Point(114, 171);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(45, 45);
            this.Button13.TabIndex = 36;
            this.Button13.Text = "3";
            this.Button13.UseVisualStyleBackColor = false;
            this.Button13.Click += new System.EventHandler(this.button_click);
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button14.FlatAppearance.BorderSize = 0;
            this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button14.ForeColor = System.Drawing.SystemColors.Control;
            this.Button14.Location = new System.Drawing.Point(63, 171);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(45, 45);
            this.Button14.TabIndex = 35;
            this.Button14.Text = "2";
            this.Button14.UseVisualStyleBackColor = false;
            this.Button14.Click += new System.EventHandler(this.button_click);
            // 
            // _Button15
            // 
            this._Button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this._Button15.FlatAppearance.BorderSize = 0;
            this._Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Button15.ForeColor = System.Drawing.SystemColors.Control;
            this._Button15.Location = new System.Drawing.Point(12, 171);
            this._Button15.Name = "_Button15";
            this._Button15.Size = new System.Drawing.Size(45, 45);
            this._Button15.TabIndex = 34;
            this._Button15.Text = "1";
            this._Button15.UseVisualStyleBackColor = false;
            this._Button15.Click += new System.EventHandler(this.button_click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.SystemColors.Control;
            this.Button6.Location = new System.Drawing.Point(216, 120);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(45, 45);
            this.Button6.TabIndex = 33;
            this.Button6.Text = "C";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.c_pres);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.SystemColors.Control;
            this.Button7.Location = new System.Drawing.Point(165, 120);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(45, 45);
            this.Button7.TabIndex = 32;
            this.Button7.Text = "-";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.op_pres);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.SystemColors.Control;
            this.Button8.Location = new System.Drawing.Point(114, 120);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(45, 45);
            this.Button8.TabIndex = 31;
            this.Button8.Text = "6";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.button_click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.ForeColor = System.Drawing.SystemColors.Control;
            this.Button9.Location = new System.Drawing.Point(63, 120);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(45, 45);
            this.Button9.TabIndex = 30;
            this.Button9.Text = "5";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.button_click);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button10.FlatAppearance.BorderSize = 0;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button10.ForeColor = System.Drawing.SystemColors.Control;
            this.Button10.Location = new System.Drawing.Point(12, 120);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(45, 45);
            this.Button10.TabIndex = 29;
            this.Button10.Text = "4";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.button_click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(216, 69);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(45, 45);
            this.Button5.TabIndex = 28;
            this.Button5.Text = "CE";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.Button4.Location = new System.Drawing.Point(165, 69);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(45, 45);
            this.Button4.TabIndex = 27;
            this.Button4.Text = "+";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.op_pres);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.Control;
            this.Button3.Location = new System.Drawing.Point(114, 69);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(45, 45);
            this.Button3.TabIndex = 26;
            this.Button3.Text = "9";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.button_click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(63, 69);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(45, 45);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "8";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.button_click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(12, 69);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(45, 45);
            this.Button1.TabIndex = 24;
            this.Button1.Text = "7";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(272, 301);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Button16);
            this.Controls.Add(this.Button17);
            this.Controls.Add(this.Button18);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this._Button15);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label;
        internal System.Windows.Forms.LinkLabel LinkLabel;
        internal System.Windows.Forms.TextBox output;
        internal System.Windows.Forms.Button Button16;
        internal System.Windows.Forms.Button Button17;
        internal System.Windows.Forms.Button Button18;
        internal System.Windows.Forms.Button Button20;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.Button Button13;
        internal System.Windows.Forms.Button Button14;
        private System.Windows.Forms.Button _Button15;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}

