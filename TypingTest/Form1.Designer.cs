namespace TypingTest
{
    partial class typingTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typingTest));
            this.globalTable = new System.Windows.Forms.TableLayoutPanel();
            this.testTable = new System.Windows.Forms.TableLayoutPanel();
            this.promptPanel = new System.Windows.Forms.TableLayoutPanel();
            this.promptHeaderLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.completionLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.statusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.wordCountPanel = new System.Windows.Forms.Label();
            this.wordMinuteLabel = new System.Windows.Forms.Label();
            this.errorPercentLabel = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.globalTable.SuspendLayout();
            this.testTable.SuspendLayout();
            this.promptPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTable
            // 
            this.globalTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.globalTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.globalTable.ColumnCount = 2;
            this.globalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.globalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.globalTable.Controls.Add(this.testTable, 0, 0);
            this.globalTable.Controls.Add(this.statusPanel, 1, 0);
            this.globalTable.Location = new System.Drawing.Point(0, 0);
            this.globalTable.Margin = new System.Windows.Forms.Padding(0);
            this.globalTable.Name = "globalTable";
            this.globalTable.RowCount = 1;
            this.globalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.globalTable.Size = new System.Drawing.Size(1206, 518);
            this.globalTable.TabIndex = 0;
            // 
            // testTable
            // 
            this.testTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.testTable.ColumnCount = 1;
            this.testTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.testTable.Controls.Add(this.promptPanel, 0, 0);
            this.testTable.Controls.Add(this.inputBox, 0, 1);
            this.testTable.Location = new System.Drawing.Point(1, 1);
            this.testTable.Margin = new System.Windows.Forms.Padding(0);
            this.testTable.Name = "testTable";
            this.testTable.RowCount = 2;
            this.testTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.testTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.testTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.testTable.Size = new System.Drawing.Size(902, 516);
            this.testTable.TabIndex = 0;
            // 
            // promptPanel
            // 
            this.promptPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptPanel.ColumnCount = 1;
            this.promptPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.promptPanel.Controls.Add(this.promptHeaderLabel, 0, 0);
            this.promptPanel.Controls.Add(this.promptLabel, 0, 1);
            this.promptPanel.Controls.Add(this.completionLabel, 0, 2);
            this.promptPanel.Location = new System.Drawing.Point(4, 4);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.RowCount = 3;
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.promptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.promptPanel.Size = new System.Drawing.Size(894, 250);
            this.promptPanel.TabIndex = 2;
            // 
            // promptHeaderLabel
            // 
            this.promptHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptHeaderLabel.AutoSize = true;
            this.promptHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.promptHeaderLabel.Name = "promptHeaderLabel";
            this.promptHeaderLabel.Size = new System.Drawing.Size(888, 40);
            this.promptHeaderLabel.TabIndex = 0;
            this.promptHeaderLabel.Text = "Below is the text that will be used to test your typing speed. Please type the fo" +
    "llowing paragraph as quickly and accurately as possible:";
            // 
            // promptLabel
            // 
            this.promptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(3, 40);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.promptLabel.Size = new System.Drawing.Size(888, 61);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = resources.GetString("promptLabel.Text");
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.completionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completionLabel.ForeColor = System.Drawing.Color.Red;
            this.completionLabel.Location = new System.Drawing.Point(0, 225);
            this.completionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(894, 25);
            this.completionLabel.TabIndex = 2;
            this.completionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Location = new System.Drawing.Point(4, 261);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(894, 251);
            this.inputBox.TabIndex = 3;
            this.inputBox.Text = " Begin typing here...";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.SelectAll();
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPanel.ColumnCount = 1;
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusPanel.Controls.Add(this.statusLabel, 0, 0);
            this.statusPanel.Controls.Add(this.wordCountPanel, 0, 1);
            this.statusPanel.Controls.Add(this.wordMinuteLabel, 0, 2);
            this.statusPanel.Controls.Add(this.errorPercentLabel, 0, 3);
            this.statusPanel.Location = new System.Drawing.Point(907, 4);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.RowCount = 4;
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusPanel.Size = new System.Drawing.Size(295, 510);
            this.statusPanel.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(289, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Start typing to begin test...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordCountPanel
            // 
            this.wordCountPanel.AutoSize = true;
            this.wordCountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordCountPanel.Location = new System.Drawing.Point(0, 27);
            this.wordCountPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.wordCountPanel.Name = "wordCountPanel";
            this.wordCountPanel.Size = new System.Drawing.Size(295, 17);
            this.wordCountPanel.TabIndex = 1;
            this.wordCountPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordMinuteLabel
            // 
            this.wordMinuteLabel.AutoSize = true;
            this.wordMinuteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordMinuteLabel.Location = new System.Drawing.Point(0, 54);
            this.wordMinuteLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.wordMinuteLabel.Name = "wordMinuteLabel";
            this.wordMinuteLabel.Size = new System.Drawing.Size(295, 17);
            this.wordMinuteLabel.TabIndex = 2;
            this.wordMinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPercentLabel
            // 
            this.errorPercentLabel.AutoSize = true;
            this.errorPercentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorPercentLabel.Location = new System.Drawing.Point(0, 81);
            this.errorPercentLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.errorPercentLabel.Name = "errorPercentLabel";
            this.errorPercentLabel.Size = new System.Drawing.Size(295, 17);
            this.errorPercentLabel.TabIndex = 3;
            this.errorPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testTimer
            // 
            this.testTimer.Interval = 1000;
            this.testTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // typingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1206, 518);
            this.Controls.Add(this.globalTable);
            this.MinimumSize = new System.Drawing.Size(565, 565);
            this.Name = "typingTest";
            this.Text = "TypingTest";
            this.globalTable.ResumeLayout(false);
            this.testTable.ResumeLayout(false);
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel globalTable;
        private System.Windows.Forms.TableLayoutPanel testTable;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.TableLayoutPanel promptPanel;
        private System.Windows.Forms.Label promptHeaderLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TableLayoutPanel statusPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label wordCountPanel;
        private System.Windows.Forms.Label wordMinuteLabel;
        private System.Windows.Forms.Label completionLabel;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Label errorPercentLabel;
    }
}

