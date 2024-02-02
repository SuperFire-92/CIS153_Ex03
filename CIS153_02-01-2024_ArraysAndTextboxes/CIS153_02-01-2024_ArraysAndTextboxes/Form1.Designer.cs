namespace CIS153_02_01_2024_ArraysAndTextboxes
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_addName = new System.Windows.Forms.Button();
            this.btn_displayNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(232, 130);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(519, 53);
            this.txt_name.TabIndex = 0;
            // 
            // btn_addName
            // 
            this.btn_addName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addName.Location = new System.Drawing.Point(12, 393);
            this.btn_addName.Name = "btn_addName";
            this.btn_addName.Size = new System.Drawing.Size(436, 206);
            this.btn_addName.TabIndex = 1;
            this.btn_addName.Text = "Add Name";
            this.btn_addName.UseVisualStyleBackColor = true;
            this.btn_addName.Click += new System.EventHandler(this.btn_addName_Click);
            // 
            // btn_displayNames
            // 
            this.btn_displayNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_displayNames.Location = new System.Drawing.Point(544, 393);
            this.btn_displayNames.Name = "btn_displayNames";
            this.btn_displayNames.Size = new System.Drawing.Size(436, 206);
            this.btn_displayNames.TabIndex = 2;
            this.btn_displayNames.Text = "Display Names";
            this.btn_displayNames.UseVisualStyleBackColor = true;
            this.btn_displayNames.Click += new System.EventHandler(this.btn_displayNames_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(408, 196);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(343, 46);
            this.lbl_error.TabIndex = 4;
            this.lbl_error.Text = "Error: Enter Name";
            this.lbl_error.Visible = false;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.Location = new System.Drawing.Point(232, 196);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(0, 46);
            this.lbl_success.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_displayNames);
            this.Controls.Add(this.btn_addName);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_addName;
        private System.Windows.Forms.Button btn_displayNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_success;
    }
}

