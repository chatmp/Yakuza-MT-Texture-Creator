namespace YakuzaMTTextureCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSelectRed = new Button();
            lblRed = new TextBox();
            btnDeleteRed = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnSelectGreen = new Button();
            lblGreen = new TextBox();
            btnDeleteGreen = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnSelectBlue = new Button();
            lblBlue = new TextBox();
            btnDeleteBlue = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnAlpha = new Button();
            lblAlpha = new TextBox();
            btnDeleteAlpha = new Button();
            btnCreate = new Button();
            previewBox = new CheckerboardPictureBox();
            comboBoxEngineType = new ComboBox();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewBox).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.BackColor = Color.Transparent;
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.Controls.Add(btnCreate);
            flowLayoutPanel4.Controls.Add(previewBox);
            flowLayoutPanel4.Controls.Add(comboBoxEngineType);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(680, 369);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(btnSelectRed);
            flowLayoutPanel1.Controls.Add(lblRed);
            flowLayoutPanel1.Controls.Add(btnDeleteRed);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(407, 60);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSelectRed
            // 
            btnSelectRed.Anchor = AnchorStyles.Left;
            btnSelectRed.Cursor = Cursors.Hand;
            btnSelectRed.ForeColor = Color.FromArgb(192, 0, 0);
            btnSelectRed.Location = new Point(20, 3);
            btnSelectRed.Margin = new Padding(20, 3, 3, 3);
            btnSelectRed.Name = "btnSelectRed";
            btnSelectRed.Size = new Size(300, 30);
            btnSelectRed.TabIndex = 0;
            btnSelectRed.Text = "Select Specular PNG*";
            btnSelectRed.UseVisualStyleBackColor = true;
            btnSelectRed.Click += btnSelectRed_Click;
            // 
            // lblRed
            // 
            lblRed.Anchor = AnchorStyles.Left;
            lblRed.BorderStyle = BorderStyle.None;
            lblRed.Cursor = Cursors.Help;
            lblRed.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblRed.ImeMode = ImeMode.NoControl;
            lblRed.Location = new Point(20, 39);
            lblRed.Margin = new Padding(20, 3, 3, 3);
            lblRed.Name = "lblRed";
            lblRed.ReadOnly = true;
            lblRed.ScrollBars = ScrollBars.Horizontal;
            lblRed.Size = new Size(300, 16);
            lblRed.TabIndex = 3;
            lblRed.Text = "No Image Selected";
            lblRed.WordWrap = false;
            // 
            // btnDeleteRed
            // 
            btnDeleteRed.Anchor = AnchorStyles.Left;
            btnDeleteRed.BackColor = Color.LightGray;
            btnDeleteRed.BackgroundImageLayout = ImageLayout.None;
            btnDeleteRed.Cursor = Cursors.Hand;
            btnDeleteRed.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteRed.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteRed.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDeleteRed.FlatStyle = FlatStyle.Flat;
            btnDeleteRed.Font = new Font("Segoe UI", 9F);
            btnDeleteRed.Location = new Point(328, 3);
            btnDeleteRed.Margin = new Padding(5, 3, 3, 3);
            btnDeleteRed.Name = "btnDeleteRed";
            btnDeleteRed.Size = new Size(30, 30);
            btnDeleteRed.TabIndex = 8;
            btnDeleteRed.Text = "X";
            btnDeleteRed.UseVisualStyleBackColor = false;
            btnDeleteRed.Click += btnDeleteRed_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Left;
            flowLayoutPanel3.Controls.Add(btnSelectGreen);
            flowLayoutPanel3.Controls.Add(lblGreen);
            flowLayoutPanel3.Controls.Add(btnDeleteGreen);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 69);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(407, 60);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // btnSelectGreen
            // 
            btnSelectGreen.Anchor = AnchorStyles.Left;
            btnSelectGreen.Cursor = Cursors.Hand;
            btnSelectGreen.ForeColor = Color.FromArgb(0, 192, 0);
            btnSelectGreen.Location = new Point(20, 3);
            btnSelectGreen.Margin = new Padding(20, 3, 3, 3);
            btnSelectGreen.Name = "btnSelectGreen";
            btnSelectGreen.Size = new Size(300, 30);
            btnSelectGreen.TabIndex = 6;
            btnSelectGreen.Text = "Select Specular Power Multiplier PNG*";
            btnSelectGreen.UseVisualStyleBackColor = true;
            btnSelectGreen.Click += btnSelectGreen_Click;
            // 
            // lblGreen
            // 
            lblGreen.Anchor = AnchorStyles.Left;
            lblGreen.BorderStyle = BorderStyle.None;
            lblGreen.Cursor = Cursors.Help;
            lblGreen.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblGreen.ImeMode = ImeMode.NoControl;
            lblGreen.Location = new Point(20, 39);
            lblGreen.Margin = new Padding(20, 3, 3, 3);
            lblGreen.Name = "lblGreen";
            lblGreen.ReadOnly = true;
            lblGreen.ScrollBars = ScrollBars.Horizontal;
            lblGreen.Size = new Size(300, 16);
            lblGreen.TabIndex = 7;
            lblGreen.Text = "No Image Selected";
            lblGreen.WordWrap = false;
            // 
            // btnDeleteGreen
            // 
            btnDeleteGreen.Anchor = AnchorStyles.Left;
            btnDeleteGreen.BackColor = Color.LightGray;
            btnDeleteGreen.BackgroundImageLayout = ImageLayout.None;
            btnDeleteGreen.Cursor = Cursors.Hand;
            btnDeleteGreen.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteGreen.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteGreen.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDeleteGreen.FlatStyle = FlatStyle.Flat;
            btnDeleteGreen.Font = new Font("Segoe UI", 9F);
            btnDeleteGreen.Location = new Point(328, 3);
            btnDeleteGreen.Margin = new Padding(5, 3, 3, 3);
            btnDeleteGreen.Name = "btnDeleteGreen";
            btnDeleteGreen.Size = new Size(30, 30);
            btnDeleteGreen.TabIndex = 8;
            btnDeleteGreen.Text = "X";
            btnDeleteGreen.UseVisualStyleBackColor = false;
            btnDeleteGreen.Click += btnDeleteGreen_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(btnSelectBlue);
            flowLayoutPanel2.Controls.Add(lblBlue);
            flowLayoutPanel2.Controls.Add(btnDeleteBlue);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 135);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(407, 60);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // btnSelectBlue
            // 
            btnSelectBlue.Anchor = AnchorStyles.Left;
            btnSelectBlue.Cursor = Cursors.Hand;
            btnSelectBlue.ForeColor = Color.FromArgb(0, 0, 192);
            btnSelectBlue.Location = new Point(20, 3);
            btnSelectBlue.Margin = new Padding(20, 3, 3, 3);
            btnSelectBlue.Name = "btnSelectBlue";
            btnSelectBlue.Size = new Size(300, 30);
            btnSelectBlue.TabIndex = 5;
            btnSelectBlue.Text = "Select Ambient Occlusion PNG*";
            btnSelectBlue.UseVisualStyleBackColor = true;
            btnSelectBlue.Click += btnSelectBlue_Click;
            // 
            // lblBlue
            // 
            lblBlue.Anchor = AnchorStyles.Left;
            lblBlue.BorderStyle = BorderStyle.None;
            lblBlue.Cursor = Cursors.Help;
            lblBlue.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblBlue.ImeMode = ImeMode.NoControl;
            lblBlue.Location = new Point(20, 39);
            lblBlue.Margin = new Padding(20, 3, 3, 3);
            lblBlue.Name = "lblBlue";
            lblBlue.ReadOnly = true;
            lblBlue.ScrollBars = ScrollBars.Horizontal;
            lblBlue.Size = new Size(300, 16);
            lblBlue.TabIndex = 6;
            lblBlue.Text = "No Image Selected";
            lblBlue.WordWrap = false;
            // 
            // btnDeleteBlue
            // 
            btnDeleteBlue.Anchor = AnchorStyles.Left;
            btnDeleteBlue.BackColor = Color.LightGray;
            btnDeleteBlue.BackgroundImageLayout = ImageLayout.None;
            btnDeleteBlue.Cursor = Cursors.Hand;
            btnDeleteBlue.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteBlue.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteBlue.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDeleteBlue.FlatStyle = FlatStyle.Flat;
            btnDeleteBlue.Font = new Font("Segoe UI", 9F);
            btnDeleteBlue.Location = new Point(328, 3);
            btnDeleteBlue.Margin = new Padding(5, 3, 3, 3);
            btnDeleteBlue.Name = "btnDeleteBlue";
            btnDeleteBlue.Size = new Size(30, 30);
            btnDeleteBlue.TabIndex = 8;
            btnDeleteBlue.Text = "X";
            btnDeleteBlue.UseVisualStyleBackColor = false;
            btnDeleteBlue.Click += btnDeleteBlue_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Left;
            flowLayoutPanel5.BackColor = Color.Transparent;
            flowLayoutPanel5.Controls.Add(btnAlpha);
            flowLayoutPanel5.Controls.Add(lblAlpha);
            flowLayoutPanel5.Controls.Add(btnDeleteAlpha);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 201);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(407, 60);
            flowLayoutPanel5.TabIndex = 12;
            // 
            // btnAlpha
            // 
            btnAlpha.Anchor = AnchorStyles.Left;
            btnAlpha.Cursor = Cursors.Hand;
            btnAlpha.ForeColor = Color.Gray;
            btnAlpha.Location = new Point(20, 3);
            btnAlpha.Margin = new Padding(20, 3, 3, 3);
            btnAlpha.Name = "btnAlpha";
            btnAlpha.Size = new Size(300, 30);
            btnAlpha.TabIndex = 5;
            btnAlpha.Text = "Select Pattern Mask PNG";
            btnAlpha.UseVisualStyleBackColor = true;
            btnAlpha.Click += btnPatternMask_Click;
            // 
            // lblAlpha
            // 
            lblAlpha.Anchor = AnchorStyles.Left;
            lblAlpha.BorderStyle = BorderStyle.None;
            lblAlpha.Cursor = Cursors.Help;
            lblAlpha.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblAlpha.ImeMode = ImeMode.NoControl;
            lblAlpha.Location = new Point(20, 39);
            lblAlpha.Margin = new Padding(20, 3, 3, 3);
            lblAlpha.Name = "lblAlpha";
            lblAlpha.ReadOnly = true;
            lblAlpha.ScrollBars = ScrollBars.Horizontal;
            lblAlpha.Size = new Size(300, 16);
            lblAlpha.TabIndex = 6;
            lblAlpha.Text = "No Image Selected";
            lblAlpha.WordWrap = false;
            // 
            // btnDeleteAlpha
            // 
            btnDeleteAlpha.Anchor = AnchorStyles.Left;
            btnDeleteAlpha.BackColor = Color.LightGray;
            btnDeleteAlpha.BackgroundImageLayout = ImageLayout.None;
            btnDeleteAlpha.Cursor = Cursors.Hand;
            btnDeleteAlpha.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteAlpha.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnDeleteAlpha.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDeleteAlpha.FlatStyle = FlatStyle.Flat;
            btnDeleteAlpha.Font = new Font("Segoe UI", 9F);
            btnDeleteAlpha.Location = new Point(328, 3);
            btnDeleteAlpha.Margin = new Padding(5, 3, 3, 3);
            btnDeleteAlpha.Name = "btnDeleteAlpha";
            btnDeleteAlpha.Size = new Size(30, 30);
            btnDeleteAlpha.TabIndex = 7;
            btnDeleteAlpha.Text = "X";
            btnDeleteAlpha.UseVisualStyleBackColor = false;
            btnDeleteAlpha.Click += btnDeleteAlpha_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.BackgroundImageLayout = ImageLayout.None;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Location = new Point(30, 267);
            btnCreate.Margin = new Padding(30, 3, 30, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(353, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Combined PNG";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // previewBox
            // 
            previewBox.Anchor = AnchorStyles.Left;
            previewBox.BackColor = Color.Transparent;
            previewBox.BackgroundImageLayout = ImageLayout.None;
            previewBox.BorderStyle = BorderStyle.FixedSingle;
            previewBox.Image = Properties.Resources.nopreview_image;
            previewBox.Location = new Point(416, 3);
            previewBox.Name = "previewBox";
            previewBox.Size = new Size(250, 250);
            previewBox.SizeMode = PictureBoxSizeMode.Zoom;
            previewBox.TabIndex = 10;
            previewBox.TabStop = false;
            // 
            // comboBoxEngineType
            // 
            comboBoxEngineType.Anchor = AnchorStyles.Right;
            comboBoxEngineType.Cursor = Cursors.Hand;
            comboBoxEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEngineType.FormattingEnabled = true;
            comboBoxEngineType.Items.AddRange(new object[] { "Old Engine", "Dragon Engine" });
            comboBoxEngineType.Location = new Point(543, 259);
            comboBoxEngineType.Margin = new Padding(3, 3, 5, 3);
            comboBoxEngineType.Name = "comboBoxEngineType";
            comboBoxEngineType.Size = new Size(121, 23);
            comboBoxEngineType.TabIndex = 0;
            comboBoxEngineType.SelectedIndexChanged += comboBoxEngineType_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(flowLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yakuza MT Texture Creator";
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSelectRed;
        private TextBox lblRed;
        private Button btnDeleteRed;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnSelectGreen;
        private TextBox lblGreen;
        private Button btnDeleteGreen;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnSelectBlue;
        private TextBox lblBlue;
        private Button btnDeleteBlue;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnAlpha;
        private TextBox lblAlpha;
        private Button btnDeleteAlpha;
        private Button btnCreate;
        private ComboBox comboBoxEngineType;
        private CheckerboardPictureBox previewBox;
    }
}