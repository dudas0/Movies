using System.Drawing;
using System.Windows.Forms;

namespace ProjectMovieThisIsIt
{
    partial class ListOfMovies
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
            this.searchLabel1 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.myListView = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reżyser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ocena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseSorting = new System.Windows.Forms.ComboBox();
            this.Choice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.myRatecomboBox = new System.Windows.Forms.ComboBox();
            this.przywitanie = new System.Windows.Forms.Label();
            this.ThanksForVoting = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.Location = new System.Drawing.Point(44, 43);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(71, 13);
            this.searchLabel1.TabIndex = 1;
            this.searchLabel1.Text = "Wyszukaj film";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(143, 40);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 20);
            this.searchTxt.TabIndex = 2;
            // 
            // myListView
            // 
            this.myListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Reżyser,
            this.Rok,
            this.Ocena});
            this.myListView.FullRowSelect = true;
            this.myListView.Location = new System.Drawing.Point(12, 83);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(483, 287);
            this.myListView.TabIndex = 3;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Tytuł";
            this.Nazwa.Width = 151;
            // 
            // Reżyser
            // 
            this.Reżyser.Text = "Reżyser";
            this.Reżyser.Width = 128;
            // 
            // Rok
            // 
            this.Rok.Text = "Rok";
            this.Rok.Width = 58;
            // 
            // Ocena
            // 
            this.Ocena.Text = "Ocena";
            this.Ocena.Width = 52;
            // 
            // chooseSorting
            // 
            this.chooseSorting.FormattingEnabled = true;
            this.chooseSorting.Items.AddRange(new object[] {
            "Nazwie filmu - alfabetycznie",
            "Ocenie"});
            this.chooseSorting.Location = new System.Drawing.Point(297, 40);
            this.chooseSorting.Name = "chooseSorting";
            this.chooseSorting.Size = new System.Drawing.Size(121, 21);
            this.chooseSorting.TabIndex = 5;
            this.chooseSorting.Text = "Sortuj po :";
            this.chooseSorting.SelectedIndexChanged += new System.EventHandler(this.chooseSorting_SelectedIndexChanged);
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.Location = new System.Drawing.Point(658, 64);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(0, 13);
            this.Choice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 16;
            // 
            // myRatecomboBox
            // 
            this.myRatecomboBox.FormattingEnabled = true;
            this.myRatecomboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.myRatecomboBox.Location = new System.Drawing.Point(661, 285);
            this.myRatecomboBox.Name = "myRatecomboBox";
            this.myRatecomboBox.Size = new System.Drawing.Size(125, 21);
            this.myRatecomboBox.TabIndex = 20;
            this.myRatecomboBox.Text = "Wybierz ocene";
            this.myRatecomboBox.Visible = false;
            this.myRatecomboBox.SelectedIndexChanged += new System.EventHandler(this.myRatecomboBox_SelectedIndexChanged);
            this.myRatecomboBox.SelectionChangeCommitted += new System.EventHandler(this.myRatecomboBox_SelectedIndexChanged);
            // 
            // przywitanie
            // 
            this.przywitanie.AutoSize = true;
            this.przywitanie.Location = new System.Drawing.Point(208, 9);
            this.przywitanie.Name = "przywitanie";
            this.przywitanie.Size = new System.Drawing.Size(35, 13);
            this.przywitanie.TabIndex = 22;
            this.przywitanie.Text = "label5";
            // 
            // ThanksForVoting
            // 
            this.ThanksForVoting.AutoSize = true;
            this.ThanksForVoting.Location = new System.Drawing.Point(617, 293);
            this.ThanksForVoting.Name = "ThanksForVoting";
            this.ThanksForVoting.Size = new System.Drawing.Size(0, 13);
            this.ThanksForVoting.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(847, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(833, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 27;
            // 
            // ListOfMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 472);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ThanksForVoting);
            this.Controls.Add(this.przywitanie);
            this.Controls.Add(this.myRatecomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.chooseSorting);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchLabel1);
            this.Name = "ListOfMovies";
            this.Text = "myForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchLabel1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ListView myListView;
        private ColumnHeader Nazwa;
        private ColumnHeader Reżyser;
        private ColumnHeader Rok;
        private ColumnHeader Ocena;
        private ComboBox chooseSorting;
        private Label Choice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox myRatecomboBox;
        private Label przywitanie;
        private Label ThanksForVoting;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}