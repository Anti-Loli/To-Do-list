namespace TimCoreyWinFormDemo
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            AddTaskButton = new Button();
            RemoveTaskButton = new Button();
            monthCalendar1 = new MonthCalendar();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            CompletedTaskRemoveButton = new Button();
            TagComboBox = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            AlphaSortButton = new Button();
            TypeSortButton = new Button();
            DateSortButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            editTaskButton = new Button();
            UserFeedbackLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(344, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Anchor = AnchorStyles.None;
            AddTaskButton.Location = new Point(399, 384);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(103, 23);
            AddTaskButton.TabIndex = 4;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += button5_Click;
            // 
            // RemoveTaskButton
            // 
            RemoveTaskButton.Anchor = AnchorStyles.None;
            RemoveTaskButton.Location = new Point(139, 730);
            RemoveTaskButton.Name = "RemoveTaskButton";
            RemoveTaskButton.Size = new Size(103, 23);
            RemoveTaskButton.TabIndex = 5;
            RemoveTaskButton.Text = "Remove Task";
            RemoveTaskButton.UseVisualStyleBackColor = true;
            RemoveTaskButton.Click += button6_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.None;
            monthCalendar1.Location = new Point(344, 166);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.KeyPress += monthCalendar1_KeyPress;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(30, 460);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(345, 256);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            checkedListBox1.KeyPress += checkedListBox1_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(299, 118);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Task:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(274, 166);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Due Date:";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(526, 460);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 259);
            listBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(606, 420);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 11;
            label4.Text = "Completed Tasks";
            // 
            // CompletedTaskRemoveButton
            // 
            CompletedTaskRemoveButton.Anchor = AnchorStyles.None;
            CompletedTaskRemoveButton.Location = new Point(631, 730);
            CompletedTaskRemoveButton.Margin = new Padding(3, 2, 3, 2);
            CompletedTaskRemoveButton.Name = "CompletedTaskRemoveButton";
            CompletedTaskRemoveButton.Size = new Size(103, 22);
            CompletedTaskRemoveButton.TabIndex = 12;
            CompletedTaskRemoveButton.Text = "Delete List\r\n";
            CompletedTaskRemoveButton.UseVisualStyleBackColor = true;
            CompletedTaskRemoveButton.Click += CompletedTaskRemoveButton_Click;
            // 
            // TagComboBox
            // 
            TagComboBox.Anchor = AnchorStyles.None;
            TagComboBox.FormattingEnabled = true;
            TagComboBox.Items.AddRange(new object[] { "Family", "Finance", "Health", "Hobby", "Personal", "School", "Shopping", "Travel", "Work" });
            TagComboBox.Location = new Point(344, 340);
            TagComboBox.Name = "TagComboBox";
            TagComboBox.Size = new Size(227, 23);
            TagComboBox.TabIndex = 14;
            TagComboBox.KeyPress += tagComboBox_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 420);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 15;
            label5.Text = "To Do List";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 77);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 16;
            label1.Text = "Create new task";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(299, 343);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 17;
            label6.Text = "Tag:";
            // 
            // AlphaSortButton
            // 
            AlphaSortButton.Anchor = AnchorStyles.None;
            AlphaSortButton.Location = new Point(381, 461);
            AlphaSortButton.Name = "AlphaSortButton";
            AlphaSortButton.Size = new Size(139, 23);
            AlphaSortButton.TabIndex = 18;
            AlphaSortButton.Text = "Sort Alphabetically ";
            AlphaSortButton.UseVisualStyleBackColor = true;
            AlphaSortButton.Click += AlphaSortButton_Click;
            // 
            // TypeSortButton
            // 
            TypeSortButton.Anchor = AnchorStyles.None;
            TypeSortButton.Location = new Point(381, 519);
            TypeSortButton.Name = "TypeSortButton";
            TypeSortButton.Size = new Size(139, 23);
            TypeSortButton.TabIndex = 19;
            TypeSortButton.Text = "Sort by Type";
            TypeSortButton.UseVisualStyleBackColor = true;
            TypeSortButton.Click += TypeSortButton_Click;
            // 
            // DateSortButton
            // 
            DateSortButton.Anchor = AnchorStyles.None;
            DateSortButton.Location = new Point(381, 490);
            DateSortButton.Name = "DateSortButton";
            DateSortButton.Size = new Size(139, 23);
            DateSortButton.TabIndex = 20;
            DateSortButton.Text = "Sort by Date";
            DateSortButton.UseVisualStyleBackColor = true;
            DateSortButton.Click += DateSortButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // editTaskButton
            // 
            editTaskButton.Anchor = AnchorStyles.None;
            editTaskButton.Location = new Point(381, 548);
            editTaskButton.Name = "editTaskButton";
            editTaskButton.Size = new Size(139, 23);
            editTaskButton.TabIndex = 21;
            editTaskButton.Text = "Edit Task";
            editTaskButton.UseVisualStyleBackColor = true;
            editTaskButton.Click += editTaskButton_Click;
            // 
            // UserFeedbackLabel
            // 
            UserFeedbackLabel.Anchor = AnchorStyles.None;
            UserFeedbackLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserFeedbackLabel.Location = new Point(344, 6);
            UserFeedbackLabel.Name = "UserFeedbackLabel";
            UserFeedbackLabel.Size = new Size(227, 71);
            UserFeedbackLabel.TabIndex = 22;
            UserFeedbackLabel.Text = "label7";
            UserFeedbackLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(875, 793);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox1);
            Controls.Add(AddTaskButton);
            Controls.Add(UserFeedbackLabel);
            Controls.Add(label2);
            Controls.Add(editTaskButton);
            Controls.Add(label3);
            Controls.Add(DateSortButton);
            Controls.Add(TagComboBox);
            Controls.Add(TypeSortButton);
            Controls.Add(label6);
            Controls.Add(AlphaSortButton);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(CompletedTaskRemoveButton);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(RemoveTaskButton);
            Name = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button AddTaskButton;
        private Button RemoveTaskButton;
        private MonthCalendar monthCalendar1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private Button CompletedTaskRemoveButton;
        private ComboBox TagComboBox;
        private Label label5;
        private Label label1;
        private Label label6;
        private Button AlphaSortButton;
        private Button TypeSortButton;
        private Button DateSortButton;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private Button editTaskButton;
        private Label UserFeedbackLabel;
    }
}
