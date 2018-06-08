namespace HTMLTableGenerator
{
    partial class UCTableData
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
            this.LabelRow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BAddAdvancedOption = new System.Windows.Forms.Button();
            this.BRemoveAdvancedOption = new System.Windows.Forms.Button();
            this.LabelAdvOpt = new System.Windows.Forms.Label();
            this.TBColumn = new System.Windows.Forms.NumericUpDown();
            this.TBRow = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TBColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBRow)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRow
            // 
            this.LabelRow.AutoSize = true;
            this.LabelRow.Location = new System.Drawing.Point(153, 15);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.Size = new System.Drawing.Size(35, 17);
            this.LabelRow.TabIndex = 2;
            this.LabelRow.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Column";
            // 
            // BAddAdvancedOption
            // 
            this.BAddAdvancedOption.Location = new System.Drawing.Point(303, 34);
            this.BAddAdvancedOption.Name = "BAddAdvancedOption";
            this.BAddAdvancedOption.Size = new System.Drawing.Size(20, 23);
            this.BAddAdvancedOption.TabIndex = 4;
            this.BAddAdvancedOption.Text = "+";
            this.BAddAdvancedOption.UseVisualStyleBackColor = true;
            this.BAddAdvancedOption.Click += new System.EventHandler(this.ADvancedOptionButton);
            // 
            // BRemoveAdvancedOption
            // 
            this.BRemoveAdvancedOption.Location = new System.Drawing.Point(329, 35);
            this.BRemoveAdvancedOption.Name = "BRemoveAdvancedOption";
            this.BRemoveAdvancedOption.Size = new System.Drawing.Size(20, 23);
            this.BRemoveAdvancedOption.TabIndex = 5;
            this.BRemoveAdvancedOption.Text = "-";
            this.BRemoveAdvancedOption.UseVisualStyleBackColor = true;
            this.BRemoveAdvancedOption.Click += new System.EventHandler(this.ADvancedOptionButton);
            // 
            // LabelAdvOpt
            // 
            this.LabelAdvOpt.AutoSize = true;
            this.LabelAdvOpt.Location = new System.Drawing.Point(272, 14);
            this.LabelAdvOpt.Name = "LabelAdvOpt";
            this.LabelAdvOpt.Size = new System.Drawing.Size(101, 17);
            this.LabelAdvOpt.TabIndex = 6;
            this.LabelAdvOpt.Text = "Merge Options";
            // 
            // TBColumn
            // 
            this.TBColumn.Location = new System.Drawing.Point(30, 36);
            this.TBColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TBColumn.Name = "TBColumn";
            this.TBColumn.Size = new System.Drawing.Size(120, 22);
            this.TBColumn.TabIndex = 7;
            this.TBColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TBRow
            // 
            this.TBRow.Location = new System.Drawing.Point(156, 36);
            this.TBRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TBRow.Name = "TBRow";
            this.TBRow.Size = new System.Drawing.Size(120, 22);
            this.TBRow.TabIndex = 8;
            this.TBRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UCTableData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.TBRow);
            this.Controls.Add(this.TBColumn);
            this.Controls.Add(this.LabelAdvOpt);
            this.Controls.Add(this.BRemoveAdvancedOption);
            this.Controls.Add(this.BAddAdvancedOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelRow);
            this.Name = "UCTableData";
            this.Size = new System.Drawing.Size(465, 619);
            ((System.ComponentModel.ISupportInitialize)(this.TBColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAddAdvancedOption;
        private System.Windows.Forms.Button BRemoveAdvancedOption;
        private System.Windows.Forms.Label LabelAdvOpt;
        private System.Windows.Forms.NumericUpDown TBColumn;
        private System.Windows.Forms.NumericUpDown TBRow;
    }
}
