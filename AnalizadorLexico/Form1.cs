using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSeparar_Click(object sender, EventArgs e)
        {
            DetalladoGrid.Rows.Clear();
            TextoCopia.Text = TextoOrigen.Text;
            string phrase = TextoOrigen.Text;
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                DetalladoGrid.Rows.Add(word);
            }
        }
    }
}
