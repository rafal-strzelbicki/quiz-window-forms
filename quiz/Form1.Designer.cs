
namespace quiz
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
            this.btn_create_quiz = new System.Windows.Forms.Button();
            this.list_quiz_list = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_create_quiz
            // 
            this.btn_create_quiz.Location = new System.Drawing.Point(60, 164);
            this.btn_create_quiz.Name = "btn_create_quiz";
            this.btn_create_quiz.Size = new System.Drawing.Size(150, 56);
            this.btn_create_quiz.TabIndex = 0;
            this.btn_create_quiz.Text = "Create quiz";
            this.btn_create_quiz.UseVisualStyleBackColor = true;
            this.btn_create_quiz.Click += new System.EventHandler(this.btn_create_quiz_Click);
            // 
            // list_quiz_list
            // 
            this.list_quiz_list.HideSelection = false;
            this.list_quiz_list.Location = new System.Drawing.Point(361, 99);
            this.list_quiz_list.Name = "list_quiz_list";
            this.list_quiz_list.Size = new System.Drawing.Size(182, 234);
            this.list_quiz_list.TabIndex = 1;
            this.list_quiz_list.UseCompatibleStateImageBehavior = false;
            this.list_quiz_list.SelectedIndexChanged += new System.EventHandler(this.list_quiz_list_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_quiz_list);
            this.Controls.Add(this.btn_create_quiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_create_quiz;
        private System.Windows.Forms.ListView list_quiz_list;
    }
}

