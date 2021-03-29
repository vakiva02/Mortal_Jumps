
using System;

namespace Win_MortalJumps
{
    partial class Win_MortalJumps
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
            this.pictureBox_arena = new System.Windows.Forms.PictureBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnComenzar = new System.Windows.Forms.Button();
            this.LblMortalJumps = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblNumSaltos = new System.Windows.Forms.Label();
            this.lblSaltos = new System.Windows.Forms.Label();
            this.buttonvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_arena)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_arena
            // 
            this.pictureBox_arena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox_arena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_arena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_arena.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_arena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_arena.Name = "pictureBox_arena";
            this.pictureBox_arena.Size = new System.Drawing.Size(519, 627);
            this.pictureBox_arena.TabIndex = 0;
            this.pictureBox_arena.TabStop = false;
            this.pictureBox_arena.Click += new System.EventHandler(this.pictureBox_arena_Click);
            this.pictureBox_arena.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_arena_Paint);
            this.pictureBox_arena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_arena_MouseDown);
            this.pictureBox_arena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_arena_MouseUp);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(437, 635);
            this.button_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnComenzar
            // 
            this.btnComenzar.AutoSize = true;
            this.btnComenzar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnComenzar.Font = new System.Drawing.Font("American Signs", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnComenzar.Location = new System.Drawing.Point(114, 404);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(284, 71);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // LblMortalJumps
            // 
            this.LblMortalJumps.AutoSize = true;
            this.LblMortalJumps.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LblMortalJumps.Font = new System.Drawing.Font("American Signs", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMortalJumps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblMortalJumps.Location = new System.Drawing.Point(42, 136);
            this.LblMortalJumps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMortalJumps.Name = "LblMortalJumps";
            this.LblMortalJumps.Size = new System.Drawing.Size(442, 62);
            this.LblMortalJumps.TabIndex = 3;
            this.LblMortalJumps.Text = "Mortal Jumps";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(80, 49);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(348, 69);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Game Over";
            // 
            // lblNumSaltos
            // 
            this.lblNumSaltos.AutoSize = true;
            this.lblNumSaltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSaltos.Location = new System.Drawing.Point(31, 242);
            this.lblNumSaltos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSaltos.Name = "lblNumSaltos";
            this.lblNumSaltos.Size = new System.Drawing.Size(204, 52);
            this.lblNumSaltos.TabIndex = 5;
            this.lblNumSaltos.Text = "Saltaste: ";
            // 
            // lblSaltos
            // 
            this.lblSaltos.AutoSize = true;
            this.lblSaltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltos.Location = new System.Drawing.Point(428, 242);
            this.lblSaltos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaltos.Name = "lblSaltos";
            this.lblSaltos.Size = new System.Drawing.Size(47, 52);
            this.lblSaltos.TabIndex = 7;
            this.lblSaltos.Text = "0";
            this.lblSaltos.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonvolver
            // 
            this.buttonvolver.AutoSize = true;
            this.buttonvolver.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonvolver.Font = new System.Drawing.Font("American Signs", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvolver.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonvolver.Location = new System.Drawing.Point(114, 404);
            this.buttonvolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonvolver.Name = "buttonvolver";
            this.buttonvolver.Size = new System.Drawing.Size(284, 71);
            this.buttonvolver.TabIndex = 8;
            this.buttonvolver.Text = "Comenzar";
            this.buttonvolver.UseVisualStyleBackColor = false;
            this.buttonvolver.Click += new System.EventHandler(this.buttonvolver_Click_1);
            // 
            // Win_MortalJumps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 662);
            this.Controls.Add(this.buttonvolver);
            this.Controls.Add(this.lblSaltos);
            this.Controls.Add(this.lblNumSaltos);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.LblMortalJumps);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.pictureBox_arena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Win_MortalJumps";
            this.Text = "Mortal Jumps.exe";
            this.Load += new System.EventHandler(this.Win_MortalJumps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_arena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox_arena;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label LblMortalJumps;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblNumSaltos;
        private System.Windows.Forms.Label lblSaltos;
        private System.Windows.Forms.Button buttonvolver;
    }
}

