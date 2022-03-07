using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MakarovDV
{
    public partial class DBEditor : Form
    {
        public DBEditor()
        {
            InitializeComponent();
            Program.column = new AllData.CurrentColumn("", "int");
        }

        private void CreateDB_Click(object sender, EventArgs e)
        {
            DBCreation dBCreation = new DBCreation();
            dBCreation.Show();
        }

        private void OpenDB_Click(object sender, EventArgs e)
        {
            DBOpening dBOpening = new DBOpening();
            dBOpening.Show();
        }
    }
}
