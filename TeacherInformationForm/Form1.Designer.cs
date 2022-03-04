namespace TeacherInformationForm
{
    partial class Form1
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
            this.buttonWritedata = new System.Windows.Forms.Button();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTeacherId = new System.Windows.Forms.TextBox();
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonWritedata
            // 
            this.buttonWritedata.Location = new System.Drawing.Point(56, 31);
            this.buttonWritedata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonWritedata.Name = "buttonWritedata";
            this.buttonWritedata.Size = new System.Drawing.Size(94, 29);
            this.buttonWritedata.TabIndex = 0;
            this.buttonWritedata.Text = "Write Data";
            this.buttonWritedata.UseVisualStyleBackColor = true;
            this.buttonWritedata.Click += new System.EventHandler(this.buttonWritedata_Click);
            // 
            // buttonReadData
            // 
            this.buttonReadData.Location = new System.Drawing.Point(56, 105);
            this.buttonReadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(94, 29);
            this.buttonReadData.TabIndex = 1;
            this.buttonReadData.Text = "Read Data";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(198, 31);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(108, 29);
            this.buttonAddToList.TabIndex = 2;
            this.buttonAddToList.Text = "Add To List";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(198, 105);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(108, 29);
            this.buttonList.TabIndex = 3;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(397, 31);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 29);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher ID";
            // 
            // textBoxTeacherId
            // 
            this.textBoxTeacherId.Location = new System.Drawing.Point(397, 139);
            this.textBoxTeacherId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeacherId.Name = "textBoxTeacherId";
            this.textBoxTeacherId.Size = new System.Drawing.Size(112, 26);
            this.textBoxTeacherId.TabIndex = 6;
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeacher.HideSelection = false;
            this.listViewTeacher.Location = new System.Drawing.Point(56, 271);
            this.listViewTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(598, 213);
            this.listViewTeacher.TabIndex = 7;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            this.listViewTeacher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Teacher ID";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 161;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 528);
            this.Controls.Add(this.listViewTeacher);
            this.Controls.Add(this.textBoxTeacherId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.buttonReadData);
            this.Controls.Add(this.buttonWritedata);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWritedata;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTeacherId;
        private System.Windows.Forms.ListView listViewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

