namespace FormsApp
{
    partial class Form1
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
            this.buttonLoadCsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonFormReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadCsv
            // 
            this.buttonLoadCsv.Location = new System.Drawing.Point(129, 322);
            this.buttonLoadCsv.Name = "buttonLoadCsv";
            this.buttonLoadCsv.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadCsv.TabIndex = 0;
            this.buttonLoadCsv.Text = "Загрузить CSV файл";
            this.buttonLoadCsv.UseVisualStyleBackColor = true;
            this.buttonLoadCsv.Click += new System.EventHandler(this.buttonLoadCsv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(426, 321);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(151, 23);
            this.buttonLoadXml.TabIndex = 2;
            this.buttonLoadXml.Text = "Загрузить Xml файл";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonFormReport
            // 
            this.buttonFormReport.Location = new System.Drawing.Point(266, 389);
            this.buttonFormReport.Name = "buttonFormReport";
            this.buttonFormReport.Size = new System.Drawing.Size(179, 23);
            this.buttonFormReport.TabIndex = 3;
            this.buttonFormReport.Text = "Сформировать отчет";
            this.buttonFormReport.UseVisualStyleBackColor = true;
            this.buttonFormReport.Click += new System.EventHandler(this.buttonFormReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFormReport);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadCsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonFormReport;
    }
}

