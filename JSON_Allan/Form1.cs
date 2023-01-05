using JSON_Allan.Dados;
using JSON_Allan.Formulário;
using Newtonsoft.Json;
using System.Data;

namespace JSON_Allan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            HeroiRepository.InitializeRepository();
            VisualizarHerois();
        }

        private void VisualizarHerois()
        {
            dataGridView_dados.Rows.Clear();
            foreach(Heroi heroi in HeroiRepository.Herois)
            {
                var rowIndex = dataGridView_dados.Rows.Add();
                dataGridView_dados.Rows[rowIndex].Cells[0].Value = heroi.Id.ToString();
                dataGridView_dados.Rows[rowIndex].Cells[1].Value = heroi.Nome.ToString();
                dataGridView_dados.Rows[rowIndex].Cells[2].Value = heroi.Idade.ToString();
                dataGridView_dados.Rows[rowIndex].Cells[3].Value = heroi.IdentidadeSecreta.ToString();
            }
        }

        /* Adicionar */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HeroiFormulario heroiFormulario= new();
            DialogResult dialogResult = heroiFormulario.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                HeroiRepository.AddHeroi(heroiFormulario.Heroi);
                VisualizarHerois();
            }
        }

        private void pictureBox_lerArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = "c:\\";
            openfileDialog.Filter = "Arquivos JSON (*.json)|*.json;";
            openfileDialog.FilterIndex = 0;
            openfileDialog.RestoreDirectory= true;

            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileJson = openfileDialog.FileName.ToString();
                string fileJson2 = File.ReadAllText(fileJson);
                /* Só para mostrar se o arquivo realmente recebeu o caminho */
                MessageBox.Show(fileJson);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson2, typeof(DataTable));
                dataGridView_dados.DataSource = dt;
                
            }
        }

        private void dataGridView_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_dados.Columns[e.ColumnIndex].Name == "ColunaPoderes")
            {
                MessageBox.Show(HeroiRepository.Herois.ToString());
            }
        }

        /* Apagar */
        private void pictureBox_deleteEntidade_Click(object sender, EventArgs e)
        {
            if(dataGridView_dados.SelectedRows.Count > 0)
            {
                string idHeroi = dataGridView_dados.SelectedRows[0].Cells[0].Value.ToString();
                HeroiRepository.DeleteHeroi(idHeroi);
                VisualizarHerois();
            } else
            {
                MessageBox.Show("Você não selecionou um heroi! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_atualizarEntidade_Click(object sender, EventArgs e)
        {

        }
    }
}