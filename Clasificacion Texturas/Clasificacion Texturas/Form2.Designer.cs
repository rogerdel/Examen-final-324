
namespace Clasificacion_Texturas
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Rcol = new System.Windows.Forms.TextBox();
            this.Gcol = new System.Windows.Forms.TextBox();
            this.Bcol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTextura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nomText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtr = new System.Windows.Forms.TextBox();
            this.gtxrt = new System.Windows.Forms.TextBox();
            this.btxtr = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar tectura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rcol
            // 
            this.Rcol.Location = new System.Drawing.Point(145, 37);
            this.Rcol.Name = "Rcol";
            this.Rcol.Size = new System.Drawing.Size(62, 27);
            this.Rcol.TabIndex = 2;
            // 
            // Gcol
            // 
            this.Gcol.Location = new System.Drawing.Point(145, 84);
            this.Gcol.Name = "Gcol";
            this.Gcol.Size = new System.Drawing.Size(62, 27);
            this.Gcol.TabIndex = 3;
            // 
            // Bcol
            // 
            this.Bcol.Location = new System.Drawing.Point(145, 131);
            this.Bcol.Name = "Bcol";
            this.Bcol.Size = new System.Drawing.Size(62, 27);
            this.Bcol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "R Color Pintado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "G Color Pintado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "B Color Pintado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.RTextura,
            this.GTextura,
            this.BTextura,
            this.Rcolor,
            this.Gcolor,
            this.BColor});
            this.dataGridView1.Location = new System.Drawing.Point(327, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(550, 242);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // RTextura
            // 
            this.RTextura.HeaderText = "RTextura";
            this.RTextura.MinimumWidth = 6;
            this.RTextura.Name = "RTextura";
            this.RTextura.Width = 125;
            // 
            // GTextura
            // 
            this.GTextura.HeaderText = "GTextura";
            this.GTextura.MinimumWidth = 6;
            this.GTextura.Name = "GTextura";
            this.GTextura.Width = 125;
            // 
            // BTextura
            // 
            this.BTextura.HeaderText = "BTextura";
            this.BTextura.MinimumWidth = 6;
            this.BTextura.Name = "BTextura";
            this.BTextura.Width = 125;
            // 
            // Rcolor
            // 
            this.Rcolor.HeaderText = "Rcolor";
            this.Rcolor.MinimumWidth = 6;
            this.Rcolor.Name = "Rcolor";
            this.Rcolor.Width = 125;
            // 
            // Gcolor
            // 
            this.Gcolor.HeaderText = "GColor";
            this.Gcolor.MinimumWidth = 6;
            this.Gcolor.Name = "Gcolor";
            this.Gcolor.Width = 125;
            // 
            // BColor
            // 
            this.BColor.HeaderText = "BColor";
            this.BColor.MinimumWidth = 6;
            this.BColor.Name = "BColor";
            this.BColor.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(909, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(909, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(145, 179);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(125, 27);
            this.nomText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre Textura";
            // 
            // rtxtr
            // 
            this.rtxtr.Location = new System.Drawing.Point(104, 335);
            this.rtxtr.Name = "rtxtr";
            this.rtxtr.ReadOnly = true;
            this.rtxtr.Size = new System.Drawing.Size(62, 27);
            this.rtxtr.TabIndex = 15;
            // 
            // gtxrt
            // 
            this.gtxrt.Location = new System.Drawing.Point(104, 378);
            this.gtxrt.Name = "gtxrt";
            this.gtxrt.ReadOnly = true;
            this.gtxrt.Size = new System.Drawing.Size(62, 27);
            this.gtxrt.TabIndex = 16;
            // 
            // btxtr
            // 
            this.btxtr.Location = new System.Drawing.Point(104, 422);
            this.btxtr.Name = "btxtr";
            this.btxtr.ReadOnly = true;
            this.btxtr.Size = new System.Drawing.Size(62, 27);
            this.btxtr.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 335);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 20);
            this.label.TabIndex = 18;
            this.label.Text = "R Textura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "G Textura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "B Textura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(327, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 426);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 693);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btxtr);
            this.Controls.Add(this.gtxrt);
            this.Controls.Add(this.rtxtr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bcol);
            this.Controls.Add(this.Gcol);
            this.Controls.Add(this.Rcol);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Rcol;
        private System.Windows.Forms.TextBox Gcol;
        private System.Windows.Forms.TextBox Bcol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTextura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BColor;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rtxtr;
        private System.Windows.Forms.TextBox gtxrt;
        private System.Windows.Forms.TextBox btxtr;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}