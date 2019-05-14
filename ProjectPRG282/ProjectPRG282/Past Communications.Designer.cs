namespace ProjectPRG282
{
    partial class Past_Communications
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
            this.btnOfficers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPanelOpen = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenedPanel
            // 
            this.OpenedPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.OpenedPanel.Controls.Add(this.btnOfficers);
            this.OpenedPanel.Controls.Add(this.button3);
            this.OpenedPanel.Controls.Add(this.btnDecrypt);
            this.OpenedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenedPanel.Location = new System.Drawing.Point(27, 0);
            this.OpenedPanel.Name = "OpenedPanel";
            this.OpenedPanel.Size = new System.Drawing.Size(191, 442);
            this.OpenedPanel.TabIndex = 13;
            // 
            // btnOfficers
            // 
            this.btnOfficers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOfficers.Location = new System.Drawing.Point(6, 62);
            this.btnOfficers.Name = "btnOfficers";
            this.btnOfficers.Size = new System.Drawing.Size(171, 36);
            this.btnOfficers.TabIndex = 6;
            this.btnOfficers.Text = "Officers";
            this.btnOfficers.UseVisualStyleBackColor = true;
            this.btnOfficers.Click += new System.EventHandler(this.btnOfficers_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(6, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecrypt.Location = new System.Drawing.Point(6, 10);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(171, 36);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnPanelOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 442);
            this.panel1.TabIndex = 12;
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
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(43, 34);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(668, 177);
            this.dgvDisplay.TabIndex = 14;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Past Communications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Duration :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "MessageID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Message :";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(152, 288);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(559, 26);
            this.txtMessage.TabIndex = 21;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(152, 256);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(184, 26);
            this.txtDuration.TabIndex = 20;
            // 
            // txtMessageID
            // 
            this.txtMessageID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageID.Location = new System.Drawing.Point(152, 224);
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.Size = new System.Drawing.Size(184, 26);
            this.txtMessageID.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(540, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 36);
            this.button5.TabIndex = 22;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Past_Communications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 442);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.OpenedPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessageID);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Past_Communications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Past_Communications";
            this.Load += new System.EventHandler(this.Past_Communications_Load);
            this.OpenedPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel OpenedPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPanelOpen;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button btnOfficers;
        private System.Windows.Forms.Timer timer1;
    }
}