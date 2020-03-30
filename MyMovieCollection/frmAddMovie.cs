using System.IO;
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
    public partial class frmAddMovie : Form
    {

        //declarations and variables

        Boolean blnDoNotSave = false;

        String strRating = "";
        String strGenre = "";

        String strComedy = "";
        String strAction = "";
        String strSciFi = "";
        String strDrama = "";
        String strHorror = "";
        String strSeries = "";


        StreamWriter catalog;
        String strCatalogFile = "";


        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            //Set Default Selection for Format
            cmbFormat.SelectedIndex = 0;
        }


        //Close Add Movie Form

        private void btnExitAddMovies_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save Movie and Details into Catalog

        private void btnSave_Click(object sender, EventArgs e)
        {


            //Show Message if no Title is entered
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please Enter a Movie Title!");
                blnDoNotSave = true;
            }


            //Show Message if no Year is entered
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please Enter a Year!");
                blnDoNotSave = true;
            }


            //Show Message if no Runtime is entered
            if (txtRuntime.Text == "")
            {
                MessageBox.Show("Please Enter a Runtime!");
                blnDoNotSave = true;
            }


            //Convert Rating Selection into String Variable strRating; Show Message if Rating not selected.

            if (radRatingOne.Checked == true)
                strRating = "1";
            else if (radRatingTwo.Checked == true)
                strRating = "2";
            else if (radRatingThree.Checked == true)
                strRating = "3";
            else if (radRatingFour.Checked == true)
                strRating = "4";
            else if (radRatingFive.Checked == true)
                strRating = "5";
            else
            {
                MessageBox.Show("Please Select a Rating!");
                blnDoNotSave = true;
            }

            //Convert Genre Selection into String Variable strGenre; Show Message if Genere not selected.

            if (chkComedy.Checked == true)
            {
                strComedy = "Comedy ";
            }
           
            if (chkAction.Checked == true)
            {
                strAction = "Action ";
            }
          
            if (chkSciFi.Checked == true)
            {
                strSciFi = "Sci-Fi ";
            }
          
            if (chkDrama.Checked == true)
            {
                strDrama = "Drama ";
            }
            
            if (chkHorror.Checked == true)
            {
                strHorror = "Horror ";
            }
            
            if (chkSeries.Checked == true)
            {
                strSeries= "Series ";
            }
            
            if ((chkComedy.Checked == false)&&(chkAction.Checked == false)&&(chkSciFi.Checked == false)&&(chkDrama.Checked == false)&&(chkHorror.Checked == false)&&(chkSeries.Checked == false))
            {
                MessageBox.Show("Please Select at least one Genre!");
                blnDoNotSave = true;
            }

            strGenre = strComedy + strAction + strSciFi + strDrama + strHorror + strSeries;


            //Executive Write to File code if DoNotSave has not been tripped.

            if (blnDoNotSave == false)
            {

                //Open Movies File

                saveFileDialog.ShowDialog();
                //MessageBox.Show(saveFileDialog.FileName);
                strCatalogFile = saveFileDialog.FileName;

                catalog = File.AppendText(strCatalogFile);

                //Write to Movies File

                catalog.WriteLine(txtTitle.Text);
                catalog.WriteLine(txtYear.Text);
                catalog.WriteLine(txtRuntime.Text);
                catalog.WriteLine(strRating);
                catalog.WriteLine(strGenre);
                catalog.WriteLine(cmbFormat.SelectedItem);

                //Close Catalog File
                catalog.Close();

                //Close Add Movie Form
                this.Close();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset Form Lables and Variables

            blnDoNotSave = false;

            strRating = "";
            strGenre = "";

            strComedy = "";
            strAction = "";
            strSciFi = "";
            strDrama = "";
            strHorror = "";
            strSeries = "";

            txtTitle.Text = "";
            txtYear.Text = "";
            txtRuntime.Text = "";

            radRatingOne.Checked = false;
            radRatingTwo.Checked = false;
            radRatingThree.Checked = false;
            radRatingFour.Checked = false;
            radRatingFive.Checked = false;

            chkComedy.Checked = false;
            chkAction.Checked = false;
            chkSciFi.Checked = false;
            chkDrama.Checked = false;
            chkHorror.Checked = false;
            chkSeries.Checked = false;

            cmbFormat.SelectedIndex = 0;

        }


    }
}
