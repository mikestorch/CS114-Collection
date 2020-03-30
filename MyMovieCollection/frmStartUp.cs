using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMovieCollection
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }


        //Open Form to Add Movies to Catalog Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMovie add = new frmAddMovie();
            add.ShowDialog();
        }


        //Open Form to View Movies in Catalog Button

        private void btnView_Click(object sender, EventArgs e)
        {
            frmCatalog catalog = new frmCatalog();
            catalog.ShowDialog();
        }


        //Exit Entire Program

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
