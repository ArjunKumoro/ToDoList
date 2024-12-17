namespace ToDoApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            toDoListView = new DataGridView();
            label3 = new Label();
            timeTextBox = new TextBox();
            titleTextBox = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            descriptionTextBox = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(188, 35);
            label1.TabIndex = 0;
            label1.Text = "TO-DO LIST";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-4, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 85);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            label2.Location = new Point(87, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // toDoListView
            // 
            toDoListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.Control;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 94);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(359, 350);
            toDoListView.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 465);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
            label3.TabIndex = 3;
            label3.Text = "Time";
            // 
            // timeTextBox
            // 
            timeTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timeTextBox.Location = new Point(12, 492);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(255, 27);
            timeTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleTextBox.Location = new Point(12, 568);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(255, 27);
            titleTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 541);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.Control;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(288, 465);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 70);
            btnSave.TabIndex = 7;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = SystemColors.Control;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(288, 541);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 70);
            btnEdit.TabIndex = 8;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(288, 617);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 70);
            btnDelete.TabIndex = 9;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(12, 642);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(255, 27);
            descriptionTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 615);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 11;
            label5.Text = "Description";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(383, 698);
            Controls.Add(descriptionTextBox);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(titleTextBox);
            Controls.Add(label4);
            Controls.Add(timeTextBox);
            Controls.Add(label3);
            Controls.Add(toDoListView);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(401, 745);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView toDoListView;
        private Label label3;
        private TextBox timeTextBox;
        private TextBox titleTextBox;
        private Label label4;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox descriptionTextBox;
        private Label label5;
    }
}
