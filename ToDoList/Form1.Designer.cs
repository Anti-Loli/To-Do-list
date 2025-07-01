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
            label1 = new Label();
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 1;
            label1.Text = "To Do List";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(147, 277);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(103, 23);
            AddTaskButton.TabIndex = 4;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += button5_Click;
            // 
            // RemoveTaskButton
            // 
            RemoveTaskButton.Location = new Point(458, 316);
            RemoveTaskButton.Name = "RemoveTaskButton";
            RemoveTaskButton.Size = new Size(103, 23);
            RemoveTaskButton.TabIndex = 5;
            RemoveTaskButton.Text = "Remove Task";
            RemoveTaskButton.UseVisualStyleBackColor = true;
            RemoveTaskButton.Click += button6_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(100, 110);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.KeyPress += monthCalendar1_KeyPress;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(361, 59);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(302, 238);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            checkedListBox1.KeyPress += checkedListBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 62);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Due Date:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(680, 59);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(196, 244);
            listBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(704, 22);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 11;
            label4.Text = "Completed Tasks";
            // 
            // CompletedTaskRemoveButton
            // 
            CompletedTaskRemoveButton.Location = new Point(727, 316);
            CompletedTaskRemoveButton.Margin = new Padding(3, 2, 3, 2);
            CompletedTaskRemoveButton.Name = "CompletedTaskRemoveButton";
            CompletedTaskRemoveButton.Size = new Size(103, 22);
            CompletedTaskRemoveButton.TabIndex = 12;
            CompletedTaskRemoveButton.Text = "Delete List\r\n";
            CompletedTaskRemoveButton.UseVisualStyleBackColor = true;
            CompletedTaskRemoveButton.Click += CompletedTaskRemoveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(CompletedTaskRemoveButton);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(RemoveTaskButton);
            Controls.Add(AddTaskButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}
