﻿namespace NAVE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.navegador1 = new CapaDeDiseno.Navegador();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 386);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 134);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(249, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(249, 20);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 207);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(249, 20);
			this.textBox3.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(340, 131);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(820, 205);
			this.dataGridView1.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 316);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(249, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(12, 243);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(249, 20);
			this.textBox6.TabIndex = 5;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(12, 389);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(249, 20);
			this.textBox8.TabIndex = 9;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(12, 351);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(249, 20);
			this.textBox9.TabIndex = 8;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(13, 282);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(248, 20);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.White;
			this.navegador1.Location = new System.Drawing.Point(12, 12);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1148, 99);
			this.navegador1.TabIndex = 10;
			this.navegador1.Load += new System.EventHandler(this.Navegador1_Load_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 690);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.navegador1);
			this.HelpButton = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private CapaDeDiseno.Navegador navegador1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}

