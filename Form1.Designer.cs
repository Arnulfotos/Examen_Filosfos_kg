namespace Examen_Filosfos_kg
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
            btnIniciar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblEstado5 = new Label();
            lblEstado4 = new Label();
            lblEstado3 = new Label();
            lblEstado2 = new Label();
            lblEstado1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tablaEstados = new DataGridView();
            Filosofo1 = new DataGridViewTextBoxColumn();
            Filosofo2 = new DataGridViewTextBoxColumn();
            Filosofo3 = new DataGridViewTextBoxColumn();
            Filosofo4 = new DataGridViewTextBoxColumn();
            Filosofo5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaEstados).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Lavender;
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnIniciar.FlatAppearance.BorderSize = 4;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Sylfaen", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(663, 1176);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(336, 85);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(pictureBox5, 4, 0);
            tableLayoutPanel1.Controls.Add(pictureBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblEstado5, 4, 2);
            tableLayoutPanel1.Controls.Add(lblEstado4, 3, 2);
            tableLayoutPanel1.Controls.Add(lblEstado3, 2, 2);
            tableLayoutPanel1.Controls.Add(lblEstado2, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEstado1, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 4, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(43, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.Size = new Size(1635, 324);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = Properties.Resources.griego;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(1372, 22);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(199, 184);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = Properties.Resources.socrates;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1045, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 184);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = Properties.Resources.filosofo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(718, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 184);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.filosofo__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(391, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 184);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.filosofo__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(64, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 184);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblEstado5
            // 
            lblEstado5.Anchor = AnchorStyles.None;
            lblEstado5.AutoSize = true;
            lblEstado5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEstado5.Location = new Point(1456, 282);
            lblEstado5.Name = "lblEstado5";
            lblEstado5.Size = new Size(30, 29);
            lblEstado5.TabIndex = 10;
            lblEstado5.Text = "5";
            // 
            // lblEstado4
            // 
            lblEstado4.Anchor = AnchorStyles.None;
            lblEstado4.AutoSize = true;
            lblEstado4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEstado4.Location = new Point(1129, 282);
            lblEstado4.Name = "lblEstado4";
            lblEstado4.Size = new Size(30, 29);
            lblEstado4.TabIndex = 9;
            lblEstado4.Text = "4";
            // 
            // lblEstado3
            // 
            lblEstado3.Anchor = AnchorStyles.None;
            lblEstado3.AutoSize = true;
            lblEstado3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEstado3.Location = new Point(802, 282);
            lblEstado3.Name = "lblEstado3";
            lblEstado3.Size = new Size(30, 29);
            lblEstado3.TabIndex = 8;
            lblEstado3.Text = "3";
            // 
            // lblEstado2
            // 
            lblEstado2.Anchor = AnchorStyles.None;
            lblEstado2.AutoSize = true;
            lblEstado2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEstado2.Location = new Point(475, 282);
            lblEstado2.Name = "lblEstado2";
            lblEstado2.Size = new Size(30, 29);
            lblEstado2.TabIndex = 7;
            lblEstado2.Text = "2";
            // 
            // lblEstado1
            // 
            lblEstado1.Anchor = AnchorStyles.None;
            lblEstado1.AutoSize = true;
            lblEstado1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblEstado1.Location = new Point(148, 282);
            lblEstado1.Name = "lblEstado1";
            lblEstado1.Size = new Size(30, 29);
            lblEstado1.TabIndex = 2;
            lblEstado1.Text = "1";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label5.Location = new Point(1393, 229);
            label5.Name = "label5";
            label5.Size = new Size(156, 41);
            label5.TabIndex = 6;
            label5.Text = "Filosofo 5";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label4.Location = new Point(1066, 229);
            label4.Name = "label4";
            label4.Size = new Size(156, 41);
            label4.TabIndex = 5;
            label4.Text = "Filosofo 4";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.Location = new Point(739, 229);
            label3.Name = "label3";
            label3.Size = new Size(156, 41);
            label3.TabIndex = 4;
            label3.Text = "Filosofo 3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label2.Location = new Point(412, 229);
            label2.Name = "label2";
            label2.Size = new Size(156, 41);
            label2.TabIndex = 3;
            label2.Text = "Filosofo 2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.Location = new Point(85, 229);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 2;
            label1.Text = "Filosofo 1";
            // 
            // tablaEstados
            // 
            tablaEstados.AllowUserToAddRows = false;
            tablaEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaEstados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablaEstados.BackgroundColor = Color.White;
            tablaEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEstados.ColumnHeadersVisible = false;
            tablaEstados.Columns.AddRange(new DataGridViewColumn[] { Filosofo1, Filosofo2, Filosofo3, Filosofo4, Filosofo5 });
            tablaEstados.EnableHeadersVisualStyles = false;
            tablaEstados.GridColor = Color.MistyRose;
            tablaEstados.Location = new Point(43, 363);
            tablaEstados.Name = "tablaEstados";
            tablaEstados.RowHeadersWidth = 82;
            tablaEstados.Size = new Size(1635, 782);
            tablaEstados.TabIndex = 2;
            // 
            // Filosofo1
            // 
            Filosofo1.HeaderText = "Column1";
            Filosofo1.MinimumWidth = 10;
            Filosofo1.Name = "Filosofo1";
            // 
            // Filosofo2
            // 
            Filosofo2.HeaderText = "Column1";
            Filosofo2.MinimumWidth = 10;
            Filosofo2.Name = "Filosofo2";
            // 
            // Filosofo3
            // 
            Filosofo3.HeaderText = "Column1";
            Filosofo3.MinimumWidth = 10;
            Filosofo3.Name = "Filosofo3";
            // 
            // Filosofo4
            // 
            Filosofo4.HeaderText = "Column1";
            Filosofo4.MinimumWidth = 10;
            Filosofo4.Name = "Filosofo4";
            // 
            // Filosofo5
            // 
            Filosofo5.HeaderText = "Column1";
            Filosofo5.MinimumWidth = 10;
            Filosofo5.Name = "Filosofo5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1714, 1323);
            Controls.Add(tablaEstados);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Filosofos";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaEstados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblEstado5;
        private Label lblEstado4;
        private Label lblEstado3;
        private Label lblEstado2;
        private Label lblEstado1;
        private DataGridView tablaEstados;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Filosofo1;
        private DataGridViewTextBoxColumn Filosofo2;
        private DataGridViewTextBoxColumn Filosofo3;
        private DataGridViewTextBoxColumn Filosofo4;
        private DataGridViewTextBoxColumn Filosofo5;
    }
}
