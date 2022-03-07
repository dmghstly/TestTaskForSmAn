
namespace Task2_MakarovDV
{
    partial class DBOpening
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
            this.SelectDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectDB
            // 
            this.SelectDB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SelectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDB.FormattingEnabled = true;
            this.SelectDB.Location = new System.Drawing.Point(46, 68);
            this.SelectDB.Name = "SelectDB";
            this.SelectDB.Size = new System.Drawing.Size(402, 33);
            this.SelectDB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете БД:";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(478, 59);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(146, 48);
            this.Open.TabIndex = 3;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // DBOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 132);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectDB);
            this.Name = "DBOpening";
            this.Text = "Получить доступ к БД";
            this.Load += new System.EventHandler(this.DBOpening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open;
    }
}