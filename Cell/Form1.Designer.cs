namespace Cell
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
            this.pnl_cell = new System.Windows.Forms.Panel();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_cell
            // 
            this.pnl_cell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_cell.Location = new System.Drawing.Point(1106, 184);
            this.pnl_cell.Name = "pnl_cell";
            this.pnl_cell.Size = new System.Drawing.Size(907, 839);
            this.pnl_cell.TabIndex = 0;
            this.pnl_cell.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cell_Paint);
            // 
            // btn_simulation
            // 
            this.btn_simulation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_simulation.Location = new System.Drawing.Point(1405, 1050);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(338, 87);
            this.btn_simulation.TabIndex = 1;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = false;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3140, 1268);
            this.Controls.Add(this.btn_simulation);
            this.Controls.Add(this.pnl_cell);
            this.Name = "Form1";
            this.Text = "Cellule Mutante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_cell;
        private Button btn_simulation;
    }
}