
namespace CypherProgramm
{
    partial class mainWindow
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
            this.pField = new System.Windows.Forms.NumericUpDown();
            this.qField = new System.Windows.Forms.NumericUpDown();
            this.pLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.randomPButton = new System.Windows.Forms.Button();
            this.randomQButton = new System.Windows.Forms.Button();
            this.nField = new System.Windows.Forms.NumericUpDown();
            this.nLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.dField = new System.Windows.Forms.NumericUpDown();
            this.eLabel = new System.Windows.Forms.Label();
            this.eField = new System.Windows.Forms.NumericUpDown();
            this.encodeText = new System.Windows.Forms.RichTextBox();
            this.decodeText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eField)).BeginInit();
            this.SuspendLayout();
            // 
            // pField
            // 
            this.pField.Location = new System.Drawing.Point(14, 14);
            this.pField.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(140, 23);
            this.pField.TabIndex = 0;
            // 
            // qField
            // 
            this.qField.Location = new System.Drawing.Point(14, 47);
            this.qField.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.qField.Name = "qField";
            this.qField.Size = new System.Drawing.Size(140, 23);
            this.qField.TabIndex = 1;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(295, 16);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(13, 15);
            this.pLabel.TabIndex = 2;
            this.pLabel.Text = "p";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(295, 50);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(13, 15);
            this.qLabel.TabIndex = 3;
            this.qLabel.Text = "q";
            // 
            // randomPButton
            // 
            this.randomPButton.BackColor = System.Drawing.Color.Aquamarine;
            this.randomPButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomPButton.Location = new System.Drawing.Point(161, 10);
            this.randomPButton.Name = "randomPButton";
            this.randomPButton.Size = new System.Drawing.Size(127, 27);
            this.randomPButton.TabIndex = 4;
            this.randomPButton.Text = "Set random";
            this.randomPButton.UseVisualStyleBackColor = false;
            this.randomPButton.Click += new System.EventHandler(this.randomPButton_Click);
            // 
            // randomQButton
            // 
            this.randomQButton.BackColor = System.Drawing.Color.Aquamarine;
            this.randomQButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomQButton.Location = new System.Drawing.Point(161, 47);
            this.randomQButton.Name = "randomQButton";
            this.randomQButton.Size = new System.Drawing.Size(127, 27);
            this.randomQButton.TabIndex = 5;
            this.randomQButton.Text = "Set random";
            this.randomQButton.UseVisualStyleBackColor = false;
            this.randomQButton.Click += new System.EventHandler(this.randomQButton_Click);
            // 
            // nField
            // 
            this.nField.Location = new System.Drawing.Point(14, 101);
            this.nField.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nField.Name = "nField";
            this.nField.ReadOnly = true;
            this.nField.Size = new System.Drawing.Size(79, 23);
            this.nField.TabIndex = 6;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(46, 83);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(13, 15);
            this.nLabel.TabIndex = 7;
            this.nLabel.Text = "n";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(157, 83);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(13, 15);
            this.dLabel.TabIndex = 9;
            this.dLabel.Text = "d";
            // 
            // dField
            // 
            this.dField.Location = new System.Drawing.Point(125, 101);
            this.dField.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.dField.Name = "dField";
            this.dField.ReadOnly = true;
            this.dField.Size = new System.Drawing.Size(79, 23);
            this.dField.TabIndex = 8;
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(261, 83);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(13, 15);
            this.eLabel.TabIndex = 11;
            this.eLabel.Text = "e";
            // 
            // eField
            // 
            this.eField.Location = new System.Drawing.Point(229, 101);
            this.eField.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.eField.Name = "eField";
            this.eField.ReadOnly = true;
            this.eField.Size = new System.Drawing.Size(79, 23);
            this.eField.TabIndex = 10;
            // 
            // encodeText
            // 
            this.encodeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encodeText.Location = new System.Drawing.Point(12, 140);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(130, 186);
            this.encodeText.TabIndex = 12;
            this.encodeText.Text = "Encode message";
            // 
            // decodeText
            // 
            this.decodeText.Location = new System.Drawing.Point(178, 140);
            this.decodeText.Name = "decodeText";
            this.decodeText.Size = new System.Drawing.Size(130, 186);
            this.decodeText.TabIndex = 13;
            this.decodeText.Text = "Decode message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "→";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(148, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "←";
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.Silver;
            this.encodeButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodeButton.ForeColor = System.Drawing.Color.Black;
            this.encodeButton.Location = new System.Drawing.Point(12, 333);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(130, 54);
            this.encodeButton.TabIndex = 16;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.BackColor = System.Drawing.Color.Silver;
            this.decodeButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeButton.ForeColor = System.Drawing.Color.Black;
            this.decodeButton.Location = new System.Drawing.Point(178, 333);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(130, 54);
            this.decodeButton.TabIndex = 17;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(324, 411);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decodeText);
            this.Controls.Add(this.encodeText);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.eField);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.dField);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.nField);
            this.Controls.Add(this.randomQButton);
            this.Controls.Add(this.randomPButton);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.qField);
            this.Controls.Add(this.pField);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "mainWindow";
            this.Text = "Cypher programm";
            ((System.ComponentModel.ISupportInitialize)(this.pField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pField;
        private System.Windows.Forms.NumericUpDown qField;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Button randomPButton;
        private System.Windows.Forms.Button randomQButton;
        private System.Windows.Forms.NumericUpDown nField;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.NumericUpDown dField;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.NumericUpDown eField;
        private System.Windows.Forms.RichTextBox encodeText;
        private System.Windows.Forms.RichTextBox decodeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
    }
}

