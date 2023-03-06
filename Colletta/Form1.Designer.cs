namespace Colletta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonTotale = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuota = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonNome = new System.Windows.Forms.Button();
            this.buttonQuota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAggiungi.Location = new System.Drawing.Point(22, 123);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(98, 30);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElimina.Location = new System.Drawing.Point(154, 123);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(98, 30);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifica.Location = new System.Drawing.Point(283, 123);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(98, 30);
            this.buttonModifica.TabIndex = 2;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // buttonTotale
            // 
            this.buttonTotale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTotale.Location = new System.Drawing.Point(407, 123);
            this.buttonTotale.Name = "buttonTotale";
            this.buttonTotale.Size = new System.Drawing.Size(98, 30);
            this.buttonTotale.TabIndex = 4;
            this.buttonTotale.Text = "Totale";
            this.buttonTotale.UseVisualStyleBackColor = true;
            this.buttonTotale.Click += new System.EventHandler(this.buttonTotale_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(22, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxQuota
            // 
            this.textBoxQuota.Location = new System.Drawing.Point(208, 56);
            this.textBoxQuota.Name = "textBoxQuota";
            this.textBoxQuota.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuota.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(550, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 426);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonNome
            // 
            this.buttonNome.Enabled = false;
            this.buttonNome.Location = new System.Drawing.Point(22, 27);
            this.buttonNome.Name = "buttonNome";
            this.buttonNome.Size = new System.Drawing.Size(75, 23);
            this.buttonNome.TabIndex = 8;
            this.buttonNome.Text = "Nome";
            this.buttonNome.UseVisualStyleBackColor = true;
            // 
            // buttonQuota
            // 
            this.buttonQuota.Enabled = false;
            this.buttonQuota.Location = new System.Drawing.Point(208, 27);
            this.buttonQuota.Name = "buttonQuota";
            this.buttonQuota.Size = new System.Drawing.Size(75, 23);
            this.buttonQuota.TabIndex = 9;
            this.buttonQuota.Text = "Quota";
            this.buttonQuota.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.buttonQuota);
            this.Controls.Add(this.buttonNome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxQuota);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonTotale);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAggiungi;
        private Button buttonElimina;
        private Button buttonModifica;
        private Button buttonTotale;
        private TextBox textBoxNome;
        private TextBox textBoxQuota;
        private ListView listView1;
        private Button buttonNome;
        private Button buttonQuota;
    }
}