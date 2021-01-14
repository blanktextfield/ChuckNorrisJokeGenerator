namespace ChuckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Haha = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Haha
            // 
            this.Haha.Location = new System.Drawing.Point(382, 371);
            this.Haha.Name = "Haha";
            this.Haha.Size = new System.Drawing.Size(120, 62);
            this.Haha.TabIndex = 0;
            this.Haha.Text = "Big funny";
            this.Haha.UseVisualStyleBackColor = true;
            this.Haha.Click += new System.EventHandler(this.Haha_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(284, 183);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(350, 123);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Wait for Haha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.Haha);
            this.Name = "Form1";
            this.Text = "CN Joke Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Haha;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

