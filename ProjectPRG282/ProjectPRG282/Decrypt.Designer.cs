namespace ProjectPRG282
{
    partial class Decrypt
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
            this.components = new System.ComponentModel.Container();
            this.OpenedPanel = new System.Windows.Forms.Panel();
            this.btnOfficer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPastComms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPanelOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.OpenedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenedPanel
            // 
            this.OpenedPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.OpenedPanel.Controls.Add(this.btnOfficer);
            this.OpenedPanel.Controls.Add(this.button3);
            this.OpenedPanel.Controls.Add(this.btnPastComms);
            this.OpenedPanel.Controls.Add(this.button1);
            this.OpenedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenedPanel.Location = new System.Drawing.Point(27, 0);
            this.OpenedPanel.Name = "OpenedPanel";
            this.OpenedPanel.Size = new System.Drawing.Size(10, 442);
            this.OpenedPanel.TabIndex = 4;
            // 
            // btnOfficer
            // 
            this.btnOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOfficer.Location = new System.Drawing.Point(6, 122);
            this.btnOfficer.Name = "btnOfficer";
            this.btnOfficer.Size = new System.Drawing.Size(155, 36);
            this.btnOfficer.TabIndex = 6;
            this.btnOfficer.Text = "Officers";
            this.btnOfficer.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(6, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPastComms
            // 
            this.btnPastComms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastComms.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastComms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPastComms.Location = new System.Drawing.Point(6, 66);
            this.btnPastComms.Name = "btnPastComms";
            this.btnPastComms.Size = new System.Drawing.Size(155, 34);
            this.btnPastComms.TabIndex = 4;
            this.btnPastComms.Text = "Past Communications";
            this.btnPastComms.UseVisualStyleBackColor = true;
            this.btnPastComms.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnPanelOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 442);
            this.panel1.TabIndex = 3;
            // 
            // btnPanelOpen
            // 
            this.btnPanelOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelOpen.FlatAppearance.BorderSize = 0;
            this.btnPanelOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelOpen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPanelOpen.Location = new System.Drawing.Point(0, 0);
            this.btnPanelOpen.Name = "btnPanelOpen";
            this.btnPanelOpen.Size = new System.Drawing.Size(27, 29);
            this.btnPanelOpen.TabIndex = 1;
            this.btnPanelOpen.Text = "=";
            this.btnPanelOpen.UseVisualStyleBackColor = true;
            this.btnPanelOpen.Click += new System.EventHandler(this.btnPanelOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decrypt";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(577, 120);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Drag the Textfile here";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Teal;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecrypt.Location = new System.Drawing.Point(43, 164);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(115, 58);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(43, 228);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(577, 202);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(278, 164);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 58);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(505, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 58);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 442);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.OpenedPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.Load += new System.EventHandler(this.Decrypt_Load);
            this.OpenedPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OpenedPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPastComms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPanelOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnOfficer;
    }
}