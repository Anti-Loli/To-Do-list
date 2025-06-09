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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 12);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 1;
            label1.Text = "To Do List";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 124);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(168, 436);
            AddTaskButton.Margin = new Padding(3, 4, 3, 4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(118, 31);
            AddTaskButton.TabIndex = 4;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += button5_Click;
            // 
            // RemoveTaskButton
            // 
            RemoveTaskButton.Location = new Point(473, 436);
            RemoveTaskButton.Margin = new Padding(3, 4, 3, 4);
            RemoveTaskButton.Name = "RemoveTaskButton";
            RemoveTaskButton.Size = new Size(118, 31);
            RemoveTaskButton.TabIndex = 5;
            RemoveTaskButton.Text = "Remove Task";
            RemoveTaskButton.UseVisualStyleBackColor = true;
            RemoveTaskButton.Click += button6_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(120, 191);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.KeyPress += monthCalendar1_KeyPress;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(413, 69);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(237, 334);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            checkedListBox1.KeyPress += checkedListBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 128);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "Task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 191);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 9;
            label3.Text = "Due Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(RemoveTaskButton);
            Controls.Add(AddTaskButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
