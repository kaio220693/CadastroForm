namespace Aula
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLocalizar = new System.Windows.Forms.Button();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btLocalizar
            // 
            this.btLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Location = new System.Drawing.Point(129, 39);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(151, 47);
            this.btLocalizar.TabIndex = 0;
            this.btLocalizar.Text = "LOCALIZAR";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(12, 246);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.Size = new System.Drawing.Size(524, 192);
            this.dgvPessoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(12, 193);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(141, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celular";
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(385, 26);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(151, 47);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(385, 82);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(151, 47);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(385, 135);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(151, 47);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(385, 193);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(151, 47);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(this.btLocalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
    }
}

