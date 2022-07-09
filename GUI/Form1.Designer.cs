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
            this.no_note = new System.Windows.Forms.Button();
            this.yes_note = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.no_compact = new System.Windows.Forms.Button();
            this.yes_compact = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.no_path = new System.Windows.Forms.Button();
            this.yes_path = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.no_batch = new System.Windows.Forms.Button();
            this.yes_batch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no_sym
            // 
            this.no_sym.Location = new System.Drawing.Point(93, 167);
            this.no_sym.Name = "no_sym";
            this.no_sym.Size = new System.Drawing.Size(75, 23);
            this.no_sym.TabIndex = 30;
            this.no_sym.Text = "Remove";
            this.no_sym.UseVisualStyleBackColor = true;
            this.no_sym.Click += new System.EventHandler(this.no_sym_Click);
            // 
            // yes_sym
            // 
            this.yes_sym.Location = new System.Drawing.Point(12, 167);
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
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Add/Remove folder/file symlink creator in context menu?";
            // 
            // no_copy
            // 
            this.no_copy.Location = new System.Drawing.Point(93, 108);
            this.no_copy.Name = "no_copy";
            this.no_copy.Size = new System.Drawing.Size(75, 23);
            this.no_copy.TabIndex = 24;
            this.no_copy.Text = "Remove";
            this.no_copy.UseVisualStyleBackColor = true;
            this.no_copy.Click += new System.EventHandler(this.no_copy_Click);
            // 
            // yes_copy
            // 
            this.yes_copy.Location = new System.Drawing.Point(12, 108);
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
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add/Remove robocopy and background robopaste in context menu?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add/Remove folder RMDIR in context menu?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "(You must reenable these if you move the executables)";
            // 
            // remove_rmdir
            // 
            this.remove_rmdir.Location = new System.Drawing.Point(93, 53);
            this.remove_rmdir.Name = "remove_rmdir";
            this.remove_rmdir.Size = new System.Drawing.Size(75, 23);
            this.remove_rmdir.TabIndex = 19;
            this.remove_rmdir.Text = "Remove";
            this.remove_rmdir.UseVisualStyleBackColor = true;
            this.remove_rmdir.Click += new System.EventHandler(this.remove_rmdir_Click);
            // 
            // yes_rmdir
            // 
            this.yes_rmdir.Location = new System.Drawing.Point(12, 53);
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
            this.label4.Location = new System.Drawing.Point(-2, 27);
            this.label4.MaximumSize = new System.Drawing.Size(0, 1);
            this.label4.MinimumSize = new System.Drawing.Size(290, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 1);
            this.label4.TabIndex = 31;
            // 
            // no_note
            // 
            this.no_note.Location = new System.Drawing.Point(93, 224);
            this.no_note.Name = "no_note";
            this.no_note.Size = new System.Drawing.Size(75, 23);
            this.no_note.TabIndex = 34;
            this.no_note.Text = "Remove";
            this.no_note.UseVisualStyleBackColor = true;
            this.no_note.Click += new System.EventHandler(this.no_note_Click);
            // 
            // yes_note
            // 
            this.yes_note.Location = new System.Drawing.Point(12, 224);
            this.yes_note.Name = "yes_note";
            this.yes_note.Size = new System.Drawing.Size(75, 23);
            this.yes_note.TabIndex = 33;
            this.yes_note.Text = "Add";
            this.yes_note.UseVisualStyleBackColor = true;
            this.yes_note.Click += new System.EventHandler(this.yes_note_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Add/Remove open file with notepad in context menu?";
            // 
            // no_compact
            // 
            this.no_compact.Location = new System.Drawing.Point(93, 279);
            this.no_compact.Name = "no_compact";
            this.no_compact.Size = new System.Drawing.Size(75, 23);
            this.no_compact.TabIndex = 37;
            this.no_compact.Text = "Remove";
            this.no_compact.UseVisualStyleBackColor = true;
            this.no_compact.Click += new System.EventHandler(this.no_compact_Click);
            // 
            // yes_compact
            // 
            this.yes_compact.Location = new System.Drawing.Point(12, 279);
            this.yes_compact.Name = "yes_compact";
            this.yes_compact.Size = new System.Drawing.Size(75, 23);
            this.yes_compact.TabIndex = 36;
            this.yes_compact.Text = "Add";
            this.yes_compact.UseVisualStyleBackColor = true;
            this.yes_compact.Click += new System.EventHandler(this.yes_compact_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Add/Remove compact folder in context menu?";
            // 
            // no_path
            // 
            this.no_path.Location = new System.Drawing.Point(93, 335);
            this.no_path.Name = "no_path";
            this.no_path.Size = new System.Drawing.Size(75, 23);
            this.no_path.TabIndex = 40;
            this.no_path.Text = "Remove";
            this.no_path.UseVisualStyleBackColor = true;
            this.no_path.Click += new System.EventHandler(this.no_path_Click);
            // 
            // yes_path
            // 
            this.yes_path.Location = new System.Drawing.Point(12, 335);
            this.yes_path.Name = "yes_path";
            this.yes_path.Size = new System.Drawing.Size(75, 23);
            this.yes_path.TabIndex = 39;
            this.yes_path.Text = "Add";
            this.yes_path.UseVisualStyleBackColor = true;
            this.yes_path.Click += new System.EventHandler(this.yes_path_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Add/Remove add folder/background to PATH in context menu?";
            // 
            // no_batch
            // 
            this.no_batch.Location = new System.Drawing.Point(93, 393);
            this.no_batch.Name = "no_batch";
            this.no_batch.Size = new System.Drawing.Size(75, 23);
            this.no_batch.TabIndex = 43;
            this.no_batch.Text = "Remove";
            this.no_batch.UseVisualStyleBackColor = true;
            this.no_batch.Click += new System.EventHandler(this.no_batch_Click);
            // 
            // yes_batch
            // 
            this.yes_batch.Location = new System.Drawing.Point(12, 393);
            this.yes_batch.Name = "yes_batch";
            this.yes_batch.Size = new System.Drawing.Size(75, 23);
            this.yes_batch.TabIndex = 42;
            this.yes_batch.Text = "Add";
            this.yes_batch.UseVisualStyleBackColor = true;
            this.yes_batch.Click += new System.EventHandler(this.yes_batch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Add/Remove batch file to New File context menu?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 429);
            this.Controls.Add(this.no_batch);
            this.Controls.Add(this.yes_batch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.no_path);
            this.Controls.Add(this.yes_path);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.no_compact);
            this.Controls.Add(this.yes_compact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.no_note);
            this.Controls.Add(this.yes_note);
            this.Controls.Add(this.label6);
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
            this.Text = "File-Tools Settings";
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
    private Button no_note;
    private Button yes_note;
    private Label label6;
    private Button no_compact;
    private Button yes_compact;
    private Label label7;
    private Button no_path;
    private Button yes_path;
    private Label label8;
    private Button no_batch;
    private Button yes_batch;
    private Label label9;
}
