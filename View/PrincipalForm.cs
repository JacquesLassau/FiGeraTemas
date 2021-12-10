using FIGeraTemas.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace FIGeraTemas.View
{
    public partial class PrincipalForm : Form
    {
        private Diretorio _diretorio;
        private Arquivo _arquivo;
        private OpenFileDialog _openFileDialog;
        private FolderBrowserDialog _folderBrowserDialog;

        public PrincipalForm()
        {
            InitializeComponent();

            _diretorio = new Diretorio();
            _arquivo = new Arquivo();
            _openFileDialog = new OpenFileDialog();
            _folderBrowserDialog = new FolderBrowserDialog();
        }

        /// <summary>
        /// Evento de click do do Botão "Pesquisar"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        /// <returns></returns>
        private void btnPesquisaDiretorioRaiz_Click(object sender, EventArgs e)
        {               
            DialogResult result = _folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _diretorio.DiretorioRaiz = _folderBrowserDialog.SelectedPath;
                txtPesquisaDiretorioRaiz.Text = _diretorio.DiretorioRaiz;
            } 
            else
                MessageBox.Show(string.Format("Houve um problema inesperado. Por favor, tente novamente."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Evento de click do Botão "ADICIONAR"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        /// <returns></returns>
        private void btnNovaPasta_Click(object sender, EventArgs e)
        {
            try
            {                
                _diretorio.DiretorioRaiz = txtPesquisaDiretorioRaiz.Text;

                if (string.IsNullOrWhiteSpace(_diretorio.DiretorioRaiz))
                    MessageBox.Show(string.Format("Por favor, selecione um diretório raiz antes de criar uma pasta."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (string.IsNullOrWhiteSpace(txtNovaPasta.Text))
                    MessageBox.Show(string.Format("Por favor, preencha o nome da pasta que deseja criar."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    _diretorio.DiretorioCompleto = Path.Combine(_diretorio.DiretorioRaiz, txtNovaPasta.Text);
                    if (!Directory.Exists(_diretorio.DiretorioCompleto))
                    {
                        Directory.CreateDirectory(_diretorio.DiretorioCompleto);

                        MessageBox.Show(string.Format("A pasta \"{0}\" foi criada com sucesso!", txtNovaPasta.Text), string.Format("Sucesso"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesquisaDiretorioRaiz.Text = _diretorio.DiretorioCompleto;
                    }
                    else
                        MessageBox.Show(string.Format("A pasta \"{0}\" já existe no diretório.", txtNovaPasta.Text), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Houve uma excessão do executável: \"{0}\".", ex.Message), string.Format("Erro"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Evento de click do Botão "COPIAR ARQUIVOS"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        /// <returns></returns>
        private void btnAddArquivos_Click(object sender, EventArgs e)
        {         
            DialogResult result = _openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _diretorio.DiretorioArquivo = _openFileDialog.FileName;
                _arquivo.NomeArquivo = _openFileDialog.SafeFileName;

                _diretorio.DiretorioRaiz = txtPesquisaDiretorioRaiz.Text;
                _diretorio.DiretorioCompleto = _diretorio.DiretorioRaiz + "\\" + _arquivo.NomeArquivo;

                if (string.IsNullOrWhiteSpace(_diretorio.DiretorioRaiz))
                    MessageBox.Show(string.Format("Por favor, selecione um diretório raiz antes de copiar um arquivo."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (!File.Exists(_diretorio.DiretorioCompleto))
                {
                    File.Copy(_diretorio.DiretorioArquivo, _diretorio.DiretorioCompleto);
                    MessageBox.Show(string.Format("O arquivo \"{0}\" foi copiado com sucesso no diretório.", _arquivo.NomeArquivo), string.Format("Sucesso"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(string.Format("O arquivo \"{0}\" já existe no diretório!", _arquivo.NomeArquivo), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(string.Format("Nenhum arquivo selecionado! Tente novamente."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Evento de click do Botão "CARREGAR ARQUIVO CSV"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        /// <returns></returns>
        private void btnCarregaArquivoCSV_Click(object sender, EventArgs e)
        {
            DialogResult result = _openFileDialog.ShowDialog();            

            if (result == DialogResult.OK)
            {
                _diretorio.DiretorioArquivo = _openFileDialog.FileName;
                _arquivo.NomeArquivo = _openFileDialog.SafeFileName;

                if (!_arquivo.NomeArquivo.Contains(".csv")) // Mudar para verificar nos bytes a extensão do aqruivo, como na empresa
                    MessageBox.Show(string.Format("Nenhum arquivo do tipo .csv selecionado! Tente novamente."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    StreamReader csv = new StreamReader(_diretorio.DiretorioArquivo);

                    string linha; string[] campo;

                    while ((linha = csv.ReadLine()) != null)
                    {
                        campo = linha.Split(';');

                        for (int i = 0; i < campo.Length; i++)
                            cmbListaCoringas.Items.Add(campo[i]);
                    }

                    cmbListaCoringas.Text = "Escolha Abaixo";
                    txtArquivoCarregado.Text = _arquivo.NomeArquivo;
                }
            }
        }

        /// <summary>
        /// Evento de click do Botão "CARREGAR ARQUIVO CSV"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        /// <returns></returns>
        private void btnCarregaArquivoEdicao_Click(object sender, EventArgs e)
        {
            DialogResult result = _openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _diretorio.DiretorioArquivo = _openFileDialog.FileName;
                _arquivo.NomeArquivo = _openFileDialog.SafeFileName;

                if (cmbListaCoringas.Text.Contains("Escolha Abaixo") || cmbListaCoringas.Text.Contains("Carregue os Coringas") || string.IsNullOrWhiteSpace(txtValorCoringa.Text))
                        MessageBox.Show(string.Format("Um coringa e seu respectivo valor precisa ser selecionado! Tente novamente."), string.Format("Atenção"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    string modifyText = File.ReadAllText(_diretorio.DiretorioArquivo);
                    modifyText = modifyText.Replace(cmbListaCoringas.Text, txtValorCoringa.Text);

                    File.WriteAllText(_diretorio.DiretorioArquivo, modifyText);

                    txtNomeArquivoEditar.Text = _arquivo.NomeArquivo;
                    MessageBox.Show(string.Format("O arquivo \"{0}\" foi modificado com sucesso!", _arquivo.NomeArquivo), string.Format("Sucesso"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
        }
    }
}
