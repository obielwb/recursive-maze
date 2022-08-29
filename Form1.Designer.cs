namespace Recursive_Maze
{
    partial class RecursiveMazeForm
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
            this.solveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.whitePictureBox = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.wallLabel = new System.Windows.Forms.Label();
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.whitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(13, 13);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 0;
            this.solveButton.Text = "solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(95, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // whitePictureBox
            // 
            this.whitePictureBox.BackColor = System.Drawing.Color.White;
            this.whitePictureBox.Location = new System.Drawing.Point(176, 13);
            this.whitePictureBox.Name = "whitePictureBox";
            this.whitePictureBox.Size = new System.Drawing.Size(23, 23);
            this.whitePictureBox.TabIndex = 2;
            this.whitePictureBox.TabStop = false;
            this.whitePictureBox.Click += new System.EventHandler(this.whitePictureBox_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(205, 23);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(28, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "path";
            // 
            // wallLabel
            // 
            this.wallLabel.AutoSize = true;
            this.wallLabel.Location = new System.Drawing.Point(270, 23);
            this.wallLabel.Name = "wallLabel";
            this.wallLabel.Size = new System.Drawing.Size(25, 13);
            this.wallLabel.TabIndex = 5;
            this.wallLabel.Text = "wall";
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.BackColor = System.Drawing.Color.Black;
            this.blackPictureBox.Location = new System.Drawing.Point(241, 13);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(23, 23);
            this.blackPictureBox.TabIndex = 4;
            this.blackPictureBox.TabStop = false;
            this.blackPictureBox.Click += new System.EventHandler(this.blackPictureBox_Click);
            // 
            // RecursiveMazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(314, 349);
            this.Controls.Add(this.wallLabel);
            this.Controls.Add(this.blackPictureBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.whitePictureBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.solveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecursiveMazeForm";
            this.Text = "Recursive Maze";
            this.Load += new System.EventHandler(this.RecursiveMazeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox whitePictureBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label wallLabel;
        private System.Windows.Forms.PictureBox blackPictureBox;
    }
}

