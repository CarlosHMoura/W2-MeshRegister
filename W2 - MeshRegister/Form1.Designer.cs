namespace W2___MixList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.meshList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.TextBox();
            this.textura = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.textureName = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dirPatch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar Edição";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meshList
            // 
            this.meshList.FormattingEnabled = true;
            this.meshList.Location = new System.Drawing.Point(16, 185);
            this.meshList.Name = "meshList";
            this.meshList.Size = new System.Drawing.Size(420, 498);
            this.meshList.TabIndex = 1;
            this.meshList.SelectedIndexChanged += new System.EventHandler(this.lbNpc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dirPatch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.registro);
            this.groupBox1.Controls.Add(this.textura);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.textureName);
            this.groupBox1.Controls.Add(this.meshList);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 692);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesh texture Lists";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(161, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "EffectTextureList";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "EnvTextureList";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(161, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "UiTextureList";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "UI RCbin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "MeshTextureList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Salvar Arquivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(395, 20);
            this.registro.MaxLength = 1;
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(41, 20);
            this.registro.TabIndex = 38;
            this.registro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registro.TextChanged += new System.EventHandler(this.registro_TextChanged);
            this.registro.Leave += new System.EventHandler(this.registro_Leave);
            // 
            // textura
            // 
            this.textura.Location = new System.Drawing.Point(66, 20);
            this.textura.Name = "textura";
            this.textura.Size = new System.Drawing.Size(240, 20);
            this.textura.TabIndex = 37;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(329, 23);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(49, 13);
            this.type.TabIndex = 36;
            this.type.Text = "Registro:";
            // 
            // textureName
            // 
            this.textureName.AutoSize = true;
            this.textureName.Location = new System.Drawing.Point(17, 24);
            this.textureName.Name = "textureName";
            this.textureName.Size = new System.Drawing.Size(43, 13);
            this.textureName.TabIndex = 35;
            this.textureName.Text = "Textura";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(192, 46);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 23);
            this.button11.TabIndex = 34;
            this.button11.Text = "Limpar Edição";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "by SeiTbNao 2019";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(765, 593);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(290, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "Item de ID maior que 10000 busca descrição no mixhelp.dat";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(908, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "By SeitbNao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Diretório:";
            // 
            // dirPatch
            // 
            this.dirPatch.AutoSize = true;
            this.dirPatch.Location = new System.Drawing.Point(72, 92);
            this.dirPatch.Name = "dirPatch";
            this.dirPatch.Size = new System.Drawing.Size(55, 13);
            this.dirPatch.TabIndex = 50;
            this.dirPatch.Text = "NENHUM";
            this.dirPatch.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(471, 717);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "W2 - MeshTextureList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox meshList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox registro;
        private System.Windows.Forms.TextBox textura;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label textureName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label dirPatch;
        private System.Windows.Forms.Label label2;
    }
}

