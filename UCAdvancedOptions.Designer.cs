namespace HTMLTableGenerator
{
    partial class UCAdvancedOptions
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnStart = new System.Windows.Forms.NumericUpDown();
            this.rowStart = new System.Windows.Forms.NumericUpDown();
            this.columnSpan = new System.Windows.Forms.NumericUpDown();
            this.rowSpan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.columnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // columnStart
            // 
            this.columnStart.Location = new System.Drawing.Point(3, 24);
            this.columnStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnStart.Name = "columnStart";
            this.columnStart.Size = new System.Drawing.Size(48, 22);
            this.columnStart.TabIndex = 0;
            this.columnStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowStart
            // 
            this.rowStart.Location = new System.Drawing.Point(57, 24);
            this.rowStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowStart.Name = "rowStart";
            this.rowStart.Size = new System.Drawing.Size(48, 22);
            this.rowStart.TabIndex = 1;
            this.rowStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // columnSpan
            // 
            this.columnSpan.Location = new System.Drawing.Point(3, 52);
            this.columnSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnSpan.Name = "columnSpan";
            this.columnSpan.Size = new System.Drawing.Size(48, 22);
            this.columnSpan.TabIndex = 2;
            this.columnSpan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowSpan
            // 
            this.rowSpan.Location = new System.Drawing.Point(57, 52);
            this.rowSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowSpan.Name = "rowSpan";
            this.rowSpan.Size = new System.Drawing.Size(48, 22);
            this.rowSpan.TabIndex = 3;
            this.rowSpan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column   Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start cell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Merge Span";
            // 
            // UCAdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowSpan);
            this.Controls.Add(this.columnSpan);
            this.Controls.Add(this.rowStart);
            this.Controls.Add(this.columnStart);
            this.Name = "UCAdvancedOptions";
            this.Size = new System.Drawing.Size(260, 90);
            ((System.ComponentModel.ISupportInitialize)(this.columnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown columnStart;
        private System.Windows.Forms.NumericUpDown rowStart;
        private System.Windows.Forms.NumericUpDown columnSpan;
        private System.Windows.Forms.NumericUpDown rowSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
