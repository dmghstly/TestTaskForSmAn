
namespace Task2_MakarovDV
{
    partial class ExportToCSV
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
            this.Export = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DevideElem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.FindDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export.Location = new System.Drawing.Point(407, 187);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(152, 48);
            this.Export.TabIndex = 0;
            this.Export.Text = "Экспорт";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(585, 187);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(152, 48);
            this.Back.TabIndex = 1;
            this.Back.Text = "Вернуться";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Разделитель: ";
            // 
            // DevideElem
            // 
            this.DevideElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevideElem.FormattingEnabled = true;
            this.DevideElem.Items.AddRange(new object[] {
            "Запятая",
            "Точка с запятой",
            "Tab"});
            this.DevideElem.Location = new System.Drawing.Point(166, 22);
            this.DevideElem.Name = "DevideElem";
            this.DevideElem.Size = new System.Drawing.Size(124, 33);
            this.DevideElem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Путь: ";
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path.Location = new System.Drawing.Point(160, 151);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(463, 30);
            this.path.TabIndex = 5;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // FindDir
            // 
            this.FindDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindDir.Location = new System.Drawing.Point(649, 151);
            this.FindDir.Name = "FindDir";
            this.FindDir.Size = new System.Drawing.Size(88, 30);
            this.FindDir.TabIndex = 6;
            this.FindDir.Text = "...";
            this.FindDir.UseVisualStyleBackColor = true;
            this.FindDir.Click += new System.EventHandler(this.FindDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Наименование\r\nфайла: ";
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(168, 87);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(391, 30);
            this.FileName.TabIndex = 8;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // ExportToCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 247);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindDir);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevideElem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Export);
            this.Name = "ExportToCSV";
            this.Text = "Экспорт в CSV ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DevideElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button FindDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileName;
    }
}