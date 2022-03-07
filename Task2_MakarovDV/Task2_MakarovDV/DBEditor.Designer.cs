
namespace Task2_MakarovDV
{
    partial class DBEditor
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
            this.CreateDB = new System.Windows.Forms.Button();
            this.OpenDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDB
            // 
            this.CreateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDB.Location = new System.Drawing.Point(36, 35);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(253, 76);
            this.CreateDB.TabIndex = 0;
            this.CreateDB.Text = "Создать БД";
            this.CreateDB.UseVisualStyleBackColor = true;
            this.CreateDB.Click += new System.EventHandler(this.CreateDB_Click);
            // 
            // OpenDB
            // 
            this.OpenDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenDB.Location = new System.Drawing.Point(36, 161);
            this.OpenDB.Name = "OpenDB";
            this.OpenDB.Size = new System.Drawing.Size(253, 76);
            this.OpenDB.TabIndex = 1;
            this.OpenDB.Text = "Открыть БД";
            this.OpenDB.UseVisualStyleBackColor = true;
            this.OpenDB.Click += new System.EventHandler(this.OpenDB_Click);
            // 
            // DBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 286);
            this.Controls.Add(this.OpenDB);
            this.Controls.Add(this.CreateDB);
            this.Name = "DBEditor";
            this.Text = "Редактор БД";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDB;
        private System.Windows.Forms.Button OpenDB;
    }
}

