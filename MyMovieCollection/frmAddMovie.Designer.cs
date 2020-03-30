namespace MyMovieCollection
{
    partial class frmAddMovie
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radRatingOne = new System.Windows.Forms.RadioButton();
            this.radRatingTwo = new System.Windows.Forms.RadioButton();
            this.radRatingFour = new System.Windows.Forms.RadioButton();
            this.radRatingThree = new System.Windows.Forms.RadioButton();
            this.radRatingFive = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.chkComedy = new System.Windows.Forms.CheckBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.chkSeries = new System.Windows.Forms.CheckBox();
            this.chkDrama = new System.Windows.Forms.CheckBox();
            this.chkSciFi = new System.Windows.Forms.CheckBox();
            this.chkHorror = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExitAddMovies = new System.Windows.Forms.Button();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(258, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(12, 110);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(67, 20);
            this.txtYear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Runtime (minutes)";
            // 
            // txtRuntime
            // 
            this.txtRuntime.Location = new System.Drawing.Point(112, 110);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(50, 20);
            this.txtRuntime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rating";
            // 
            // radRatingOne
            // 
            this.radRatingOne.AutoSize = true;
            this.radRatingOne.Location = new System.Drawing.Point(18, 178);
            this.radRatingOne.Name = "radRatingOne";
            this.radRatingOne.Size = new System.Drawing.Size(32, 17);
            this.radRatingOne.TabIndex = 7;
            this.radRatingOne.TabStop = true;
            this.radRatingOne.Text = "1";
            this.radRatingOne.UseVisualStyleBackColor = true;
            // 
            // radRatingTwo
            // 
            this.radRatingTwo.AutoSize = true;
            this.radRatingTwo.Location = new System.Drawing.Point(69, 178);
            this.radRatingTwo.Name = "radRatingTwo";
            this.radRatingTwo.Size = new System.Drawing.Size(32, 17);
            this.radRatingTwo.TabIndex = 8;
            this.radRatingTwo.TabStop = true;
            this.radRatingTwo.Text = "2";
            this.radRatingTwo.UseVisualStyleBackColor = true;
            // 
            // radRatingFour
            // 
            this.radRatingFour.AutoSize = true;
            this.radRatingFour.Location = new System.Drawing.Point(181, 178);
            this.radRatingFour.Name = "radRatingFour";
            this.radRatingFour.Size = new System.Drawing.Size(32, 17);
            this.radRatingFour.TabIndex = 10;
            this.radRatingFour.TabStop = true;
            this.radRatingFour.Text = "4";
            this.radRatingFour.UseVisualStyleBackColor = true;
            // 
            // radRatingThree
            // 
            this.radRatingThree.AutoSize = true;
            this.radRatingThree.Location = new System.Drawing.Point(125, 178);
            this.radRatingThree.Name = "radRatingThree";
            this.radRatingThree.Size = new System.Drawing.Size(32, 17);
            this.radRatingThree.TabIndex = 9;
            this.radRatingThree.TabStop = true;
            this.radRatingThree.Text = "3";
            this.radRatingThree.UseVisualStyleBackColor = true;
            // 
            // radRatingFive
            // 
            this.radRatingFive.AutoSize = true;
            this.radRatingFive.Location = new System.Drawing.Point(237, 178);
            this.radRatingFive.Name = "radRatingFive";
            this.radRatingFive.Size = new System.Drawing.Size(32, 17);
            this.radRatingFive.TabIndex = 11;
            this.radRatingFive.TabStop = true;
            this.radRatingFive.Text = "5";
            this.radRatingFive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // chkComedy
            // 
            this.chkComedy.AutoSize = true;
            this.chkComedy.Location = new System.Drawing.Point(18, 250);
            this.chkComedy.Name = "chkComedy";
            this.chkComedy.Size = new System.Drawing.Size(70, 17);
            this.chkComedy.TabIndex = 13;
            this.chkComedy.Text = "Comedy";
            this.chkComedy.UseVisualStyleBackColor = true;
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.Location = new System.Drawing.Point(100, 251);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(62, 17);
            this.chkAction.TabIndex = 14;
            this.chkAction.Text = "Action";
            this.chkAction.UseVisualStyleBackColor = true;
            // 
            // chkSeries
            // 
            this.chkSeries.AutoSize = true;
            this.chkSeries.Location = new System.Drawing.Point(204, 273);
            this.chkSeries.Name = "chkSeries";
            this.chkSeries.Size = new System.Drawing.Size(61, 17);
            this.chkSeries.TabIndex = 15;
            this.chkSeries.Text = "Series";
            this.chkSeries.UseVisualStyleBackColor = true;
            // 
            // chkDrama
            // 
            this.chkDrama.AutoSize = true;
            this.chkDrama.Location = new System.Drawing.Point(18, 273);
            this.chkDrama.Name = "chkDrama";
            this.chkDrama.Size = new System.Drawing.Size(62, 17);
            this.chkDrama.TabIndex = 16;
            this.chkDrama.Text = "Drama";
            this.chkDrama.UseVisualStyleBackColor = true;
            // 
            // chkSciFi
            // 
            this.chkSciFi.AutoSize = true;
            this.chkSciFi.Location = new System.Drawing.Point(204, 251);
            this.chkSciFi.Name = "chkSciFi";
            this.chkSciFi.Size = new System.Drawing.Size(58, 17);
            this.chkSciFi.TabIndex = 17;
            this.chkSciFi.Text = "Sci-Fi";
            this.chkSciFi.UseVisualStyleBackColor = true;
            // 
            // chkHorror
            // 
            this.chkHorror.AutoSize = true;
            this.chkHorror.Location = new System.Drawing.Point(100, 274);
            this.chkHorror.Name = "chkHorror";
            this.chkHorror.Size = new System.Drawing.Size(61, 17);
            this.chkHorror.TabIndex = 18;
            this.chkHorror.Text = "Horror";
            this.chkHorror.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExitAddMovies
            // 
            this.btnExitAddMovies.Location = new System.Drawing.Point(183, 438);
            this.btnExitAddMovies.Name = "btnExitAddMovies";
            this.btnExitAddMovies.Size = new System.Drawing.Size(87, 23);
            this.btnExitAddMovies.TabIndex = 23;
            this.btnExitAddMovies.Text = "Exit";
            this.btnExitAddMovies.UseVisualStyleBackColor = true;
            this.btnExitAddMovies.Click += new System.EventHandler(this.btnExitAddMovies_Click);
            // 
            // cmbFormat
            // 
            this.cmbFormat.BackColor = System.Drawing.Color.White;
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "Video File",
            "DVD",
            "Blu-ray",
            "VHS",
            "Other"});
            this.cmbFormat.Location = new System.Drawing.Point(18, 355);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(140, 21);
            this.cmbFormat.TabIndex = 24;
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 474);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.btnExitAddMovies);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkHorror);
            this.Controls.Add(this.chkSciFi);
            this.Controls.Add(this.chkDrama);
            this.Controls.Add(this.chkSeries);
            this.Controls.Add(this.chkAction);
            this.Controls.Add(this.chkComedy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radRatingFive);
            this.Controls.Add(this.radRatingFour);
            this.Controls.Add(this.radRatingThree);
            this.Controls.Add(this.radRatingTwo);
            this.Controls.Add(this.radRatingOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddMovie";
            this.Text = "Add Movie to Catalog";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radRatingOne;
        private System.Windows.Forms.RadioButton radRatingTwo;
        private System.Windows.Forms.RadioButton radRatingFour;
        private System.Windows.Forms.RadioButton radRatingThree;
        private System.Windows.Forms.RadioButton radRatingFive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkComedy;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.CheckBox chkSeries;
        private System.Windows.Forms.CheckBox chkDrama;
        private System.Windows.Forms.CheckBox chkSciFi;
        private System.Windows.Forms.CheckBox chkHorror;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExitAddMovies;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}