namespace Academia
{
    partial class F_GestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nup_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fecharJanela = new System.Windows.Forms.Button();
            this.btn_excluirUsurario = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "D=Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "B=Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "A=Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // nup_nivel
            // 
            this.nup_nivel.Location = new System.Drawing.Point(121, 162);
            this.nup_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_nivel.Name = "nup_nivel";
            this.nup_nivel.Size = new System.Drawing.Size(111, 23);
            this.nup_nivel.TabIndex = 20;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(13, 162);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(102, 23);
            this.cb_status.TabIndex = 19;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(121, 112);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(111, 23);
            this.tb_senha.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 112);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(103, 23);
            this.tb_username.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 61);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(220, 23);
            this.tb_nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 27);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(94, 23);
            this.tb_id.TabIndex = 27;
            this.tb_id.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fecharJanela);
            this.panel1.Controls.Add(this.btn_excluirUsurario);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 32);
            this.panel1.TabIndex = 28;
            // 
            // btn_fecharJanela
            // 
            this.btn_fecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharJanela.Location = new System.Drawing.Point(410, 3);
            this.btn_fecharJanela.Name = "btn_fecharJanela";
            this.btn_fecharJanela.Size = new System.Drawing.Size(130, 25);
            this.btn_fecharJanela.TabIndex = 3;
            this.btn_fecharJanela.Text = "Fechar janela";
            this.btn_fecharJanela.UseVisualStyleBackColor = true;
            this.btn_fecharJanela.Click += new System.EventHandler(this.btn_fecharJanela_Click);
            // 
            // btn_excluirUsurario
            // 
            this.btn_excluirUsurario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirUsurario.Location = new System.Drawing.Point(275, 3);
            this.btn_excluirUsurario.Name = "btn_excluirUsurario";
            this.btn_excluirUsurario.Size = new System.Drawing.Size(130, 25);
            this.btn_excluirUsurario.TabIndex = 2;
            this.btn_excluirUsurario.Text = "Excluir usuário";
            this.btn_excluirUsurario.UseVisualStyleBackColor = true;
            this.btn_excluirUsurario.Click += new System.EventHandler(this.btn_excluirUsurario_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(139, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(130, 25);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar alterações\r\n";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novoUsuario
            // 
            this.btn_novoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoUsuario.Location = new System.Drawing.Point(3, 3);
            this.btn_novoUsuario.Name = "btn_novoUsuario";
            this.btn_novoUsuario.Size = new System.Drawing.Size(130, 25);
            this.btn_novoUsuario.TabIndex = 0;
            this.btn_novoUsuario.Text = "Novo usuário";
            this.btn_novoUsuario.UseVisualStyleBackColor = true;
            this.btn_novoUsuario.Click += new System.EventHandler(this.btn_novoUsuario_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(239, 9);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.RowTemplate.Height = 25;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(301, 207);
            this.dgv_usuarios.TabIndex = 29;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nup_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao Usuarios";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown nup_nivel;
        private ComboBox cb_status;
        private TextBox tb_senha;
        private Label label3;
        private TextBox tb_username;
        private Label label2;
        private TextBox tb_nome;
        private Label label1;
        private TextBox tb_id;
        private Label label9;
        private Panel panel1;
        private Button btn_fecharJanela;
        private Button btn_excluirUsurario;
        private Button btn_salvar;
        private Button btn_novoUsuario;
        private DataGridView dgv_usuarios;
    }
}