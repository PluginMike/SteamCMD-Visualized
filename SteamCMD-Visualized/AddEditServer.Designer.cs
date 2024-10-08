namespace SteamCMD_Visualized
{
    partial class AddEditServer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.steamAppIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateFrequencyBox = new System.Windows.Forms.ComboBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.runServer = new System.Windows.Forms.CheckBox();
            this.apply_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.steamAppIDTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.updateFrequencyBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.serverNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.runServer, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // steamAppIDTextBox
            // 
            this.steamAppIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.steamAppIDTextBox.Location = new System.Drawing.Point(217, 56);
            this.steamAppIDTextBox.Name = "steamAppIDTextBox";
            this.steamAppIDTextBox.Size = new System.Drawing.Size(162, 20);
            this.steamAppIDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update Frequency";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Steam App ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server run automatically";
            // 
            // updateFrequencyBox
            // 
            this.updateFrequencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateFrequencyBox.FormattingEnabled = true;
            this.updateFrequencyBox.Location = new System.Drawing.Point(220, 3);
            this.updateFrequencyBox.Name = "updateFrequencyBox";
            this.updateFrequencyBox.Size = new System.Drawing.Size(156, 21);
            this.updateFrequencyBox.TabIndex = 4;
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverNameTextBox.Location = new System.Drawing.Point(217, 30);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.serverNameTextBox.TabIndex = 5;
            // 
            // runServer
            // 
            this.runServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.runServer.AutoSize = true;
            this.runServer.Location = new System.Drawing.Point(290, 84);
            this.runServer.Name = "runServer";
            this.runServer.Size = new System.Drawing.Size(15, 14);
            this.runServer.TabIndex = 7;
            this.runServer.UseVisualStyleBackColor = true;
            // 
            // apply_Button
            // 
            this.apply_Button.Location = new System.Drawing.Point(407, 122);
            this.apply_Button.Name = "apply_Button";
            this.apply_Button.Size = new System.Drawing.Size(75, 23);
            this.apply_Button.TabIndex = 1;
            this.apply_Button.Text = "Apply";
            this.apply_Button.UseVisualStyleBackColor = true;
            this.apply_Button.Click += new System.EventHandler(this.apply_Button_Click);
            // 
            // AddEditServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 152);
            this.Controls.Add(this.apply_Button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditServer";
            this.Text = "AddEditServer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox steamAppIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox updateFrequencyBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.CheckBox runServer;
        private System.Windows.Forms.Button apply_Button;
    }
}