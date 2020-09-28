namespace BridgeImporter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectExcelFilePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectExportFilePath = new System.Windows.Forms.Button();
            this.buttonSelectImportFolderPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectExcelFilePath
            // 
            this.buttonSelectExcelFilePath.Location = new System.Drawing.Point(355, 78);
            this.buttonSelectExcelFilePath.Name = "buttonSelectExcelFilePath";
            this.buttonSelectExcelFilePath.Size = new System.Drawing.Size(89, 31);
            this.buttonSelectExcelFilePath.TabIndex = 0;
            this.buttonSelectExcelFilePath.Text = "選択";
            this.buttonSelectExcelFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectExcelFilePath.Click += new System.EventHandler(this.buttonSelectExcelFilePath_Click_1);
            // 
            // buttonSelectExportFilePath
            // 
            this.buttonSelectExportFilePath.Location = new System.Drawing.Point(355, 175);
            this.buttonSelectExportFilePath.Name = "buttonSelectExportFilePath";
            this.buttonSelectExportFilePath.Size = new System.Drawing.Size(89, 37);
            this.buttonSelectExportFilePath.TabIndex = 1;
            this.buttonSelectExportFilePath.Text = "選択";
            this.buttonSelectExportFilePath.UseVisualStyleBackColor = true;
            this.buttonSelectExportFilePath.Click += new System.EventHandler(this.buttonSelectExportFilePath_Click);
            // 
            // buttonSelectImportFolderPath
            // 
            this.buttonSelectImportFolderPath.Location = new System.Drawing.Point(355, 280);
            this.buttonSelectImportFolderPath.Name = "buttonSelectImportFolderPath";
            this.buttonSelectImportFolderPath.Size = new System.Drawing.Size(89, 37);
            this.buttonSelectImportFolderPath.TabIndex = 2;
            this.buttonSelectImportFolderPath.Text = "選択";
            this.buttonSelectImportFolderPath.UseVisualStyleBackColor = true;
            this.buttonSelectImportFolderPath.Click += new System.EventHandler(this.buttonSelectImportFolderPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "エクセルファイル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "nsipsサンプル出力";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "レセコン連動";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "選択されていません";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "選択されていません";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "選択されていません";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(355, 364);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "出力数";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(244, 436);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(123, 36);
            this.buttonImport.TabIndex = 11;
            this.buttonImport.Text = "インポート";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 511);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectImportFolderPath);
            this.Controls.Add(this.buttonSelectExportFilePath);
            this.Controls.Add(this.buttonSelectExcelFilePath);
            this.Name = "Form1";
            this.Text = "パス、出力数を選択してください";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectExcelFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectExportFilePath;
        private System.Windows.Forms.Button buttonSelectImportFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
    }
}

