namespace Pimc
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.maskIMC = new System.Windows.Forms.MaskedTextBox();
            this.maskAltura = new System.Windows.Forms.MaskedTextBox();
            this.maskPeso = new System.Windows.Forms.MaskedTextBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.btLimp = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtObeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            resources.ApplyResources(this.lblPeso, "lblPeso");
            this.lblPeso.Name = "lblPeso";
            // 
            // lblAltura
            // 
            resources.ApplyResources(this.lblAltura, "lblAltura");
            this.lblAltura.Name = "lblAltura";
            // 
            // lblIMC
            // 
            resources.ApplyResources(this.lblIMC, "lblIMC");
            this.lblIMC.Name = "lblIMC";
            // 
            // maskIMC
            // 
            resources.ApplyResources(this.maskIMC, "maskIMC");
            this.maskIMC.Name = "maskIMC";
            this.maskIMC.ReadOnly = true;
            this.maskIMC.ValidatingType = typeof(int);
            // 
            // maskAltura
            // 
            resources.ApplyResources(this.maskAltura, "maskAltura");
            this.maskAltura.Name = "maskAltura";
            this.maskAltura.ValidatingType = typeof(int);
            this.maskAltura.Validated += new System.EventHandler(this.maskAltura_Validated);
            // 
            // maskPeso
            // 
            resources.ApplyResources(this.maskPeso, "maskPeso");
            this.maskPeso.Name = "maskPeso";
            this.maskPeso.ValidatingType = typeof(int);
            this.maskPeso.Validated += new System.EventHandler(this.maskPeso_Validated);
            // 
            // btCalc
            // 
            this.btCalc.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.btCalc, "btCalc");
            this.btCalc.Name = "btCalc";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btLimp
            // 
            this.btLimp.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.btLimp, "btLimp");
            this.btLimp.Name = "btLimp";
            this.btLimp.UseVisualStyleBackColor = true;
            this.btLimp.Click += new System.EventHandler(this.btLimp_Click);
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.btSair, "btSair");
            this.btSair.Name = "btSair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtClassificacao
            // 
            resources.ApplyResources(this.txtClassificacao, "txtClassificacao");
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.ReadOnly = true;
            // 
            // txtObeso
            // 
            resources.ApplyResources(this.txtObeso, "txtObeso");
            this.txtObeso.Name = "txtObeso";
            this.txtObeso.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtObeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.maskPeso);
            this.Controls.Add(this.maskAltura);
            this.Controls.Add(this.maskIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.MaskedTextBox maskIMC;
        private System.Windows.Forms.MaskedTextBox maskAltura;
        private System.Windows.Forms.MaskedTextBox maskPeso;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btLimp;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.TextBox txtObeso;
        private System.Windows.Forms.Label label2;
    }
}

