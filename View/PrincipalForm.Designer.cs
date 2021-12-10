
namespace FIGeraTemas.View
{
    partial class PrincipalForm
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
            this.txtPesquisaDiretorioRaiz = new System.Windows.Forms.TextBox();
            this.txtNovaPasta = new System.Windows.Forms.TextBox();
            this.btnNovaPasta = new System.Windows.Forms.Button();
            this.btnPesquisaDiretorioRaiz = new System.Windows.Forms.Button();
            this.grpbxDiretorios = new System.Windows.Forms.GroupBox();
            this.lblObsAddPasta = new System.Windows.Forms.Label();
            this.grpbxArquivo = new System.Windows.Forms.GroupBox();
            this.btnDelArquivos = new System.Windows.Forms.Button();
            this.btnAddArquivos = new System.Windows.Forms.Button();
            this.grpbxManipulaTexto = new System.Windows.Forms.GroupBox();
            this.btnCarregaArquivoEdicao = new System.Windows.Forms.Button();
            this.txtNomeArquivoEditar = new System.Windows.Forms.TextBox();
            this.lblEditarArquivo = new System.Windows.Forms.Label();
            this.cmbListaCoringas = new System.Windows.Forms.ComboBox();
            this.txtValorCoringa = new System.Windows.Forms.TextBox();
            this.lblSubstituirPor = new System.Windows.Forms.Label();
            this.lblCmbSelCoringa = new System.Windows.Forms.Label();
            this.btnCarregaArquivoCSV = new System.Windows.Forms.Button();
            this.txtArquivoCarregado = new System.Windows.Forms.TextBox();
            this.lblLoadArquivo = new System.Windows.Forms.Label();
            this.grpbxDiretorios.SuspendLayout();
            this.grpbxArquivo.SuspendLayout();
            this.grpbxManipulaTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisaDiretorioRaiz
            // 
            this.txtPesquisaDiretorioRaiz.Enabled = false;
            this.txtPesquisaDiretorioRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaDiretorioRaiz.Location = new System.Drawing.Point(19, 30);
            this.txtPesquisaDiretorioRaiz.Multiline = true;
            this.txtPesquisaDiretorioRaiz.Name = "txtPesquisaDiretorioRaiz";
            this.txtPesquisaDiretorioRaiz.Size = new System.Drawing.Size(464, 32);
            this.txtPesquisaDiretorioRaiz.TabIndex = 0;
            // 
            // txtNovaPasta
            // 
            this.txtNovaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaPasta.Location = new System.Drawing.Point(290, 78);
            this.txtNovaPasta.Multiline = true;
            this.txtNovaPasta.Name = "txtNovaPasta";
            this.txtNovaPasta.Size = new System.Drawing.Size(192, 31);
            this.txtNovaPasta.TabIndex = 2;
            // 
            // btnNovaPasta
            // 
            this.btnNovaPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPasta.Location = new System.Drawing.Point(481, 78);
            this.btnNovaPasta.Name = "btnNovaPasta";
            this.btnNovaPasta.Size = new System.Drawing.Size(107, 32);
            this.btnNovaPasta.TabIndex = 3;
            this.btnNovaPasta.Text = "ADICIONAR";
            this.btnNovaPasta.UseVisualStyleBackColor = true;
            this.btnNovaPasta.Click += new System.EventHandler(this.btnNovaPasta_Click);
            // 
            // btnPesquisaDiretorioRaiz
            // 
            this.btnPesquisaDiretorioRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisaDiretorioRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaDiretorioRaiz.Location = new System.Drawing.Point(481, 29);
            this.btnPesquisaDiretorioRaiz.Name = "btnPesquisaDiretorioRaiz";
            this.btnPesquisaDiretorioRaiz.Size = new System.Drawing.Size(107, 34);
            this.btnPesquisaDiretorioRaiz.TabIndex = 1;
            this.btnPesquisaDiretorioRaiz.Text = "PESQUISAR";
            this.btnPesquisaDiretorioRaiz.UseVisualStyleBackColor = true;
            this.btnPesquisaDiretorioRaiz.Click += new System.EventHandler(this.btnPesquisaDiretorioRaiz_Click);
            // 
            // grpbxDiretorios
            // 
            this.grpbxDiretorios.Controls.Add(this.lblObsAddPasta);
            this.grpbxDiretorios.Controls.Add(this.btnNovaPasta);
            this.grpbxDiretorios.Controls.Add(this.txtNovaPasta);
            this.grpbxDiretorios.Controls.Add(this.btnPesquisaDiretorioRaiz);
            this.grpbxDiretorios.Controls.Add(this.txtPesquisaDiretorioRaiz);
            this.grpbxDiretorios.Location = new System.Drawing.Point(18, 37);
            this.grpbxDiretorios.Name = "grpbxDiretorios";
            this.grpbxDiretorios.Size = new System.Drawing.Size(611, 142);
            this.grpbxDiretorios.TabIndex = 4;
            this.grpbxDiretorios.TabStop = false;
            this.grpbxDiretorios.Text = "Diretório Raiz e Pastas";
            // 
            // lblObsAddPasta
            // 
            this.lblObsAddPasta.AutoSize = true;
            this.lblObsAddPasta.Location = new System.Drawing.Point(290, 111);
            this.lblObsAddPasta.Name = "lblObsAddPasta";
            this.lblObsAddPasta.Size = new System.Drawing.Size(266, 13);
            this.lblObsAddPasta.TabIndex = 4;
            this.lblObsAddPasta.Text = "* caso deseje adicionar pastas ao diretório selecionado";
            // 
            // grpbxArquivo
            // 
            this.grpbxArquivo.Controls.Add(this.btnDelArquivos);
            this.grpbxArquivo.Controls.Add(this.btnAddArquivos);
            this.grpbxArquivo.Location = new System.Drawing.Point(18, 189);
            this.grpbxArquivo.Name = "grpbxArquivo";
            this.grpbxArquivo.Size = new System.Drawing.Size(482, 100);
            this.grpbxArquivo.TabIndex = 5;
            this.grpbxArquivo.TabStop = false;
            this.grpbxArquivo.Text = "Copiar e Excluir Arquivos no Diretório Raiz Selecionado";
            // 
            // btnDelArquivos
            // 
            this.btnDelArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelArquivos.ForeColor = System.Drawing.Color.White;
            this.btnDelArquivos.Location = new System.Drawing.Point(263, 37);
            this.btnDelArquivos.Name = "btnDelArquivos";
            this.btnDelArquivos.Size = new System.Drawing.Size(212, 32);
            this.btnDelArquivos.TabIndex = 1;
            this.btnDelArquivos.Text = "EXCLUIR ARQUIVO";
            this.btnDelArquivos.UseVisualStyleBackColor = false;
            // 
            // btnAddArquivos
            // 
            this.btnAddArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArquivos.ForeColor = System.Drawing.Color.White;
            this.btnAddArquivos.Location = new System.Drawing.Point(6, 37);
            this.btnAddArquivos.Name = "btnAddArquivos";
            this.btnAddArquivos.Size = new System.Drawing.Size(212, 32);
            this.btnAddArquivos.TabIndex = 0;
            this.btnAddArquivos.Text = "COPIAR ARQUIVO";
            this.btnAddArquivos.UseVisualStyleBackColor = false;
            this.btnAddArquivos.Click += new System.EventHandler(this.btnAddArquivos_Click);
            // 
            // grpbxManipulaTexto
            // 
            this.grpbxManipulaTexto.Controls.Add(this.btnCarregaArquivoEdicao);
            this.grpbxManipulaTexto.Controls.Add(this.txtNomeArquivoEditar);
            this.grpbxManipulaTexto.Controls.Add(this.lblEditarArquivo);
            this.grpbxManipulaTexto.Controls.Add(this.cmbListaCoringas);
            this.grpbxManipulaTexto.Controls.Add(this.txtValorCoringa);
            this.grpbxManipulaTexto.Controls.Add(this.lblSubstituirPor);
            this.grpbxManipulaTexto.Controls.Add(this.lblCmbSelCoringa);
            this.grpbxManipulaTexto.Controls.Add(this.btnCarregaArquivoCSV);
            this.grpbxManipulaTexto.Controls.Add(this.txtArquivoCarregado);
            this.grpbxManipulaTexto.Controls.Add(this.lblLoadArquivo);
            this.grpbxManipulaTexto.Location = new System.Drawing.Point(18, 308);
            this.grpbxManipulaTexto.Name = "grpbxManipulaTexto";
            this.grpbxManipulaTexto.Size = new System.Drawing.Size(605, 128);
            this.grpbxManipulaTexto.TabIndex = 6;
            this.grpbxManipulaTexto.TabStop = false;
            this.grpbxManipulaTexto.Text = "Manipulação de Textos no Arquivo";
            // 
            // btnCarregaArquivoEdicao
            // 
            this.btnCarregaArquivoEdicao.Location = new System.Drawing.Point(409, 71);
            this.btnCarregaArquivoEdicao.Name = "btnCarregaArquivoEdicao";
            this.btnCarregaArquivoEdicao.Size = new System.Drawing.Size(187, 23);
            this.btnCarregaArquivoEdicao.TabIndex = 13;
            this.btnCarregaArquivoEdicao.Text = "SELECIONE...";
            this.btnCarregaArquivoEdicao.UseVisualStyleBackColor = true;
            this.btnCarregaArquivoEdicao.Click += new System.EventHandler(this.btnCarregaArquivoEdicao_Click);
            // 
            // txtNomeArquivoEditar
            // 
            this.txtNomeArquivoEditar.Enabled = false;
            this.txtNomeArquivoEditar.Location = new System.Drawing.Point(409, 45);
            this.txtNomeArquivoEditar.Name = "txtNomeArquivoEditar";
            this.txtNomeArquivoEditar.Size = new System.Drawing.Size(187, 20);
            this.txtNomeArquivoEditar.TabIndex = 12;
            // 
            // lblEditarArquivo
            // 
            this.lblEditarArquivo.AutoSize = true;
            this.lblEditarArquivo.Location = new System.Drawing.Point(406, 25);
            this.lblEditarArquivo.Name = "lblEditarArquivo";
            this.lblEditarArquivo.Size = new System.Drawing.Size(101, 13);
            this.lblEditarArquivo.TabIndex = 11;
            this.lblEditarArquivo.Text = "Arquivo Modificado:";
            // 
            // cmbListaCoringas
            // 
            this.cmbListaCoringas.FormattingEnabled = true;
            this.cmbListaCoringas.Location = new System.Drawing.Point(227, 45);
            this.cmbListaCoringas.Name = "cmbListaCoringas";
            this.cmbListaCoringas.Size = new System.Drawing.Size(157, 21);
            this.cmbListaCoringas.TabIndex = 10;
            this.cmbListaCoringas.Text = "Carregue os Coringas";
            // 
            // txtValorCoringa
            // 
            this.txtValorCoringa.Location = new System.Drawing.Point(227, 94);
            this.txtValorCoringa.Name = "txtValorCoringa";
            this.txtValorCoringa.Size = new System.Drawing.Size(157, 20);
            this.txtValorCoringa.TabIndex = 9;
            // 
            // lblSubstituirPor
            // 
            this.lblSubstituirPor.AutoSize = true;
            this.lblSubstituirPor.Location = new System.Drawing.Point(224, 73);
            this.lblSubstituirPor.Name = "lblSubstituirPor";
            this.lblSubstituirPor.Size = new System.Drawing.Size(72, 13);
            this.lblSubstituirPor.TabIndex = 8;
            this.lblSubstituirPor.Text = "Substitua por:";
            // 
            // lblCmbSelCoringa
            // 
            this.lblCmbSelCoringa.AutoSize = true;
            this.lblCmbSelCoringa.Location = new System.Drawing.Point(224, 25);
            this.lblCmbSelCoringa.Name = "lblCmbSelCoringa";
            this.lblCmbSelCoringa.Size = new System.Drawing.Size(105, 13);
            this.lblCmbSelCoringa.TabIndex = 7;
            this.lblCmbSelCoringa.Text = "Selecione o Coringa:";
            // 
            // btnCarregaArquivoCSV
            // 
            this.btnCarregaArquivoCSV.Location = new System.Drawing.Point(13, 70);
            this.btnCarregaArquivoCSV.Name = "btnCarregaArquivoCSV";
            this.btnCarregaArquivoCSV.Size = new System.Drawing.Size(188, 23);
            this.btnCarregaArquivoCSV.TabIndex = 2;
            this.btnCarregaArquivoCSV.Text = "CARREGAR ARQUIVO CSV";
            this.btnCarregaArquivoCSV.UseVisualStyleBackColor = true;
            this.btnCarregaArquivoCSV.Click += new System.EventHandler(this.btnCarregaArquivoCSV_Click);
            // 
            // txtArquivoCarregado
            // 
            this.txtArquivoCarregado.Enabled = false;
            this.txtArquivoCarregado.Location = new System.Drawing.Point(14, 45);
            this.txtArquivoCarregado.Name = "txtArquivoCarregado";
            this.txtArquivoCarregado.Size = new System.Drawing.Size(187, 20);
            this.txtArquivoCarregado.TabIndex = 1;
            // 
            // lblLoadArquivo
            // 
            this.lblLoadArquivo.AutoSize = true;
            this.lblLoadArquivo.Location = new System.Drawing.Point(13, 25);
            this.lblLoadArquivo.Name = "lblLoadArquivo";
            this.lblLoadArquivo.Size = new System.Drawing.Size(188, 13);
            this.lblLoadArquivo.TabIndex = 0;
            this.lblLoadArquivo.Text = "Carregar Lista de Coringas do Arquivo:";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 491);
            this.Controls.Add(this.grpbxManipulaTexto);
            this.Controls.Add(this.grpbxArquivo);
            this.Controls.Add(this.grpbxDiretorios);
            this.Name = "PrincipalForm";
            this.Text = "FIGeraTemas";
            this.grpbxDiretorios.ResumeLayout(false);
            this.grpbxDiretorios.PerformLayout();
            this.grpbxArquivo.ResumeLayout(false);
            this.grpbxManipulaTexto.ResumeLayout(false);
            this.grpbxManipulaTexto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaDiretorioRaiz;
        private System.Windows.Forms.Button btnPesquisaDiretorioRaiz;
        private System.Windows.Forms.TextBox txtNovaPasta;
        private System.Windows.Forms.Button btnNovaPasta;
        private System.Windows.Forms.GroupBox grpbxDiretorios;
        private System.Windows.Forms.GroupBox grpbxArquivo;
        private System.Windows.Forms.Button btnDelArquivos;
        private System.Windows.Forms.Button btnAddArquivos;
        private System.Windows.Forms.GroupBox grpbxManipulaTexto;
        private System.Windows.Forms.Label lblLoadArquivo;
        private System.Windows.Forms.Button btnCarregaArquivoCSV;
        private System.Windows.Forms.TextBox txtArquivoCarregado;
        private System.Windows.Forms.Label lblObsAddPasta;
        private System.Windows.Forms.Label lblCmbSelCoringa;
        private System.Windows.Forms.TextBox txtValorCoringa;
        private System.Windows.Forms.Label lblSubstituirPor;
        private System.Windows.Forms.ComboBox cmbListaCoringas;
        private System.Windows.Forms.TextBox txtNomeArquivoEditar;
        private System.Windows.Forms.Label lblEditarArquivo;
        private System.Windows.Forms.Button btnCarregaArquivoEdicao;
    }
}