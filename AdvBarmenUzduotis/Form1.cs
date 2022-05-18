﻿using AdvBarmenUzduotis.repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvBarmenUzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxFirstTableOutput.Clear();
            TextBoxFirstTablePriceOutput.Clear();

            Product food = new Food();
            Product drink = new Drink();
            var foodArray = food.ReturnValue();
            var drinksArray = drink.ReturnValue();

            for (int i = 0; i < foodArray.Length; i+=2)
            {
                TextBoxFirstTableOutput.Text += $"{foodArray[i]} Kiekis: {numericUpDown1FirstTable.Value}\r\n";
            }
            for (int i = 1; i < foodArray.Length; i += 2)
            {
                var foodPrices = drinksArray[i];
                var result = Convert.ToDecimal(foodPrices) * numericUpDown1FirstTable.Value;
                TextBoxFirstTablePriceOutput.Text += $"{foodArray[i]} Eur\r\n";
            }

            for (int i = 0; i < drinksArray.Length; i += 2)
            {
                TextBoxFirstTableOutput.Text += $"{drinksArray[i]} Kiekis: {numericUpDown1FirstTable.Value}\r\n";
            }
            for (int i = 1; i < drinksArray.Length; i += 2)
            {
                var drinksPrices = drinksArray[i];
                var result = Convert.ToDecimal(drinksPrices) * numericUpDown1FirstTable.Value;
                TextBoxFirstTablePriceOutput.Text += $"{result.ToString()} Eur\r\n";
            }
        }
    }
}
