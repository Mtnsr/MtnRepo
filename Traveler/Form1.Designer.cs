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
            this.label1 = new System.Windows.Forms.Label();
            this.rightCoorTxtBox = new System.Windows.Forms.TextBox();
            this.commandTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.robotCoorTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Düzlem Boyutu";
            // 
            // rightCoorTxtBox
            // 
            this.rightCoorTxtBox.Location = new System.Drawing.Point(393, 84);
            this.rightCoorTxtBox.Name = "rightCoorTxtBox";
            this.rightCoorTxtBox.Size = new System.Drawing.Size(190, 22);
            this.rightCoorTxtBox.TabIndex = 1;
            this.rightCoorTxtBox.Leave += new System.EventHandler(this.rightCoorTxtBox_Leave);
            // 
            // commandTxtBox
            // 
            this.commandTxtBox.Location = new System.Drawing.Point(393, 186);
            this.commandTxtBox.Name = "commandTxtBox";
            this.commandTxtBox.Size = new System.Drawing.Size(190, 22);
            this.commandTxtBox.TabIndex = 3;
            this.commandTxtBox.Leave += new System.EventHandler(this.commandTxtBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Komut Katarı";
            // 
            // robotCoorTxtBox
            // 
            this.robotCoorTxtBox.Location = new System.Drawing.Point(393, 137);
            this.robotCoorTxtBox.Name = "robotCoorTxtBox";
            this.robotCoorTxtBox.Size = new System.Drawing.Size(190, 22);
            this.robotCoorTxtBox.TabIndex = 5;
            this.robotCoorTxtBox.Leave += new System.EventHandler(this.robotCoorTxtBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlangıç Koordinatı";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(393, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.robotCoorTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commandTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightCoorTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rightCoorTxtBox;
        private System.Windows.Forms.TextBox commandTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox robotCoorTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
    }
}

