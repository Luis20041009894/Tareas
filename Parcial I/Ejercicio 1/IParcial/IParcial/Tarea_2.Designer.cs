namespace IParcial
{
    partial class Tarea_2
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PromediofinalTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(178, 343);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(163, 111);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 4:";
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(178, 61);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(170, 27);
            this.Nota1TextBox.TabIndex = 5;
            this.Nota1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nota1TextBox_KeyPress);
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(178, 105);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(170, 27);
            this.Nota2TextBox.TabIndex = 6;
            this.Nota2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nota2TextBox_KeyPress);
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(178, 154);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(170, 27);
            this.Nota3TextBox.TabIndex = 7;
            this.Nota3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nota3TextBox_KeyPress);
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(178, 201);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(170, 27);
            this.Nota4TextBox.TabIndex = 8;
            this.Nota4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nota4TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promedio Final:";
            // 
            // PromediofinalTextBox
            // 
            this.PromediofinalTextBox.Location = new System.Drawing.Point(178, 276);
            this.PromediofinalTextBox.Name = "PromediofinalTextBox";
            this.PromediofinalTextBox.ReadOnly = true;
            this.PromediofinalTextBox.Size = new System.Drawing.Size(170, 27);
            this.PromediofinalTextBox.TabIndex = 10;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(429, 328);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(163, 51);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Limpiar";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(429, 403);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(163, 51);
            this.SalirButton.TabIndex = 12;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // Tarea_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 526);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PromediofinalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tarea_2";
            this.Text = "Tarea_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.TextBox Nota4TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PromediofinalTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SalirButton;
    }
}