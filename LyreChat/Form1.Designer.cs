namespace LyreChat
{
    partial class Window
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
            this.Say = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.narrator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Say
            // 
            this.Say.Location = new System.Drawing.Point(333, 57);
            this.Say.Name = "Say";
            this.Say.Size = new System.Drawing.Size(75, 23);
            this.Say.TabIndex = 1;
            this.Say.Text = "Say";
            this.Say.UseVisualStyleBackColor = true;
            this.Say.Click += new System.EventHandler(this.Say_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max 500 characters";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(29, 59);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(298, 106);
            this.Input.TabIndex = 3;
            this.Input.Text = "";
            // 
            // narrator
            // 
            this.narrator.FormattingEnabled = true;
            this.narrator.Items.AddRange(new object[] {
            "ethan",
            "don",
            "malcom",
            "carla",
            "emily",
            "nancy"});
            this.narrator.Location = new System.Drawing.Point(334, 121);
            this.narrator.Name = "narrator";
            this.narrator.Size = new System.Drawing.Size(121, 21);
            this.narrator.TabIndex = 4;
            this.narrator.Text = "don";
            this.narrator.SelectedIndexChanged += new System.EventHandler(this.narrator_SelectedIndexChanged);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 204);
            this.Controls.Add(this.narrator);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Say);
            this.Name = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Say;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.ComboBox narrator;
    }
}

