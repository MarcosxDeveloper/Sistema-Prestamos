namespace WindowsFormsApplication1
{
    partial class InsertMoney
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
            this.btn10 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(14, 84);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(94, 66);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn25
            // 
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.Location = new System.Drawing.Point(114, 84);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(94, 66);
            this.btn25.TabIndex = 1;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn50
            // 
            this.btn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50.Location = new System.Drawing.Point(214, 84);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(94, 66);
            this.btn50.TabIndex = 2;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.Location = new System.Drawing.Point(314, 84);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(94, 66);
            this.btn100.TabIndex = 3;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn200
            // 
            this.btn200.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200.Location = new System.Drawing.Point(14, 173);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(94, 66);
            this.btn200.TabIndex = 4;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn500
            // 
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.Location = new System.Drawing.Point(114, 173);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(94, 66);
            this.btn500.TabIndex = 5;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn1000
            // 
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.Location = new System.Drawing.Point(214, 173);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(94, 66);
            this.btn1000.TabIndex = 6;
            this.btn1000.Text = "1,000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn2000
            // 
            this.btn2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.Location = new System.Drawing.Point(314, 173);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(94, 66);
            this.btn2000.TabIndex = 7;
            this.btn2000.Text = "2,000";
            this.btn2000.UseVisualStyleBackColor = true;
            this.btn2000.Click += new System.EventHandler(this.button8_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(35, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(342, 31);
            this.title.TabIndex = 8;
            this.title.Text = "¿Cuanto Desea Depositar?";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(126, 270);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(162, 55);
            this.back.TabIndex = 9;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button9_Click);
            // 
            // InsertMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 354);
            this.Controls.Add(this.back);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn10);
            this.Name = "InsertMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Cajero - Depositar Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button back;
    }
}