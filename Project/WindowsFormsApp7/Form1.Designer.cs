namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Bigger = new System.Windows.Forms.Button();
            this.btn_Less = new System.Windows.Forms.Button();
            this.btn_TrueNumber = new System.Windows.Forms.Button();
            this.lbl_question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess the number";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(43, 127);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(183, 52);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(43, 185);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(183, 52);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Bigger
            // 
            this.btn_Bigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Bigger.Location = new System.Drawing.Point(593, 130);
            this.btn_Bigger.Name = "btn_Bigger";
            this.btn_Bigger.Size = new System.Drawing.Size(183, 52);
            this.btn_Bigger.TabIndex = 3;
            this.btn_Bigger.Text = "More";
            this.btn_Bigger.UseVisualStyleBackColor = true;
            this.btn_Bigger.Visible = false;
            this.btn_Bigger.Click += new System.EventHandler(this.btn_Bigger_Click);
            // 
            // btn_Less
            // 
            this.btn_Less.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Less.Location = new System.Drawing.Point(593, 188);
            this.btn_Less.Name = "btn_Less";
            this.btn_Less.Size = new System.Drawing.Size(183, 52);
            this.btn_Less.TabIndex = 4;
            this.btn_Less.Text = "Less";
            this.btn_Less.UseVisualStyleBackColor = true;
            this.btn_Less.Visible = false;
            this.btn_Less.Click += new System.EventHandler(this.btn_Less_Click);
            // 
            // btn_TrueNumber
            // 
            this.btn_TrueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TrueNumber.Location = new System.Drawing.Point(593, 246);
            this.btn_TrueNumber.Name = "btn_TrueNumber";
            this.btn_TrueNumber.Size = new System.Drawing.Size(183, 52);
            this.btn_TrueNumber.TabIndex = 5;
            this.btn_TrueNumber.Text = "Guessed";
            this.btn_TrueNumber.UseVisualStyleBackColor = true;
            this.btn_TrueNumber.Visible = false;
            this.btn_TrueNumber.Click += new System.EventHandler(this.btn_TrueNumber_Click);
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_question.Location = new System.Drawing.Point(260, 159);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(0, 39);
            this.lbl_question.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.btn_TrueNumber);
            this.Controls.Add(this.btn_Less);
            this.Controls.Add(this.btn_Bigger);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Bigger;
        private System.Windows.Forms.Button btn_Less;
        private System.Windows.Forms.Button btn_TrueNumber;
        private System.Windows.Forms.Label lbl_question;
    }
}

