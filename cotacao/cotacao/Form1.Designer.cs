namespace cotacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.novaCotaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarAlteraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCotaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCotaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCotaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarAlteraçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerAlteraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovadoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovadoGerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprovadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações Gerais sobre a Cotação";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Remetente",
            "Destinatário"});
            this.comboBox2.Location = new System.Drawing.Point(190, 333);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Quem paga o frete";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "CNPJ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(26, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(26, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(26, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(301, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(26, 255);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(301, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(26, 294);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(301, 20);
            this.textBox7.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fatura",
            "Boleto"});
            this.comboBox1.Location = new System.Drawing.Point(26, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(26, 373);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(301, 20);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Quem fez a venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Número de Cotação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pessoa de Contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número de Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Agendamento de Coleta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ramo de Atividade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Condição de Pagamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Representante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Emissão de Cotação";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(447, 177);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(133, 20);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = "Data e Hora";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(586, 177);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(92, 20);
            this.textBox10.TabIndex = 22;
            this.textBox10.Text = "Usuário";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(684, 177);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(92, 20);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "Funcionário";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(684, 216);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(92, 20);
            this.textBox12.TabIndex = 27;
            this.textBox12.Text = "Funcionário";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(586, 216);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(92, 20);
            this.textBox13.TabIndex = 26;
            this.textBox13.Text = "Usuário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Aprovada pelo Cliente";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(447, 216);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(133, 20);
            this.textBox14.TabIndex = 24;
            this.textBox14.Text = "Data e Hora";
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(684, 255);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(92, 20);
            this.textBox15.TabIndex = 31;
            this.textBox15.Text = "Funcionário";
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(586, 255);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(92, 20);
            this.textBox16.TabIndex = 30;
            this.textBox16.Text = "Usuário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Aprovada pelo Gerente";
            // 
            // textBox17
            // 
            this.textBox17.Enabled = false;
            this.textBox17.Location = new System.Drawing.Point(447, 255);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(133, 20);
            this.textBox17.TabIndex = 28;
            this.textBox17.Text = "Data e Hora";
            // 
            // textBox18
            // 
            this.textBox18.Enabled = false;
            this.textBox18.Location = new System.Drawing.Point(684, 294);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(92, 20);
            this.textBox18.TabIndex = 35;
            this.textBox18.Text = "Funcionário";
            // 
            // textBox19
            // 
            this.textBox19.Enabled = false;
            this.textBox19.Location = new System.Drawing.Point(586, 294);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(92, 20);
            this.textBox19.TabIndex = 34;
            this.textBox19.Text = "Usuário";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Reprovada";
            // 
            // textBox20
            // 
            this.textBox20.Enabled = false;
            this.textBox20.Location = new System.Drawing.Point(447, 294);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(133, 20);
            this.textBox20.TabIndex = 32;
            this.textBox20.Text = "Data e Hora";
            // 
            // textBox21
            // 
            this.textBox21.Enabled = false;
            this.textBox21.Location = new System.Drawing.Point(684, 333);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(92, 20);
            this.textBox21.TabIndex = 39;
            this.textBox21.Text = "Funcionário";
            // 
            // textBox22
            // 
            this.textBox22.Enabled = false;
            this.textBox22.Location = new System.Drawing.Point(586, 333);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(92, 20);
            this.textBox22.TabIndex = 38;
            this.textBox22.Text = "Usuário";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(444, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Finalizada (Baixa)";
            // 
            // textBox23
            // 
            this.textBox23.Enabled = false;
            this.textBox23.Location = new System.Drawing.Point(447, 333);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(133, 20);
            this.textBox23.TabIndex = 36;
            this.textBox23.Text = "Data e Hora";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 40;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCotaçãoToolStripMenuItem,
            this.aplicarAlteraçõesToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Aprovado Cliente",
            "Aprovado Gerente",
            "Reprovado Cliente",
            "Reprovado Gerente"});
            this.comboBox3.Location = new System.Drawing.Point(447, 373);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 42;
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Em Aberto",
            "Finalizado"});
            this.comboBox4.Location = new System.Drawing.Point(575, 373);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Status";
            // 
            // novaCotaçãoToolStripMenuItem
            // 
            this.novaCotaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCotaçãoToolStripMenuItem1,
            this.editarCotaçãoToolStripMenuItem1,
            this.cancelarCotaçãoToolStripMenuItem1});
            this.novaCotaçãoToolStripMenuItem.Name = "novaCotaçãoToolStripMenuItem";
            this.novaCotaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.novaCotaçãoToolStripMenuItem.Text = "Cotação";
            // 
            // aplicarAlteraçõesToolStripMenuItem
            // 
            this.aplicarAlteraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicarAlteraçõesToolStripMenuItem1,
            this.desfazerAlteraçõesToolStripMenuItem});
            this.aplicarAlteraçõesToolStripMenuItem.Name = "aplicarAlteraçõesToolStripMenuItem";
            this.aplicarAlteraçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.aplicarAlteraçõesToolStripMenuItem.Text = "Alterações";
            // 
            // novaCotaçãoToolStripMenuItem1
            // 
            this.novaCotaçãoToolStripMenuItem1.Name = "novaCotaçãoToolStripMenuItem1";
            this.novaCotaçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novaCotaçãoToolStripMenuItem1.Text = "Nova Cotação";
            // 
            // editarCotaçãoToolStripMenuItem1
            // 
            this.editarCotaçãoToolStripMenuItem1.Name = "editarCotaçãoToolStripMenuItem1";
            this.editarCotaçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarCotaçãoToolStripMenuItem1.Text = "Editar Cotação";
            // 
            // cancelarCotaçãoToolStripMenuItem1
            // 
            this.cancelarCotaçãoToolStripMenuItem1.Name = "cancelarCotaçãoToolStripMenuItem1";
            this.cancelarCotaçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cancelarCotaçãoToolStripMenuItem1.Text = "Cancelar Cotação";
            // 
            // aplicarAlteraçõesToolStripMenuItem1
            // 
            this.aplicarAlteraçõesToolStripMenuItem1.Name = "aplicarAlteraçõesToolStripMenuItem1";
            this.aplicarAlteraçõesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aplicarAlteraçõesToolStripMenuItem1.Text = "Aplicar Alterações";
            // 
            // desfazerAlteraçõesToolStripMenuItem
            // 
            this.desfazerAlteraçõesToolStripMenuItem.Name = "desfazerAlteraçõesToolStripMenuItem";
            this.desfazerAlteraçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desfazerAlteraçõesToolStripMenuItem.Text = "Desfazer Alterações";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprovadoClienteToolStripMenuItem,
            this.aprovadoGerenteToolStripMenuItem,
            this.reprovadaToolStripMenuItem,
            this.finalizarToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // aprovadoClienteToolStripMenuItem
            // 
            this.aprovadoClienteToolStripMenuItem.Name = "aprovadoClienteToolStripMenuItem";
            this.aprovadoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aprovadoClienteToolStripMenuItem.Text = "Aprovada Cliente";
            // 
            // aprovadoGerenteToolStripMenuItem
            // 
            this.aprovadoGerenteToolStripMenuItem.Name = "aprovadoGerenteToolStripMenuItem";
            this.aprovadoGerenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aprovadoGerenteToolStripMenuItem.Text = "Aprovada Gerente";
            // 
            // reprovadaToolStripMenuItem
            // 
            this.reprovadaToolStripMenuItem.Name = "reprovadaToolStripMenuItem";
            this.reprovadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reprovadaToolStripMenuItem.Text = "Reprovada";
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalizarToolStripMenuItem.Text = "Finalizar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.emailToolStripMenuItem.Text = "E-mail";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem novaCotaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaCotaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarCotaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarCotaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aplicarAlteraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarAlteraçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desfazerAlteraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovadoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovadoGerenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprovadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

