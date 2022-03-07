
namespace Task2_MakarovDV
{
    partial class ColumnConstruct
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
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeName = new System.Windows.Forms.ComboBox();
            this.IsPrimaryKey = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // ColumnName
            // 
            this.ColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnName.Location = new System.Drawing.Point(90, 10);
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Size = new System.Drawing.Size(184, 30);
            this.ColumnName.TabIndex = 1;
            this.ColumnName.TextChanged += new System.EventHandler(this.ColumnName_TextChanged);
            this.ColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColumnName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // TypeName
            // 
            this.TypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeName.FormattingEnabled = true;
            this.TypeName.Items.AddRange(new object[] {
            "целочисленный",
            "вещественный",
            "текстовый",
            "дата/время"});
            this.TypeName.Location = new System.Drawing.Point(90, 74);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(184, 33);
            this.TypeName.TabIndex = 3;
            // 
            // IsPrimaryKey
            // 
            this.IsPrimaryKey.AutoSize = true;
            this.IsPrimaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsPrimaryKey.Location = new System.Drawing.Point(55, 130);
            this.IsPrimaryKey.Name = "IsPrimaryKey";
            this.IsPrimaryKey.Size = new System.Drawing.Size(191, 29);
            this.IsPrimaryKey.TabIndex = 5;
            this.IsPrimaryKey.Text = "Первичный ключ";
            this.IsPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(12, 177);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 46);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Abort
            // 
            this.Abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Abort.Location = new System.Drawing.Point(156, 177);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(131, 46);
            this.Abort.TabIndex = 7;
            this.Abort.Text = "Отмена";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // ColumnConstruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 235);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.IsPrimaryKey);
            this.Controls.Add(this.TypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColumnName);
            this.Controls.Add(this.label1);
            this.Name = "ColumnConstruct";
            this.Text = "Поле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeName;
        private System.Windows.Forms.CheckBox IsPrimaryKey;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Abort;
    }
}