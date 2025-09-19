namespace Lab1_Csharp_07._09;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MenuStripItem = new System.Windows.Forms.MenuStrip();
        LabelName = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        CheckFemale = new System.Windows.Forms.CheckBox();
        CheckMale = new System.Windows.Forms.CheckBox();
        textBox1 = new System.Windows.Forms.TextBox();
        LabelGender = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        LabelYear = new System.Windows.Forms.Label();
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        label2 = new System.Windows.Forms.Label();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        button1 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        // 
        // MenuStripItem
        // 
        MenuStripItem.ImageScalingSize = new System.Drawing.Size(20, 20);
        MenuStripItem.Location = new System.Drawing.Point(0, 0);
        MenuStripItem.Name = "MenuStripItem";
        MenuStripItem.Size = new System.Drawing.Size(800, 24);
        MenuStripItem.TabIndex = 0;
        MenuStripItem.Text = "menuStrip1";
        // 
        // LabelName
        // 
        LabelName.Location = new System.Drawing.Point(28, 109);
        LabelName.Name = "LabelName";
        LabelName.Size = new System.Drawing.Size(100, 23);
        LabelName.TabIndex = 3;
        LabelName.Text = "Ім`я";
        // 
        // panel1
        // 
        panel1.Controls.Add(CheckFemale);
        panel1.Controls.Add(CheckMale);
        panel1.Location = new System.Drawing.Point(91, 151);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(187, 100);
        panel1.TabIndex = 4;
        // 
        // CheckFemale
        // 
        CheckFemale.Location = new System.Drawing.Point(32, 63);
        CheckFemale.Name = "CheckFemale";
        CheckFemale.Size = new System.Drawing.Size(104, 24);
        CheckFemale.TabIndex = 1;
        CheckFemale.Text = "Жінка";
        CheckFemale.UseVisualStyleBackColor = true;
        // 
        // CheckMale
        // 
        CheckMale.Location = new System.Drawing.Point(32, 21);
        CheckMale.Name = "CheckMale";
        CheckMale.Size = new System.Drawing.Size(104, 24);
        CheckMale.TabIndex = 0;
        CheckMale.Text = "Чоловік";
        CheckMale.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(91, 109);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(120, 27);
        textBox1.TabIndex = 5;
        // 
        // LabelGender
        // 
        LabelGender.Location = new System.Drawing.Point(27, 151);
        LabelGender.Name = "LabelGender";
        LabelGender.Size = new System.Drawing.Size(58, 23);
        LabelGender.TabIndex = 6;
        LabelGender.Text = "Стать";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(28, 262);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(65, 27);
        label1.TabIndex = 7;
        label1.Text = "Посада";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(99, 259);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(112, 27);
        textBox2.TabIndex = 8;
        // 
        // LabelYear
        // 
        LabelYear.Location = new System.Drawing.Point(28, 305);
        LabelYear.Name = "LabelYear";
        LabelYear.Size = new System.Drawing.Size(65, 23);
        LabelYear.TabIndex = 9;
        LabelYear.Text = "Вік";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new System.Drawing.Point(99, 301);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(120, 27);
        numericUpDown1.TabIndex = 10;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(28, 348);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(65, 23);
        label2.TabIndex = 11;
        label2.Text = "Досвід";
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new System.Drawing.Point(99, 344);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(120, 27);
        numericUpDown2.TabIndex = 12;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(69, 392);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(93, 34);
        button1.TabIndex = 13;
        button1.Text = "Добавити";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.DodgerBlue;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(numericUpDown2);
        Controls.Add(label2);
        Controls.Add(numericUpDown1);
        Controls.Add(LabelYear);
        Controls.Add(textBox2);
        Controls.Add(label1);
        Controls.Add(LabelGender);
        Controls.Add(textBox1);
        Controls.Add(panel1);
        Controls.Add(LabelName);
        Controls.Add(MenuStripItem);
        MainMenuStrip = MenuStripItem;
        Text = "Вас вітає студент групи ПІ-232 Бабюк Віктор Олександрович";
        Load += Form1_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label LabelYear;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label LabelGender;

    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox CheckMale;
    private System.Windows.Forms.CheckBox CheckFemale;

    private System.Windows.Forms.MenuStrip MenuStripItem;

    #endregion
}