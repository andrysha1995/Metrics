namespace Metrics
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextCode = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методХолстедаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методМаккейбаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextAnalyzeCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextCode
            // 
            this.TextCode.Location = new System.Drawing.Point(0, 27);
            this.TextCode.Multiline = true;
            this.TextCode.Name = "TextCode";
            this.TextCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextCode.Size = new System.Drawing.Size(773, 207);
            this.TextCode.TabIndex = 1;
            this.TextCode.TextChanged += new System.EventHandler(this.TextCode_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методХолстедаToolStripMenuItem,
            this.методМаккейбаToolStripMenuItem});
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // методХолстедаToolStripMenuItem
            // 
            this.методХолстедаToolStripMenuItem.Name = "методХолстедаToolStripMenuItem";
            this.методХолстедаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.методХолстедаToolStripMenuItem.Text = "Метод Холстеда";
            this.методХолстедаToolStripMenuItem.Click += new System.EventHandler(this.методХолстедаToolStripMenuItem_Click);
            // 
            // методМаккейбаToolStripMenuItem
            // 
            this.методМаккейбаToolStripMenuItem.Name = "методМаккейбаToolStripMenuItem";
            this.методМаккейбаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.методМаккейбаToolStripMenuItem.Text = "Метод Маккейба";
            // 
            // TextAnalyzeCode
            // 
            this.TextAnalyzeCode.Location = new System.Drawing.Point(0, 240);
            this.TextAnalyzeCode.Multiline = true;
            this.TextAnalyzeCode.Name = "TextAnalyzeCode";
            this.TextAnalyzeCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextAnalyzeCode.Size = new System.Drawing.Size(773, 169);
            this.TextAnalyzeCode.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 406);
            this.Controls.Add(this.TextAnalyzeCode);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Анализатор кода";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методХолстедаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методМаккейбаToolStripMenuItem;
        private System.Windows.Forms.TextBox TextAnalyzeCode;
    }
}

