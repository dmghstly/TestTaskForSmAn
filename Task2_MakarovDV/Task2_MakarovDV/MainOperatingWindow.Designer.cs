
namespace Task2_MakarovDV
{
    partial class MainOperatingWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToCSV = new System.Windows.Forms.Button();
            this.DeleteTable = new System.Windows.Forms.Button();
            this.EditTable = new System.Windows.Forms.Button();
            this.NewTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTable = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новваяБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataUpdate = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.TableData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EditData = new System.Windows.Forms.Button();
            this.TableStructure = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToCSV);
            this.groupBox1.Controls.Add(this.DeleteTable);
            this.groupBox1.Controls.Add(this.EditTable);
            this.groupBox1.Controls.Add(this.NewTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор таблицы";
            // 
            // ToCSV
            // 
            this.ToCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToCSV.Location = new System.Drawing.Point(6, 300);
            this.ToCSV.Name = "ToCSV";
            this.ToCSV.Size = new System.Drawing.Size(231, 38);
            this.ToCSV.TabIndex = 5;
            this.ToCSV.Text = "Экспортировать в .csv";
            this.ToCSV.UseVisualStyleBackColor = true;
            this.ToCSV.Click += new System.EventHandler(this.ToCSV_Click);
            // 
            // DeleteTable
            // 
            this.DeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTable.Location = new System.Drawing.Point(6, 237);
            this.DeleteTable.Name = "DeleteTable";
            this.DeleteTable.Size = new System.Drawing.Size(231, 38);
            this.DeleteTable.TabIndex = 4;
            this.DeleteTable.Text = "Удалить таблицу";
            this.DeleteTable.UseVisualStyleBackColor = true;
            this.DeleteTable.Click += new System.EventHandler(this.DeleteTable_Click);
            // 
            // EditTable
            // 
            this.EditTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTable.Location = new System.Drawing.Point(6, 178);
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(231, 38);
            this.EditTable.TabIndex = 3;
            this.EditTable.Text = "Редактировать таблицу";
            this.EditTable.UseVisualStyleBackColor = true;
            this.EditTable.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // NewTable
            // 
            this.NewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTable.Location = new System.Drawing.Point(6, 118);
            this.NewTable.Name = "NewTable";
            this.NewTable.Size = new System.Drawing.Size(231, 38);
            this.NewTable.TabIndex = 2;
            this.NewTable.Text = "Новая таблица";
            this.NewTable.UseVisualStyleBackColor = true;
            this.NewTable.Click += new System.EventHandler(this.NewTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица";
            // 
            // SelectTable
            // 
            this.SelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTable.FormattingEnabled = true;
            this.SelectTable.Location = new System.Drawing.Point(6, 73);
            this.SelectTable.Name = "SelectTable";
            this.SelectTable.Size = new System.Drawing.Size(231, 24);
            this.SelectTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новваяБДToolStripMenuItem,
            this.открытьБДToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новваяБДToolStripMenuItem
            // 
            this.новваяБДToolStripMenuItem.Name = "новваяБДToolStripMenuItem";
            this.новваяБДToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.новваяБДToolStripMenuItem.Text = "Новая БД";
            this.новваяБДToolStripMenuItem.Click += new System.EventHandler(this.новваяБДToolStripMenuItem_Click);
            // 
            // открытьБДToolStripMenuItem
            // 
            this.открытьБДToolStripMenuItem.Name = "открытьБДToolStripMenuItem";
            this.открытьБДToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.открытьБДToolStripMenuItem.Text = "Открыть БД";
            this.открытьБДToolStripMenuItem.Click += new System.EventHandler(this.открытьБДToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(261, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование таблиц";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataUpdate);
            this.groupBox4.Controls.Add(this.SaveChanges);
            this.groupBox4.Controls.Add(this.TableData);
            this.groupBox4.Location = new System.Drawing.Point(232, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 356);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактировать данные";
            // 
            // DataUpdate
            // 
            this.DataUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataUpdate.Location = new System.Drawing.Point(361, 312);
            this.DataUpdate.Name = "DataUpdate";
            this.DataUpdate.Size = new System.Drawing.Size(139, 38);
            this.DataUpdate.TabIndex = 6;
            this.DataUpdate.Text = "Сброс";
            this.DataUpdate.UseVisualStyleBackColor = true;
            this.DataUpdate.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(216, 312);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(139, 38);
            this.SaveChanges.TabIndex = 5;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // TableData
            // 
            this.TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableData.Location = new System.Drawing.Point(7, 28);
            this.TableData.Name = "TableData";
            this.TableData.RowHeadersWidth = 51;
            this.TableData.RowTemplate.Height = 24;
            this.TableData.Size = new System.Drawing.Size(493, 278);
            this.TableData.TabIndex = 0;
            this.TableData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableData_DataError);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditData);
            this.groupBox3.Controls.Add(this.TableStructure);
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Таблица: ";
            // 
            // EditData
            // 
            this.EditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditData.Location = new System.Drawing.Point(6, 121);
            this.EditData.Name = "EditData";
            this.EditData.Size = new System.Drawing.Size(208, 38);
            this.EditData.TabIndex = 8;
            this.EditData.Text = "Редактировать данные";
            this.EditData.UseVisualStyleBackColor = true;
            this.EditData.Click += new System.EventHandler(this.EditData_Click);
            // 
            // TableStructure
            // 
            this.TableStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableStructure.Location = new System.Drawing.Point(6, 52);
            this.TableStructure.Name = "TableStructure";
            this.TableStructure.Size = new System.Drawing.Size(208, 38);
            this.TableStructure.TabIndex = 7;
            this.TableStructure.Text = "Конструктор таблицы";
            this.TableStructure.UseVisualStyleBackColor = true;
            this.TableStructure.Click += new System.EventHandler(this.TableStructure_Click);
            // 
            // MainOperatingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainOperatingWindow";
            this.Text = "Редактор БД";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteTable;
        private System.Windows.Forms.Button EditTable;
        private System.Windows.Forms.Button NewTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новваяБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button DataUpdate;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.DataGridView TableData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button EditData;
        private System.Windows.Forms.Button TableStructure;
        private System.Windows.Forms.Button ToCSV;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}