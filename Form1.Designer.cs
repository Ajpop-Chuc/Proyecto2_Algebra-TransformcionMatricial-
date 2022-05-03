namespace Proyecto2_Algebra__TransformcionMatricial_
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarAngulo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTransformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senoidalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polinomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPosX = new System.Windows.Forms.Label();
            this.labelAngulo = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(122, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarY
            // 
            this.trackBarY.Enabled = false;
            this.trackBarY.Location = new System.Drawing.Point(22, 60);
            this.trackBarY.Maximum = 50;
            this.trackBarY.Minimum = -50;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.Size = new System.Drawing.Size(56, 500);
            this.trackBarY.TabIndex = 1;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Enabled = false;
            this.trackBarX.Location = new System.Drawing.Point(122, 581);
            this.trackBarX.Maximum = 50;
            this.trackBarX.Minimum = -50;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(809, 56);
            this.trackBarX.TabIndex = 2;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // trackBarAngulo
            // 
            this.trackBarAngulo.Enabled = false;
            this.trackBarAngulo.Location = new System.Drawing.Point(122, 660);
            this.trackBarAngulo.Maximum = 90;
            this.trackBarAngulo.Minimum = -90;
            this.trackBarAngulo.Name = "trackBarAngulo";
            this.trackBarAngulo.Size = new System.Drawing.Size(809, 56);
            this.trackBarAngulo.TabIndex = 3;
            this.trackBarAngulo.Scroll += new System.EventHandler(this.trackBarAngulo_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pos Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pos X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Angulo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTransformacion,
            this.gráficaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemTransformacion
            // 
            this.ToolStripMenuItemTransformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasladarToolStripMenuItem,
            this.rotarToolStripMenuItem});
            this.ToolStripMenuItemTransformacion.Enabled = false;
            this.ToolStripMenuItemTransformacion.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemTransformacion.Name = "ToolStripMenuItemTransformacion";
            this.ToolStripMenuItemTransformacion.Size = new System.Drawing.Size(227, 26);
            this.ToolStripMenuItemTransformacion.Text = "Transformacion Matricial";
            this.ToolStripMenuItemTransformacion.Click += new System.EventHandler(this.ToolStripMenuItemTransformacion_Click);
            // 
            // trasladarToolStripMenuItem
            // 
            this.trasladarToolStripMenuItem.Name = "trasladarToolStripMenuItem";
            this.trasladarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trasladarToolStripMenuItem.Text = "Trasladar";
            this.trasladarToolStripMenuItem.Click += new System.EventHandler(this.trasladarToolStripMenuItem_Click);
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rotarToolStripMenuItem.Text = "Rotar";
            this.rotarToolStripMenuItem.Click += new System.EventHandler(this.rotarToolStripMenuItem_Click);
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senoidalToolStripMenuItem,
            this.exponencialToolStripMenuItem,
            this.polinomialToolStripMenuItem});
            this.gráficaToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.gráficaToolStripMenuItem.Text = "Gráfica";
            // 
            // senoidalToolStripMenuItem
            // 
            this.senoidalToolStripMenuItem.Name = "senoidalToolStripMenuItem";
            this.senoidalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.senoidalToolStripMenuItem.Text = "Senoidal";
            this.senoidalToolStripMenuItem.Click += new System.EventHandler(this.senoidalToolStripMenuItem_Click);
            // 
            // exponencialToolStripMenuItem
            // 
            this.exponencialToolStripMenuItem.Name = "exponencialToolStripMenuItem";
            this.exponencialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exponencialToolStripMenuItem.Text = "Exponencial";
            this.exponencialToolStripMenuItem.Click += new System.EventHandler(this.exponencialToolStripMenuItem_Click);
            // 
            // polinomialToolStripMenuItem
            // 
            this.polinomialToolStripMenuItem.Name = "polinomialToolStripMenuItem";
            this.polinomialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.polinomialToolStripMenuItem.Text = "Polinomial";
            this.polinomialToolStripMenuItem.Click += new System.EventHandler(this.polinomialToolStripMenuItem_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(363, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(109, 30);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.Font = new System.Drawing.Font("ISOCTEUR", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosX.Location = new System.Drawing.Point(517, 620);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(18, 17);
            this.labelPosX.TabIndex = 10;
            this.labelPosX.Text = "0";
            // 
            // labelAngulo
            // 
            this.labelAngulo.AutoSize = true;
            this.labelAngulo.Font = new System.Drawing.Font("ISOCTEUR", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngulo.Location = new System.Drawing.Point(517, 699);
            this.labelAngulo.Name = "labelAngulo";
            this.labelAngulo.Size = new System.Drawing.Size(18, 17);
            this.labelAngulo.TabIndex = 11;
            this.labelAngulo.Text = "0";
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.Font = new System.Drawing.Font("ISOCTEUR", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosY.Location = new System.Drawing.Point(58, 278);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(18, 17);
            this.labelPosY.TabIndex = 12;
            this.labelPosY.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 728);
            this.Controls.Add(this.labelPosY);
            this.Controls.Add(this.labelAngulo);
            this.Controls.Add(this.labelPosX);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarAngulo);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarAngulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTransformacion;
        private System.Windows.Forms.ToolStripMenuItem trasladarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.Label labelAngulo;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senoidalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polinomialToolStripMenuItem;
    }
}

