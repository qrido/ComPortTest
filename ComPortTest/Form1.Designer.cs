namespace ComPortTest
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
      this.comboBoxavailablePorts = new System.Windows.Forms.ComboBox();
      this.openPortButton = new System.Windows.Forms.Button();
      this.closePortButton = new System.Windows.Forms.Button();
      this.sendButton = new System.Windows.Forms.Button();
      this.textBoxSent = new System.Windows.Forms.TextBox();
      this.comboBoxCommand = new System.Windows.Forms.ComboBox();
      this.comboBoxName = new System.Windows.Forms.ComboBox();
      this.numericHValue = new System.Windows.Forms.NumericUpDown();
      this.numericLValue = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxRead = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericHValue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericLValue)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBoxavailablePorts
      // 
      this.comboBoxavailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxavailablePorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.comboBoxavailablePorts.FormattingEnabled = true;
      this.comboBoxavailablePorts.Location = new System.Drawing.Point(12, 12);
      this.comboBoxavailablePorts.Name = "comboBoxavailablePorts";
      this.comboBoxavailablePorts.Size = new System.Drawing.Size(220, 28);
      this.comboBoxavailablePorts.TabIndex = 0;
      this.comboBoxavailablePorts.SelectedIndexChanged += new System.EventHandler(this.availablePorts_SelectedIndexChanged);
      this.comboBoxavailablePorts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.availablePorts_MouseClick);
      // 
      // openPortButton
      // 
      this.openPortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.openPortButton.Location = new System.Drawing.Point(238, 10);
      this.openPortButton.Name = "openPortButton";
      this.openPortButton.Size = new System.Drawing.Size(125, 30);
      this.openPortButton.TabIndex = 1;
      this.openPortButton.Text = "Otwórz Port";
      this.openPortButton.UseVisualStyleBackColor = true;
      this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
      // 
      // closePortButton
      // 
      this.closePortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.closePortButton.Location = new System.Drawing.Point(369, 10);
      this.closePortButton.Name = "closePortButton";
      this.closePortButton.Size = new System.Drawing.Size(139, 30);
      this.closePortButton.TabIndex = 2;
      this.closePortButton.Text = "Zamknij Port";
      this.closePortButton.UseVisualStyleBackColor = true;
      this.closePortButton.Click += new System.EventHandler(this.closePortButton_Click);
      // 
      // sendButton
      // 
      this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.sendButton.Location = new System.Drawing.Point(12, 112);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(496, 30);
      this.sendButton.TabIndex = 3;
      this.sendButton.Text = "Wyślij";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // textBoxSent
      // 
      this.textBoxSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxSent.Location = new System.Drawing.Point(98, 148);
      this.textBoxSent.Name = "textBoxSent";
      this.textBoxSent.Size = new System.Drawing.Size(410, 26);
      this.textBoxSent.TabIndex = 5;
      // 
      // comboBoxCommand
      // 
      this.comboBoxCommand.AllowDrop = true;
      this.comboBoxCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.comboBoxCommand.FormattingEnabled = true;
      this.comboBoxCommand.Location = new System.Drawing.Point(62, 46);
      this.comboBoxCommand.Name = "comboBoxCommand";
      this.comboBoxCommand.Size = new System.Drawing.Size(446, 28);
      this.comboBoxCommand.TabIndex = 6;
      // 
      // comboBoxName
      // 
      this.comboBoxName.DisplayMember = "0";
      this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.comboBoxName.FormattingEnabled = true;
      this.comboBoxName.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
      this.comboBoxName.Location = new System.Drawing.Point(12, 46);
      this.comboBoxName.Name = "comboBoxName";
      this.comboBoxName.Size = new System.Drawing.Size(44, 28);
      this.comboBoxName.TabIndex = 7;
      this.comboBoxName.ValueMember = "0";
      // 
      // numericHValue
      // 
      this.numericHValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.numericHValue.Location = new System.Drawing.Point(74, 80);
      this.numericHValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericHValue.Name = "numericHValue";
      this.numericHValue.Size = new System.Drawing.Size(172, 26);
      this.numericHValue.TabIndex = 9;
      // 
      // numericLValue
      // 
      this.numericLValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.numericLValue.Location = new System.Drawing.Point(311, 80);
      this.numericLValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericLValue.Name = "numericLValue";
      this.numericLValue.Size = new System.Drawing.Size(197, 26);
      this.numericLValue.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(8, 154);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 20);
      this.label1.TabIndex = 11;
      this.label1.Text = "Wysłano:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label2.Location = new System.Drawing.Point(8, 183);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 20);
      this.label2.TabIndex = 12;
      this.label2.Text = "Odebrano:";
      // 
      // textBoxRead
      // 
      this.textBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxRead.Location = new System.Drawing.Point(98, 180);
      this.textBoxRead.Name = "textBoxRead";
      this.textBoxRead.Size = new System.Drawing.Size(410, 26);
      this.textBoxRead.TabIndex = 13;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label3.Location = new System.Drawing.Point(12, 82);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 20);
      this.label3.TabIndex = 14;
      this.label3.Text = "HVAL:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label4.Location = new System.Drawing.Point(252, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "LVAL:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(520, 222);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxRead);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numericLValue);
      this.Controls.Add(this.numericHValue);
      this.Controls.Add(this.comboBoxName);
      this.Controls.Add(this.comboBoxCommand);
      this.Controls.Add(this.textBoxSent);
      this.Controls.Add(this.sendButton);
      this.Controls.Add(this.closePortButton);
      this.Controls.Add(this.openPortButton);
      this.Controls.Add(this.comboBoxavailablePorts);
      this.Name = "Form1";
      this.Text = "MotorDriverCommunication";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.numericHValue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericLValue)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxavailablePorts;
    private System.Windows.Forms.Button openPortButton;
    private System.Windows.Forms.Button closePortButton;
    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.TextBox textBoxSent;
    private System.Windows.Forms.ComboBox comboBoxCommand;
    private System.Windows.Forms.ComboBox comboBoxName;
    private System.Windows.Forms.NumericUpDown numericHValue;
    private System.Windows.Forms.NumericUpDown numericLValue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxRead;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

