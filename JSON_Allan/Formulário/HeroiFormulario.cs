using JSON_Allan.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Allan.Formulário
{
    public partial class HeroiFormulario : Form
    {
        public Heroi Heroi { get; private set; }
        public HeroiFormulario()
        {
            InitializeComponent();
        }

        public HeroiFormulario(Heroi heroi)
        {
            InitializeComponent();
            textBox_ID.Text = heroi.Id;
            textBox_Nome.Text = heroi.Nome;
            textBox_Idade.Text = heroi.Idade.ToString();
            textBox_IdentidadeSecreta.Text = heroi.IdentidadeSecreta;
            textBox_Poderes.Text = heroi.Poderes.ToString();

        }

        private void label_IdHeroi_Click(object sender, EventArgs e)
        {

        }

        private void button_salvarHeroi_Click(object sender, EventArgs e)
        {
            bool heroiValido = ValidarHeroi(out string errorMsg);
            if (heroiValido)
            {
                Heroi = new Heroi(textBox_ID.Text, textBox_Nome.Text, Convert.ToDouble(textBox_Idade.Text), guid(textBox_IdentidadeSecreta.Text), textBox_Poderes.Text.Split(',').ToList());
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show(errorMsg, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /* Validação do Herói */
        private bool ValidarHeroi(out string errorMsg)
        {
            errorMsg = string.Empty;
            if (string.IsNullOrEmpty(textBox_ID.Text))
            {
                errorMsg += "O ID do herói não pode estar vazio! " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(textBox_Nome.Text))
            {
                errorMsg += "O nome do herói não pode estar vazio! " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(textBox_Idade.Text))
            {
                errorMsg += "A idade do herói não pode estar vazio! " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(textBox_IdentidadeSecreta.Text))
            {
                errorMsg += "A identidade secreta do herói não pode estar vazio! " + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(textBox_Nome.Text))
            {
                errorMsg += "Os poderes do herói não pode estar vazio! " + Environment.NewLine;
            }
            bool idadeOk = double.TryParse(textBox_Idade.Text, out double idade);
            
            if (!idadeOk)
            {
                errorMsg += "A idade do herói precisa ser um número! " + Environment.NewLine;
            }
            return errorMsg == String.Empty;
        }

        /* GUID */
        private string guid(string input)
        {
            string newGUID = Guid.NewGuid().ToString();
            input = newGUID;
            return input;
        }
    }
}
