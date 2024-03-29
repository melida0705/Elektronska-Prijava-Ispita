﻿using eStud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eStud
{
    /// <summary>
    /// Interaction logic for StudentPotvrdeUverenja.xaml
    /// </summary>
    public partial class StudentPotvrdeUverenja : UserControl
    {
        Student trenutniKorisnik;
        public StudentPotvrdeUverenja(Student trenutniKorisnik)
        {
            InitializeComponent();
            this.trenutniKorisnik = trenutniKorisnik;
            popuni();
        }
        private void popuni()
        {
            tbRazlog.Items.Add("Potvrda o studiranju");
            tbRazlog.Items.Add("Potvrda o polozenim ispitima");
        }
        private void btnPosalji_Click(object sender, RoutedEventArgs e)
        {
            DBController.DodajPotvrdeUverenje(trenutniKorisnik.getUserName(), tbRazlog.Text, tbObrazlozenje.Text);
            MessageBox.Show("Zahtev je poslat");
        }
      

        private void tbObrazlozenje_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch))) || ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
}
