namespace WindowsFormsApplication1
{
    partial class MainMenu
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
            this.depositar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // depositar
            // 
            this.depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositar.Location = new System.Drawing.Point(69, 43);
            this.depositar.Name = "depositar";
            this.depositar.Size = new System.Drawing.Size(153, 95);
            this.depositar.TabIndex = 0;
            this.depositar.Text = "Depositar";
            this.depositar.UseVisualStyleBackColor = true;
            this.depositar.Click += new System.EventHandler(this.button1_Click);
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(238, 43);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(153, 95);
            this.retirar.TabIndex = 1;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.button2_Click);
            // 
            // historial
            // 
            this.historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.Location = new System.Drawing.Point(69, 166);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(153, 95);
            this.historial.TabIndex = 2;
            this.historial.Text = "Historial";
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Click += new System.EventHandler(this.button3_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(238, 166);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(153, 95);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo Actual:";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(238, 298);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(153, 38);
            this.balance.TabIndex = 5;
            this.balance.Text = "0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 377);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.depositar);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Cajero - Menu Principal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox balance;
    }
}