namespace SQL
{
    partial class MainScreen
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlInsert = new System.Windows.Forms.Button();
            this.sqlDelete = new System.Windows.Forms.Button();
            this.sqlUpdate = new System.Windows.Forms.Button();
            this.sqlSelect = new System.Windows.Forms.Button();
            this.sqlExit = new System.Windows.Forms.Button();
            this.chowe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqlInsert
            // 
            this.sqlInsert.Location = new System.Drawing.Point(40, 60);
            this.sqlInsert.Name = "sqlInsert";
            this.sqlInsert.Size = new System.Drawing.Size(75, 23);
            this.sqlInsert.TabIndex = 0;
            this.sqlInsert.Text = "Insert";
            this.sqlInsert.UseVisualStyleBackColor = true;
            this.sqlInsert.Click += new System.EventHandler(this.sqlInsert_Click);
            // 
            // sqlDelete
            // 
            this.sqlDelete.Location = new System.Drawing.Point(160, 60);
            this.sqlDelete.Name = "sqlDelete";
            this.sqlDelete.Size = new System.Drawing.Size(75, 23);
            this.sqlDelete.TabIndex = 1;
            this.sqlDelete.Text = "Delete";
            this.sqlDelete.UseVisualStyleBackColor = true;
            this.sqlDelete.Click += new System.EventHandler(this.sqlDelete_Click);
            // 
            // sqlUpdate
            // 
            this.sqlUpdate.Location = new System.Drawing.Point(40, 150);
            this.sqlUpdate.Name = "sqlUpdate";
            this.sqlUpdate.Size = new System.Drawing.Size(75, 23);
            this.sqlUpdate.TabIndex = 2;
            this.sqlUpdate.Text = "Update";
            this.sqlUpdate.UseVisualStyleBackColor = true;
            this.sqlUpdate.Click += new System.EventHandler(this.sqlUpdate_Click);
            // 
            // sqlSelect
            // 
            this.sqlSelect.Location = new System.Drawing.Point(160, 150);
            this.sqlSelect.Name = "sqlSelect";
            this.sqlSelect.Size = new System.Drawing.Size(75, 23);
            this.sqlSelect.TabIndex = 3;
            this.sqlSelect.Text = "Select";
            this.sqlSelect.UseVisualStyleBackColor = true;
            this.sqlSelect.Click += new System.EventHandler(this.sqlSelect_Click);
            // 
            // sqlExit
            // 
            this.sqlExit.Location = new System.Drawing.Point(170, 300);
            this.sqlExit.Name = "sqlExit";
            this.sqlExit.Size = new System.Drawing.Size(75, 23);
            this.sqlExit.TabIndex = 4;
            this.sqlExit.Text = "Exit";
            this.sqlExit.UseVisualStyleBackColor = true;
            this.sqlExit.Click += new System.EventHandler(this.sqlExit_Click);
            // 
            // chowe
            // 
            this.chowe.AutoSize = true;
            this.chowe.Location = new System.Drawing.Point(90, 220);
            this.chowe.Name = "chowe";
            this.chowe.Size = new System.Drawing.Size(107, 12);
            this.chowe.TabIndex = 5;
            this.chowe.Text = "Powered by Chowe.";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.chowe);
            this.Controls.Add(this.sqlExit);
            this.Controls.Add(this.sqlSelect);
            this.Controls.Add(this.sqlUpdate);
            this.Controls.Add(this.sqlDelete);
            this.Controls.Add(this.sqlInsert);
            this.Name = "MainScreen";
            this.Text = "数据库操作";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sqlInsert;
        private System.Windows.Forms.Button sqlDelete;
        private System.Windows.Forms.Button sqlUpdate;
        private System.Windows.Forms.Button sqlSelect;
        private System.Windows.Forms.Button sqlExit;
        private System.Windows.Forms.Label chowe;
    }
}

