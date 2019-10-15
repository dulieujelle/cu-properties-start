using AutoVoorbeeld.Lib;
using System;
using System.Collections.Generic;
using System.Windows;

namespace AutoVoorbeeld.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Auto> lijstAutos;
        Auto geselecteerdeAuto;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lijstAutos = new List<Auto>();
        }

        private void BtnVoegAutoToe_Click(object sender, RoutedEventArgs e)
        {
            string kleurAuto = txtKleur.Text;
            string merkAuto = txtAutoMerk.Text;
            decimal prijsAuto = Convert.ToDecimal(txtPrijs.Text);

            Auto nieuweAuto = new Auto();
            nieuweAuto.kleur = kleurAuto;
            nieuweAuto.merk = merkAuto;
            nieuweAuto.prijs = prijsAuto;

            // OF via constructor:
            //Auto nieuweAuto = new Auto(merkAuto, kleurAuto, prijsAuto);

            lijstAutos.Add(nieuweAuto);
            UpdateAutoLijst();
        }

        private void UpdateAutoLijst()
        {
            lstAutos.Items.Clear();
            foreach (Auto auto in lijstAutos)
            {
                lstAutos.Items.Add(auto);
            }
        }

        private void LstAutos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Auto geselecteerdeAuto = (Auto)lstAutos.SelectedItem;

            txtAutoMerk.Text = geselecteerdeAuto.merk;
            txtKleur.Text = geselecteerdeAuto.kleur;
            txtPrijs.Text = geselecteerdeAuto.prijs.ToString();
        }
    }
}
