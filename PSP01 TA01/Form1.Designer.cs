using System.Diagnostics;

namespace PSP01_TA_procesos
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
            buttonLanzarProceso = new Button();
            buttonMatarProceso = new Button();
            buttonMostrarProcSist = new Button();
            comboBoxProc = new ComboBox();
            labelID = new Label();
            SuspendLayout();
            // 
            // buttonLanzarProceso
            // 
            buttonLanzarProceso.Location = new Point(25, 23);
            buttonLanzarProceso.Name = "buttonLanzarProceso";
            buttonLanzarProceso.Size = new Size(167, 72);
            buttonLanzarProceso.TabIndex = 0;
            buttonLanzarProceso.Text = "Lanzar Proceso Calc";
            buttonLanzarProceso.UseVisualStyleBackColor = true;
            buttonLanzarProceso.Click += buttonLanzarProceso_Click;
            // 
            // buttonMatarProceso
            // 
            buttonMatarProceso.Location = new Point(212, 23);
            buttonMatarProceso.Name = "buttonMatarProceso";
            buttonMatarProceso.Size = new Size(111, 72);
            buttonMatarProceso.TabIndex = 1;
            buttonMatarProceso.Text = "MatarProceso";
            buttonMatarProceso.UseVisualStyleBackColor = true;
            buttonMatarProceso.Click += buttonMatarProceso_Click;
            // 
            // buttonMostrarProcSist
            // 
            buttonMostrarProcSist.Location = new Point(25, 101);
            buttonMostrarProcSist.Name = "buttonMostrarProcSist";
            buttonMostrarProcSist.Size = new Size(167, 72);
            buttonMostrarProcSist.TabIndex = 2;
            buttonMostrarProcSist.Text = "Mostrar Procesos Sistema";
            buttonMostrarProcSist.UseVisualStyleBackColor = true;
            buttonMostrarProcSist.Click += buttonMostrarProcSist_Click;
            // 
            // comboBoxProc
            // 
            comboBoxProc.FormattingEnabled = true;
            comboBoxProc.Location = new Point(212, 127);
            comboBoxProc.Name = "comboBoxProc";
            comboBoxProc.Size = new Size(167, 23);
            comboBoxProc.TabIndex = 3;
            comboBoxProc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(334, 44);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 15);
            labelID.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 200);
            Controls.Add(labelID);
            Controls.Add(comboBoxProc);
            Controls.Add(buttonMostrarProcSist);
            Controls.Add(buttonMatarProceso);
            Controls.Add(buttonLanzarProceso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLanzarProceso;
        private Button buttonMatarProceso;
        private Button buttonMostrarProcSist;
        private ComboBox comboBoxProc;
        private Process p;
        private Label labelID;
        private Process childProcess;
        private Process[] processes;
    }
}