namespace AppEmbalagem
{
    partial class FormCadastroNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroNome));
            this.labelRe = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelApelido = new System.Windows.Forms.Label();
            this.txtre = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtapelido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRe
            // 
            this.labelRe.AutoSize = true;
            this.labelRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRe.Location = new System.Drawing.Point(45, 30);
            this.labelRe.Name = "labelRe";
            this.labelRe.Size = new System.Drawing.Size(48, 29);
            this.labelRe.TabIndex = 0;
            this.labelRe.Text = "RE";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(45, 123);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(90, 29);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "NOME";
            // 
            // labelApelido
            // 
            this.labelApelido.AutoSize = true;
            this.labelApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApelido.Location = new System.Drawing.Point(45, 227);
            this.labelApelido.Name = "labelApelido";
            this.labelApelido.Size = new System.Drawing.Size(122, 29);
            this.labelApelido.TabIndex = 2;
            this.labelApelido.Text = "APELIDO";
            // 
            // txtre
            // 
            this.txtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtre.Location = new System.Drawing.Point(50, 63);
            this.txtre.Name = "txtre";
            this.txtre.Size = new System.Drawing.Size(85, 35);
            this.txtre.TabIndex = 3;
            this.txtre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtre_KeyPress);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(50, 155);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(633, 35);
            this.txtnome.TabIndex = 4;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txtapelido
            // 
            this.txtapelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapelido.Location = new System.Drawing.Point(50, 259);
            this.txtapelido.Name = "txtapelido";
            this.txtapelido.Size = new System.Drawing.Size(633, 35);
            this.txtapelido.TabIndex = 5;
            this.txtapelido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapelido_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEmbalagem.Properties.Resources._3___logo1;
            this.pictureBox1.Location = new System.Drawing.Point(512, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Image = global::AppEmbalagem.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalvar.Location = new System.Drawing.Point(50, 353);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 46);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Image = global::AppEmbalagem.Properties.Resources.Everaldo_Crystal_Clear_Action_reload;
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnovo.Location = new System.Drawing.Point(553, 353);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(130, 46);
            this.btnnovo.TabIndex = 8;
            this.btnnovo.Text = "NOVO";
            this.btnnovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RE,
            this.Nome,
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(50, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(633, 229);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RE
            // 
            this.RE.HeaderText = "RE";
            this.RE.Name = "RE";
            this.RE.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "APELIDO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormCadastroNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtapelido);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtre);
            this.Controls.Add(this.labelApelido);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelRe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE COLABORADORAS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRe;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelApelido;
        private System.Windows.Forms.TextBox txtre;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtapelido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}