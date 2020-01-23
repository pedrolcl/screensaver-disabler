namespace Monon
{
    partial class FormMain
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
            this.keepOnSw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // keepOnSw
            // 
            this.keepOnSw.AutoSize = true;
            this.keepOnSw.Location = new System.Drawing.Point(10, 11);
            this.keepOnSw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keepOnSw.Name = "keepOnSw";
            this.keepOnSw.Size = new System.Drawing.Size(126, 17);
            this.keepOnSw.TabIndex = 0;
            this.keepOnSw.Text = "Disable ScreenSaver";
            this.keepOnSw.UseVisualStyleBackColor = true;
            this.keepOnSw.CheckedChanged += new System.EventHandler(this.keepOnSw_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 39);
            this.Controls.Add(this.keepOnSw);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Screensaver Disabler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox keepOnSw;
    }
}

