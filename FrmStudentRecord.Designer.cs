namespace CreateTextFile2
{
    partial class FrmStudentRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerBTN = new System.Windows.Forms.Button();
            this.findBTN = new System.Windows.Forms.Button();
            this.uploadBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // registerBTN
            // 
            this.registerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBTN.Location = new System.Drawing.Point(404, 37);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(75, 26);
            this.registerBTN.TabIndex = 0;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // findBTN
            // 
            this.findBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBTN.Location = new System.Drawing.Point(404, 69);
            this.findBTN.Name = "findBTN";
            this.findBTN.Size = new System.Drawing.Size(75, 26);
            this.findBTN.TabIndex = 1;
            this.findBTN.Text = "Find";
            this.findBTN.UseVisualStyleBackColor = true;
            this.findBTN.Click += new System.EventHandler(this.findBTN_Click);
            // 
            // uploadBTN
            // 
            this.uploadBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBTN.Location = new System.Drawing.Point(404, 101);
            this.uploadBTN.Name = "uploadBTN";
            this.uploadBTN.Size = new System.Drawing.Size(75, 26);
            this.uploadBTN.TabIndex = 2;
            this.uploadBTN.Text = "Upload";
            this.uploadBTN.UseVisualStyleBackColor = true;
            this.uploadBTN.Click += new System.EventHandler(this.uploadBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Record";
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(17, 37);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(381, 204);
            this.listview.TabIndex = 4;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Uploaded!";
            this.columnHeader1.Width = 500;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog2";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 253);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadBTN);
            this.Controls.Add(this.findBTN);
            this.Controls.Add(this.registerBTN);
            this.Name = "FrmStudentRecord";
            this.Text = "Student Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.Button findBTN;
        private System.Windows.Forms.Button uploadBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}

