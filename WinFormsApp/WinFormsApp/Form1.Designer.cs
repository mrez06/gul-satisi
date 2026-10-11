namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private DataGridView dataGridView1;
        private GroupBox inputGroupBox;
        private Label flowerNameLabel;
        private Label countLabel;
        private Label priceLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button sellButton;
        private Button exitButton;
        private Panel summaryPanel;
        private Label totalCaptionLabel;
        private Label totalValueLabel;
        private Label tableCaptionLabel;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            headerPanel = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            dataGridView1 = new DataGridView();
            inputGroupBox = new GroupBox();
            flowerNameLabel = new Label();
            countLabel = new Label();
            priceLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            sellButton = new Button();
            exitButton = new Button();
            summaryPanel = new Panel();
            totalCaptionLabel = new Label();
            totalValueLabel = new Label();
            tableCaptionLabel = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            inputGroupBox.SuspendLayout();
            summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(112, 35, 126);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1120, 125);
            headerPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(32, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(314, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Gül satış proqramı";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(235, 220, 240);
            subtitleLabel.Location = new Point(35, 75);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(335, 23);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Satış məlumatlarını daxil edin və qeyd edin";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 38;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(32, 191);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 34;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1056, 288);
            dataGridView1.TabIndex = 2;
            // 
            // inputGroupBox
            // 
            inputGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputGroupBox.BackColor = Color.MediumPurple;
            inputGroupBox.Controls.Add(pictureBox1);
            inputGroupBox.Controls.Add(flowerNameLabel);
            inputGroupBox.Controls.Add(countLabel);
            inputGroupBox.Controls.Add(priceLabel);
            inputGroupBox.Controls.Add(textBox1);
            inputGroupBox.Controls.Add(textBox2);
            inputGroupBox.Controls.Add(textBox3);
            inputGroupBox.Controls.Add(sellButton);
            inputGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            inputGroupBox.ForeColor = Color.FromArgb(75, 45, 80);
            inputGroupBox.Location = new Point(32, 519);
            inputGroupBox.Margin = new Padding(3, 4, 3, 4);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Padding = new Padding(3, 4, 3, 4);
            inputGroupBox.Size = new Size(697, 207);
            inputGroupBox.TabIndex = 0;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Yeni satış";
            // 
            // flowerNameLabel
            // 
            flowerNameLabel.AutoSize = true;
            flowerNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            flowerNameLabel.Location = new Point(23, 49);
            flowerNameLabel.Name = "flowerNameLabel";
            flowerNameLabel.Size = new Size(72, 20);
            flowerNameLabel.TabIndex = 0;
            flowerNameLabel.Text = "Gül növü";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countLabel.Location = new Point(23, 121);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(33, 20);
            countLabel.TabIndex = 1;
            countLabel.Text = "Say";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            priceLabel.Location = new Point(211, 121);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(60, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Qiymət";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(23, 77);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(23, 149);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(211, 149);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 30);
            textBox3.TabIndex = 2;
            // 
            // sellButton
            // 
            sellButton.BackColor = Color.FromArgb(112, 35, 126);
            sellButton.FlatAppearance.BorderSize = 0;
            sellButton.FlatStyle = FlatStyle.Flat;
            sellButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sellButton.ForeColor = Color.White;
            sellButton.Location = new Point(456, 121);
            sellButton.Margin = new Padding(3, 4, 3, 4);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(128, 67);
            sellButton.TabIndex = 3;
            sellButton.Text = "Satış et";
            sellButton.UseVisualStyleBackColor = false;
            sellButton.Click += sellButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.SandyBrown;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(210, 144);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(56, 39);
            exitButton.TabIndex = 0;
            exitButton.Text = "Çıxış";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            summaryPanel.BackColor = Color.Fuchsia;
            summaryPanel.Controls.Add(totalCaptionLabel);
            summaryPanel.Controls.Add(exitButton);
            summaryPanel.Controls.Add(pictureBox2);
            summaryPanel.Controls.Add(totalValueLabel);
            summaryPanel.Location = new Point(763, 519);
            summaryPanel.Margin = new Padding(3, 4, 3, 4);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(325, 207);
            summaryPanel.TabIndex = 1;
            // 
            // totalCaptionLabel
            // 
            totalCaptionLabel.AutoSize = true;
            totalCaptionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalCaptionLabel.ForeColor = Color.FromArgb(75, 45, 80);
            totalCaptionLabel.Location = new Point(23, 27);
            totalCaptionLabel.Name = "totalCaptionLabel";
            totalCaptionLabel.Size = new Size(117, 23);
            totalCaptionLabel.TabIndex = 0;
            totalCaptionLabel.Text = "Toplam gəlir:";
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            totalValueLabel.ForeColor = Color.FromArgb(112, 35, 126);
            totalValueLabel.Location = new Point(23, 64);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(77, 41);
            totalValueLabel.TabIndex = 1;
            totalValueLabel.Text = "0.00";
            // 
            // tableCaptionLabel
            // 
            tableCaptionLabel.AutoSize = true;
            tableCaptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableCaptionLabel.ForeColor = Color.FromArgb(65, 50, 70);
            tableCaptionLabel.Location = new Point(32, 149);
            tableCaptionLabel.Name = "tableCaptionLabel";
            tableCaptionLabel.Size = new Size(178, 28);
            tableCaptionLabel.TabIndex = 3;
            tableCaptionLabel.Text = "Satış məlumatları";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Gül növü (gül adı)";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Satış sayı";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Qiyməti";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Yekun qiyməti";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(469, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 773);
            Controls.Add(inputGroupBox);
            Controls.Add(summaryPanel);
            Controls.Add(dataGridView1);
            Controls.Add(tableCaptionLabel);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(935, 704);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gül satış proqramı";
            Load += Form1_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            inputGroupBox.ResumeLayout(false);
            inputGroupBox.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
