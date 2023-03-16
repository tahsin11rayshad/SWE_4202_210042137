namespace Lab_09
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.log_in_button2 = new System.Windows.Forms.Button();
            this.new_name_textBox = new System.Windows.Forms.TextBox();
            this.new_username_textBox = new System.Windows.Forms.TextBox();
            this.new_password_textBox = new System.Windows.Forms.TextBox();
            this.retype_textBox = new System.Windows.Forms.TextBox();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-type Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Already have an account?";
            // 
            // log_in_button2
            // 
            this.log_in_button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log_in_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log_in_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in_button2.ForeColor = System.Drawing.Color.Red;
            this.log_in_button2.Location = new System.Drawing.Point(453, 453);
            this.log_in_button2.Name = "log_in_button2";
            this.log_in_button2.Size = new System.Drawing.Size(190, 43);
            this.log_in_button2.TabIndex = 7;
            this.log_in_button2.Text = "Log In!";
            this.log_in_button2.UseVisualStyleBackColor = false;
            this.log_in_button2.Click += new System.EventHandler(this.log_in_button2_Click);
            // 
            // new_name_textBox
            // 
            this.new_name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_name_textBox.Location = new System.Drawing.Point(282, 97);
            this.new_name_textBox.Name = "new_name_textBox";
            this.new_name_textBox.Size = new System.Drawing.Size(240, 34);
            this.new_name_textBox.TabIndex = 8;
            // 
            // new_username_textBox
            // 
            this.new_username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_username_textBox.Location = new System.Drawing.Point(282, 156);
            this.new_username_textBox.Name = "new_username_textBox";
            this.new_username_textBox.Size = new System.Drawing.Size(240, 34);
            this.new_username_textBox.TabIndex = 9;
            this.new_username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // new_password_textBox
            // 
            this.new_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_textBox.Location = new System.Drawing.Point(282, 222);
            this.new_password_textBox.Name = "new_password_textBox";
            this.new_password_textBox.Size = new System.Drawing.Size(240, 34);
            this.new_password_textBox.TabIndex = 10;
            // 
            // retype_textBox
            // 
            this.retype_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype_textBox.Location = new System.Drawing.Point(282, 281);
            this.retype_textBox.Name = "retype_textBox";
            this.retype_textBox.Size = new System.Drawing.Size(240, 34);
            this.retype_textBox.TabIndex = 11;
            // 
            // sign_up_button
            // 
            this.sign_up_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.sign_up_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_button.ForeColor = System.Drawing.Color.White;
            this.sign_up_button.Location = new System.Drawing.Point(282, 347);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(190, 66);
            this.sign_up_button.TabIndex = 12;
            this.sign_up_button.Text = "Sign Up";
            this.sign_up_button.UseVisualStyleBackColor = false;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 572);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.retype_textBox);
            this.Controls.Add(this.new_password_textBox);
            this.Controls.Add(this.new_username_textBox);
            this.Controls.Add(this.new_name_textBox);
            this.Controls.Add(this.log_in_button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button log_in_button2;
        private System.Windows.Forms.TextBox new_name_textBox;
        private System.Windows.Forms.TextBox new_username_textBox;
        private System.Windows.Forms.TextBox new_password_textBox;
        private System.Windows.Forms.TextBox retype_textBox;
        private System.Windows.Forms.Button sign_up_button;
    }
}