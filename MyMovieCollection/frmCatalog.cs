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
    public partial class frmCatalog : Form
    {
        //Fields and Declarations

        String strInputFile = "movies.txt";
        StreamReader inFile;

        int index = 0;
        int count = 0;
        const int SIZE = 300;

        //Create Arrays for Each Movie Detail Catagory

        string[] movie = new string[SIZE];
        string[] year = new string[SIZE];
        string[] runtime = new string[SIZE];
        string[] rating = new string[SIZE];
        string[] genre = new string[SIZE];
        string[] format = new string[SIZE];

        public frmCatalog()
        {
            InitializeComponent();
        }

        private void frmCatalog_Load(object sender, EventArgs e)
        {
            //declarations

            index = 0;

            //Load File

            ofdOpenFile.ShowDialog();

            strInputFile = ofdOpenFile.FileName;

            try
            {
                inFile = File.OpenText(strInputFile);

            while (index < movie.Length && !inFile.EndOfStream)
            {

                movie[index] = inFile.ReadLine();
                year[index] = inFile.ReadLine();
                runtime[index] = inFile.ReadLine();
                rating[index] = inFile.ReadLine();
                genre[index] = inFile.ReadLine();
                format[index] = inFile.ReadLine();

                //Increases Index for next Iteration

                index++;
            }
            
            //Close the File
            inFile.Close();

            }
            
            catch
            {
                MessageBox.Show("Please Select a Valid File");
                this.Close();
            }



            //Update Labels for First Movie in List

            count = index;

            index = 0;

            lblMovie.Text = movie[0];
            lblYear.Text = year[0];
            lblRuntime.Text = runtime[0];
            lblRating.Text = rating[0];
            lblGenre.Text = genre[0];
            lblFormat.Text = format[0];

            lblIndex.Text = (index + 1) + " of " + count;

            //Change Poster if Available (Must match movie title name or won't be shown)

            try
            {
                picPoster.Image = Image.FromFile("pics/" + movie[0] + ".jpg");
            }

            catch
            {
                picPoster.Image = null;
            }

        }


        private void btnExitCatalog_Click(object sender, EventArgs e)
        {
            //Close the View Catalog Form
            this.Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            //Go to Next Movie in Catalog and Populate Labels from Arrays and Add Poster if Available

            if (index < SIZE)
            {
                //Increases Index for next Iteration
                index++;

                //Update Labels

                lblMovie.Text = movie[index];
                lblYear.Text = year[index];
                lblRuntime.Text = runtime[index];
                lblRating.Text = rating[index];
                lblGenre.Text = genre[index];
                lblFormat.Text = format[index];

                lblIndex.Text = (index + 1) + " of " + count;

                //Change Poster if Available (Must match movie title name or won't be shown)

                try
                {
                    picPoster.Image = Image.FromFile("pics/" + movie[index] + ".jpg");
                }

                catch
                {
                    picPoster.Image = null;
                }
                
            }

            //Enable Previous Button if not on First Item

            if (index > 0)
                btnPrevious.Enabled = true;

            //Show Message if at End of Index

            if (index == count - 1)
            {
                btnNext.Enabled = false;
                MessageBox.Show("You have reached the end of your movie collection!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Go to Previous Movie in Catalog and Populate Labels from Arrays and Add Poster if Available

            if (index >= 0)
            {

                //Decreases Index for next Iteration

                index = index - 1;

                //Update Labels

                lblMovie.Text = movie[index];
                lblYear.Text = year[index];
                lblRuntime.Text = runtime[index];
                lblRating.Text = rating[index];
                lblGenre.Text = genre[index];
                lblFormat.Text = format[index];

                lblIndex.Text = (index + 1) + " of " + count;

                //Change Poster if Available (Must match movie title name or won't be shown)

                try
                {
                    picPoster.Image = Image.FromFile("pics/" + movie[index] + ".jpg");
                }

                catch
                {
                    picPoster.Image = null;
                }

            }


            //Disable Previous Button if at Start of Catalog

            if (index < count - 1)
                btnNext.Enabled = true;



            if (index == 0)
                btnPrevious.Enabled = false;

        }



        private void frmCatalog_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

       
    }
}
