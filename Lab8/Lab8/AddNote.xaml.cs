﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab8
{
    /// <summary>
    /// Logika interakcji dla klasy AddNote.xaml
    /// </summary>
    public partial class AddNote : Window
    {
        public Note note = new Note();

        public AddNote()
        {
            InitializeComponent();
        }

        private void add_ok_button_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(grade_tb.Text, @"^[2-5](,[05])?$") ||
                !Regex.IsMatch(date_tb.Text, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$") ||
                !Regex.IsMatch(subject_tb.Text, @"^[a-z]{1,30}$")
                )
            {
                MessageBox.Show("Podane dane są błędne");
            }
            else
            {
                note.Grade = double.Parse(grade_tb.Text);
                note.Date = date_tb.Text;
                note.Subject = subject_tb.Text;
                this.DialogResult = true;
            }
        }
    }
}
