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
            DetalladoData.Rows.Clear();
            String entrada = TextoOrigen.Text;
            AnalizadorLexico lex = new AnalizadorLexico();
            LinkedList<Token> ltokens = lex.escanear(entrada);
            foreach(Token token in ltokens)
            {
                DetalladoData.Rows.Add(token.Getval(), token.GetTipo(), token.GetID());
            }
            lex.imprimirListaToken(ltokens);
            TextoCopia.Text = TextoOrigen.Text;
        }
    }
}
