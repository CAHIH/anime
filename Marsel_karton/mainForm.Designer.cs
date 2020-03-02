namespace Marsel_karton
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ДжоДжо = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.persTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.diavoloButton = new System.Windows.Forms.Button();
            this.josukeButton = new System.Windows.Forms.Button();
            this.jonathanButton = new System.Windows.Forms.Button();
            this.jonniButton = new System.Windows.Forms.Button();
            this.joshefButton = new System.Windows.Forms.Button();
            this.dioButton = new System.Windows.Forms.Button();
            this.jojoButton = new System.Windows.Forms.Button();
            this.jolinButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.siteTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1.SuspendLayout();
            this.ДжоДжо.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.persTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.siteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem2.Text = "1242134";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Что посмотреть?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ДжоДжо
            // 
            this.ДжоДжо.Controls.Add(this.mainTabPage);
            this.ДжоДжо.Controls.Add(this.persTabPage);
            this.ДжоДжо.Controls.Add(this.siteTabPage);
            this.ДжоДжо.Cursor = System.Windows.Forms.Cursors.Default;
            this.ДжоДжо.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ДжоДжо.Location = new System.Drawing.Point(0, 0);
            this.ДжоДжо.Name = "ДжоДжо";
            this.ДжоДжо.SelectedIndex = 0;
            this.ДжоДжо.Size = new System.Drawing.Size(785, 351);
            this.ДжоДжо.TabIndex = 7;
            this.toolTip1.SetToolTip(this.ДжоДжо, "Можешь посчитать сколько ещё дней до чего либо");
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.pictureBox1);
            this.mainTabPage.Controls.Add(this.richTextBox1);
            this.mainTabPage.Controls.Add(this.label1);
            this.mainTabPage.Location = new System.Drawing.Point(4, 23);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(777, 324);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Пора домой";
            this.mainTabPage.ToolTipText = "Быстрее в Доту2";
            this.mainTabPage.UseVisualStyleBackColor = true;
            this.mainTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 215);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Если тебе нечего делать и ты решил посмотреть аниме , ты попал туда куда надо , к" +
    "ликни на надпись \"что посмотреть?\"";
            // 
            // persTabPage
            // 
            this.persTabPage.Controls.Add(this.tableLayoutPanel1);
            this.persTabPage.Controls.Add(this.pictureBox2);
            this.persTabPage.Location = new System.Drawing.Point(4, 23);
            this.persTabPage.Name = "persTabPage";
            this.persTabPage.Size = new System.Drawing.Size(777, 324);
            this.persTabPage.TabIndex = 4;
            this.persTabPage.Text = "Персонажи";
            this.persTabPage.UseVisualStyleBackColor = true;
            this.persTabPage.Click += new System.EventHandler(this.persTabPage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.diavoloButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.josukeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jonathanButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jonniButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.joshefButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jojoButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.jolinButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 59);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // diavoloButton
            // 
            this.diavoloButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diavoloButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.diavoloButton.Location = new System.Drawing.Point(294, 3);
            this.diavoloButton.Name = "diavoloButton";
            this.diavoloButton.Size = new System.Drawing.Size(91, 53);
            this.diavoloButton.TabIndex = 12;
            this.diavoloButton.Tag = "Diavolo";
            this.diavoloButton.Text = "Дьяволо";
            this.diavoloButton.UseVisualStyleBackColor = true;
            this.diavoloButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // josukeButton
            // 
            this.josukeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.josukeButton.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.josukeButton.Location = new System.Drawing.Point(391, 3);
            this.josukeButton.Name = "josukeButton";
            this.josukeButton.Size = new System.Drawing.Size(91, 53);
            this.josukeButton.TabIndex = 11;
            this.josukeButton.Tag = "Joske";
            this.josukeButton.Text = "Джоске Хигашиката";
            this.josukeButton.UseVisualStyleBackColor = true;
            this.josukeButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // jonathanButton
            // 
            this.jonathanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jonathanButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.jonathanButton.Location = new System.Drawing.Point(197, 3);
            this.jonathanButton.Name = "jonathanButton";
            this.jonathanButton.Size = new System.Drawing.Size(91, 53);
            this.jonathanButton.TabIndex = 10;
            this.jonathanButton.Tag = "Jonatan";
            this.jonathanButton.Text = "Джонатан Джостар";
            this.jonathanButton.UseVisualStyleBackColor = true;
            this.jonathanButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // jonniButton
            // 
            this.jonniButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jonniButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jonniButton.Location = new System.Drawing.Point(3, 3);
            this.jonniButton.Name = "jonniButton";
            this.jonniButton.Size = new System.Drawing.Size(91, 53);
            this.jonniButton.TabIndex = 9;
            this.jonniButton.Tag = "Jonny";
            this.jonniButton.Text = "Джонни Джостар";
            this.jonniButton.UseVisualStyleBackColor = true;
            this.jonniButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // joshefButton
            // 
            this.joshefButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joshefButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.joshefButton.Location = new System.Drawing.Point(682, 3);
            this.joshefButton.Name = "joshefButton";
            this.joshefButton.Size = new System.Drawing.Size(92, 53);
            this.joshefButton.TabIndex = 8;
            this.joshefButton.Tag = "Joseph";
            this.joshefButton.Text = "Джозеф Джостар";
            this.joshefButton.UseVisualStyleBackColor = true;
            this.joshefButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // dioButton
            // 
            this.dioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dioButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dioButton.Location = new System.Drawing.Point(100, 3);
            this.dioButton.Name = "dioButton";
            this.dioButton.Size = new System.Drawing.Size(91, 53);
            this.dioButton.TabIndex = 5;
            this.dioButton.Tag = "Dio";
            this.dioButton.Text = "Дио Брандо";
            this.dioButton.UseVisualStyleBackColor = true;
            this.dioButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // jojoButton
            // 
            this.jojoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jojoButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.jojoButton.Location = new System.Drawing.Point(488, 3);
            this.jojoButton.Name = "jojoButton";
            this.jojoButton.Size = new System.Drawing.Size(91, 53);
            this.jojoButton.TabIndex = 6;
            this.jojoButton.Tag = "Jotaro";
            this.jojoButton.Text = "Джотаро Куджо ";
            this.jojoButton.UseVisualStyleBackColor = true;
            this.jojoButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // jolinButton
            // 
            this.jolinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jolinButton.Font = new System.Drawing.Font("DejaVu Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.jolinButton.Location = new System.Drawing.Point(585, 3);
            this.jolinButton.Name = "jolinButton";
            this.jolinButton.Size = new System.Drawing.Size(91, 53);
            this.jolinButton.TabIndex = 7;
            this.jolinButton.Tag = "Jolin";
            this.jolinButton.Text = "Джолин Куджо";
            this.jolinButton.UseVisualStyleBackColor = true;
            this.jolinButton.Click += new System.EventHandler(this.dioButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(571, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // siteTabPage
            // 
            this.siteTabPage.Controls.Add(this.label3);
            this.siteTabPage.Controls.Add(this.label2);
            this.siteTabPage.Controls.Add(this.pictureBox4);
            this.siteTabPage.Controls.Add(this.pictureBox3);
            this.siteTabPage.Location = new System.Drawing.Point(4, 23);
            this.siteTabPage.Name = "siteTabPage";
            this.siteTabPage.Size = new System.Drawing.Size(777, 324);
            this.siteTabPage.TabIndex = 5;
            this.siteTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "И на эту картинку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(360, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кликни на картинку";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(359, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(360, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(399, 222);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.UseAnimation = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 351);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 351);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ДжоДжо);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "mainForm";
            this.Text = "Аниме программа";
            this.toolTip1.SetToolTip(this, "Я тебе всё написал");
            this.contextMenuStrip1.ResumeLayout(false);
            this.ДжоДжо.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.persTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.siteTabPage.ResumeLayout(false);
            this.siteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl ДжоДжо;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage persTabPage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button jolinButton;
        private System.Windows.Forms.Button jojoButton;
        private System.Windows.Forms.Button dioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button diavoloButton;
        private System.Windows.Forms.Button josukeButton;
        private System.Windows.Forms.Button jonathanButton;
        private System.Windows.Forms.Button jonniButton;
        private System.Windows.Forms.Button joshefButton;
        private System.Windows.Forms.TabPage siteTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

