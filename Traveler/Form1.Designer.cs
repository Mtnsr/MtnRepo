namespace Traveler
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
            this.planeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.commandTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstLocTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // planeTxtBox
            // 
            this.planeTxtBox.Location = new System.Drawing.Point(391, 88);
            this.planeTxtBox.Name = "planeTxtBox";
            this.planeTxtBox.Size = new System.Drawing.Size(177, 22);
            this.planeTxtBox.TabIndex = 0;
            this.planeTxtBox.Leave += new System.EventHandler(this.planeTxtBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Düzlem Boyutu";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(391, 236);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(177, 34);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Başlat";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Komut Katarı";
            // 
            // commandTxtBox
            // 
            this.commandTxtBox.Location = new System.Drawing.Point(391, 167);
            this.commandTxtBox.Name = "commandTxtBox";
            this.commandTxtBox.Size = new System.Drawing.Size(177, 22);
            this.commandTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Başlangıç Konumu";
            // 
            // firstLocTxtBox
            // 
            this.firstLocTxtBox.Location = new System.Drawing.Point(391, 126);
            this.firstLocTxtBox.Name = "firstLocTxtBox";
            this.firstLocTxtBox.Size = new System.Drawing.Size(177, 22);
            this.firstLocTxtBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstLocTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commandTxtBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planeTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox planeTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstLocTxtBox;
    }
}

