namespace GUI;

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
            this.no_sym = new System.Windows.Forms.Button();
            this.yes_sym = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.no_copy = new System.Windows.Forms.Button();
            this.yes_copy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_rmdir = new System.Windows.Forms.Button();
            this.yes_rmdir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no_sym
            // 
            this.no_sym.Location = new System.Drawing.Point(93, 168);
            this.no_sym.Name = "no_sym";
            this.no_sym.Size = new System.Drawing.Size(75, 23);
            this.no_sym.TabIndex = 30;
            this.no_sym.Text = "Remove";
            this.no_sym.UseVisualStyleBackColor = true;
            this.no_sym.Click += new System.EventHandler(this.no_sym_Click);
            // 
            // yes_sym
            // 
            this.yes_sym.Location = new System.Drawing.Point(12, 168);
            this.yes_sym.Name = "yes_sym";
            this.yes_sym.Size = new System.Drawing.Size(75, 23);
            this.yes_sym.TabIndex = 29;
            this.yes_sym.Text = "Add";
            this.yes_sym.UseVisualStyleBackColor = true;
            this.yes_sym.Click += new System.EventHandler(this.yes_sym_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Add/Remove folder symlink creator in context menu?";
            // 
            // no_copy
            // 
            this.no_copy.Location = new System.Drawing.Point(93, 109);
            this.no_copy.Name = "no_copy";
            this.no_copy.Size = new System.Drawing.Size(75, 23);
            this.no_copy.TabIndex = 24;
            this.no_copy.Text = "Remove";
            this.no_copy.UseVisualStyleBackColor = true;
            this.no_copy.Click += new System.EventHandler(this.no_copy_Click);
            // 
            // yes_copy
            // 
            this.yes_copy.Location = new System.Drawing.Point(12, 109);
            this.yes_copy.Name = "yes_copy";
            this.yes_copy.Size = new System.Drawing.Size(75, 23);
            this.yes_copy.TabIndex = 23;
            this.yes_copy.Text = "Add";
            this.yes_copy.UseVisualStyleBackColor = true;
            this.yes_copy.Click += new System.EventHandler(this.yes_copy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add/Remove robocopy/cut and background robopaste in context menu?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add/Remove folder RMDIR in context menu?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "(You must reenable these if you move the executables)";
            // 
            // remove_rmdir
            // 
            this.remove_rmdir.Location = new System.Drawing.Point(93, 54);
            this.remove_rmdir.Name = "remove_rmdir";
            this.remove_rmdir.Size = new System.Drawing.Size(75, 23);
            this.remove_rmdir.TabIndex = 19;
            this.remove_rmdir.Text = "Remove";
            this.remove_rmdir.UseVisualStyleBackColor = true;
            this.remove_rmdir.Click += new System.EventHandler(this.remove_rmdir_Click);
            // 
            // yes_rmdir
            // 
            this.yes_rmdir.Location = new System.Drawing.Point(12, 54);
            this.yes_rmdir.Name = "yes_rmdir";
            this.yes_rmdir.Size = new System.Drawing.Size(75, 23);
            this.yes_rmdir.TabIndex = 18;
            this.yes_rmdir.Text = "Add";
            this.yes_rmdir.UseVisualStyleBackColor = true;
            this.yes_rmdir.Click += new System.EventHandler(this.yes_rmdir_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-2, 28);
            this.label4.MaximumSize = new System.Drawing.Size(0, 1);
            this.label4.MinimumSize = new System.Drawing.Size(290, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 1);
            this.label4.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.no_sym);
            this.Controls.Add(this.yes_sym);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no_copy);
            this.Controls.Add(this.yes_copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove_rmdir);
            this.Controls.Add(this.yes_rmdir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File-Tools Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button no_sym;
    private Button yes_sym;
    private Label label5;
    private Button no_copy;
    private Button yes_copy;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button remove_rmdir;
    private Button yes_rmdir;
    private Label label4;
}
