namespace HTMLTableGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTableData = new HTMLTableGenerator.UCTableData();
            this.bGenerateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucTableData
            // 
            this.ucTableData.Location = new System.Drawing.Point(13, 13);
            this.ucTableData.Name = "ucTableData";
            this.ucTableData.Size = new System.Drawing.Size(419, 699);
            this.ucTableData.TabIndex = 0;
            // 
            // bGenerateTable
            // 
            this.bGenerateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bGenerateTable.Location = new System.Drawing.Point(438, 13);
            this.bGenerateTable.Name = "bGenerateTable";
            this.bGenerateTable.Size = new System.Drawing.Size(199, 77);
            this.bGenerateTable.TabIndex = 1;
            this.bGenerateTable.Text = "Generate HTML Table";
            this.bGenerateTable.UseVisualStyleBackColor = true;
            this.bGenerateTable.Click += new System.EventHandler(this.GenerateTableButtonDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(649, 713);
            this.Controls.Add(this.bGenerateTable);
            this.Controls.Add(this.ucTableData);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTableData ucTableData;
        private System.Windows.Forms.Button bGenerateTable;
    }
}

