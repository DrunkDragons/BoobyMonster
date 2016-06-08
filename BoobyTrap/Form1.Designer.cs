namespace BoobyTrap
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
            this.Title = new System.Windows.Forms.Label();
            this.LL = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(478, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(135, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome to BoobyMonster";
            // 
            // LL
            // 
            this.LL.Location = new System.Drawing.Point(54, 101);
            this.LL.Name = "LL";
            this.LL.Size = new System.Drawing.Size(75, 23);
            this.LL.TabIndex = 1;
            this.LL.Text = "LooseLeaf";
            this.LL.UseVisualStyleBackColor = true;
            this.LL.Click += new System.EventHandler(this.LL_Click);
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(54, 141);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(75, 23);
            this.L.TabIndex = 2;
            this.L.Text = "List";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(54, 182);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 23);
            this.C.TabIndex = 3;
            this.C.Text = "Calculator";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1076, 517);
            this.Controls.Add(this.C);
            this.Controls.Add(this.L);
            this.Controls.Add(this.LL);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Note;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LL;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button C;
    }
}

