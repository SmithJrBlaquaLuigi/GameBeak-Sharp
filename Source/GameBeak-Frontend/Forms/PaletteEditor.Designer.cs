﻿namespace GameBeak.Forms
{
    partial class PaletteEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteEditor));
            this.paletteSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.palettePreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.paletteNameListBox = new System.Windows.Forms.ListBox();
            this.bgColorPreview1 = new System.Windows.Forms.PictureBox();
            this.bgColorPreview2 = new System.Windows.Forms.PictureBox();
            this.bgColorPreview4 = new System.Windows.Forms.PictureBox();
            this.bgColorPreview3 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bp0ColorPreview4 = new System.Windows.Forms.PictureBox();
            this.bp0ColorPreview3 = new System.Windows.Forms.PictureBox();
            this.bp0ColorPreview2 = new System.Windows.Forms.PictureBox();
            this.bp0ColorPreview1 = new System.Windows.Forms.PictureBox();
            this.bp1ColorPreview4 = new System.Windows.Forms.PictureBox();
            this.bp1ColorPreview3 = new System.Windows.Forms.PictureBox();
            this.bp1ColorPreview2 = new System.Windows.Forms.PictureBox();
            this.bp1ColorPreview1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.paletteSelectGroupBox.SuspendLayout();
            this.palettePreviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // paletteSelectGroupBox
            // 
            this.paletteSelectGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteSelectGroupBox.Controls.Add(this.saveButton);
            this.paletteSelectGroupBox.Controls.Add(this.deleteButton);
            this.paletteSelectGroupBox.Controls.Add(this.newButton);
            this.paletteSelectGroupBox.Controls.Add(this.paletteNameListBox);
            this.paletteSelectGroupBox.Location = new System.Drawing.Point(12, 12);
            this.paletteSelectGroupBox.Name = "paletteSelectGroupBox";
            this.paletteSelectGroupBox.Size = new System.Drawing.Size(260, 154);
            this.paletteSelectGroupBox.TabIndex = 0;
            this.paletteSelectGroupBox.TabStop = false;
            this.paletteSelectGroupBox.Text = "Palette Select";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(197, 302);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // palettePreviewGroupBox
            // 
            this.palettePreviewGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.palettePreviewGroupBox.Controls.Add(this.label3);
            this.palettePreviewGroupBox.Controls.Add(this.label2);
            this.palettePreviewGroupBox.Controls.Add(this.label1);
            this.palettePreviewGroupBox.Controls.Add(this.bp1ColorPreview4);
            this.palettePreviewGroupBox.Controls.Add(this.bp1ColorPreview3);
            this.palettePreviewGroupBox.Controls.Add(this.bp1ColorPreview2);
            this.palettePreviewGroupBox.Controls.Add(this.bp1ColorPreview1);
            this.palettePreviewGroupBox.Controls.Add(this.bp0ColorPreview4);
            this.palettePreviewGroupBox.Controls.Add(this.bp0ColorPreview3);
            this.palettePreviewGroupBox.Controls.Add(this.bp0ColorPreview2);
            this.palettePreviewGroupBox.Controls.Add(this.bp0ColorPreview1);
            this.palettePreviewGroupBox.Controls.Add(this.bgColorPreview4);
            this.palettePreviewGroupBox.Controls.Add(this.bgColorPreview3);
            this.palettePreviewGroupBox.Controls.Add(this.bgColorPreview2);
            this.palettePreviewGroupBox.Controls.Add(this.bgColorPreview1);
            this.palettePreviewGroupBox.Location = new System.Drawing.Point(12, 172);
            this.palettePreviewGroupBox.Name = "palettePreviewGroupBox";
            this.palettePreviewGroupBox.Size = new System.Drawing.Size(260, 124);
            this.palettePreviewGroupBox.TabIndex = 2;
            this.palettePreviewGroupBox.TabStop = false;
            this.palettePreviewGroupBox.Text = "Palette Preview";
            // 
            // paletteNameListBox
            // 
            this.paletteNameListBox.FormattingEnabled = true;
            this.paletteNameListBox.Location = new System.Drawing.Point(19, 19);
            this.paletteNameListBox.Name = "paletteNameListBox";
            this.paletteNameListBox.Size = new System.Drawing.Size(224, 95);
            this.paletteNameListBox.TabIndex = 0;
            this.paletteNameListBox.SelectedIndexChanged += new System.EventHandler(this.paletteNameListBox_SelectedIndexChanged);
            this.paletteNameListBox.DoubleClick += new System.EventHandler(this.paletteNameListBox_DoubleClick);
            // 
            // bgColorPreview1
            // 
            this.bgColorPreview1.BackColor = System.Drawing.Color.White;
            this.bgColorPreview1.Location = new System.Drawing.Point(67, 16);
            this.bgColorPreview1.Name = "bgColorPreview1";
            this.bgColorPreview1.Size = new System.Drawing.Size(32, 32);
            this.bgColorPreview1.TabIndex = 0;
            this.bgColorPreview1.TabStop = false;
            this.bgColorPreview1.DoubleClick += new System.EventHandler(this.bgColorPreview1_DoubleClick);
            // 
            // bgColorPreview2
            // 
            this.bgColorPreview2.BackColor = System.Drawing.Color.White;
            this.bgColorPreview2.Location = new System.Drawing.Point(112, 16);
            this.bgColorPreview2.Name = "bgColorPreview2";
            this.bgColorPreview2.Size = new System.Drawing.Size(32, 32);
            this.bgColorPreview2.TabIndex = 1;
            this.bgColorPreview2.TabStop = false;
            this.bgColorPreview2.DoubleClick += new System.EventHandler(this.bgColorPreview2_DoubleClick);
            // 
            // bgColorPreview4
            // 
            this.bgColorPreview4.BackColor = System.Drawing.Color.White;
            this.bgColorPreview4.Location = new System.Drawing.Point(199, 16);
            this.bgColorPreview4.Name = "bgColorPreview4";
            this.bgColorPreview4.Size = new System.Drawing.Size(32, 32);
            this.bgColorPreview4.TabIndex = 3;
            this.bgColorPreview4.TabStop = false;
            this.bgColorPreview4.DoubleClick += new System.EventHandler(this.bgColorPreview4_DoubleClick);
            // 
            // bgColorPreview3
            // 
            this.bgColorPreview3.BackColor = System.Drawing.Color.White;
            this.bgColorPreview3.Location = new System.Drawing.Point(157, 16);
            this.bgColorPreview3.Name = "bgColorPreview3";
            this.bgColorPreview3.Size = new System.Drawing.Size(32, 32);
            this.bgColorPreview3.TabIndex = 2;
            this.bgColorPreview3.TabStop = false;
            this.bgColorPreview3.DoubleClick += new System.EventHandler(this.bgColorPreview3_DoubleClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(111, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bp0ColorPreview4
            // 
            this.bp0ColorPreview4.BackColor = System.Drawing.Color.White;
            this.bp0ColorPreview4.Location = new System.Drawing.Point(199, 51);
            this.bp0ColorPreview4.Name = "bp0ColorPreview4";
            this.bp0ColorPreview4.Size = new System.Drawing.Size(32, 32);
            this.bp0ColorPreview4.TabIndex = 7;
            this.bp0ColorPreview4.TabStop = false;
            this.bp0ColorPreview4.DoubleClick += new System.EventHandler(this.bp0ColorPreview4_DoubleClick);
            // 
            // bp0ColorPreview3
            // 
            this.bp0ColorPreview3.BackColor = System.Drawing.Color.White;
            this.bp0ColorPreview3.Location = new System.Drawing.Point(157, 51);
            this.bp0ColorPreview3.Name = "bp0ColorPreview3";
            this.bp0ColorPreview3.Size = new System.Drawing.Size(32, 32);
            this.bp0ColorPreview3.TabIndex = 6;
            this.bp0ColorPreview3.TabStop = false;
            this.bp0ColorPreview3.DoubleClick += new System.EventHandler(this.bp0ColorPreview3_DoubleClick);
            // 
            // bp0ColorPreview2
            // 
            this.bp0ColorPreview2.BackColor = System.Drawing.Color.White;
            this.bp0ColorPreview2.Location = new System.Drawing.Point(112, 51);
            this.bp0ColorPreview2.Name = "bp0ColorPreview2";
            this.bp0ColorPreview2.Size = new System.Drawing.Size(32, 32);
            this.bp0ColorPreview2.TabIndex = 5;
            this.bp0ColorPreview2.TabStop = false;
            this.bp0ColorPreview2.DoubleClick += new System.EventHandler(this.bp0ColorPreview2_DoubleClick);
            // 
            // bp0ColorPreview1
            // 
            this.bp0ColorPreview1.BackColor = System.Drawing.Color.White;
            this.bp0ColorPreview1.Location = new System.Drawing.Point(67, 51);
            this.bp0ColorPreview1.Name = "bp0ColorPreview1";
            this.bp0ColorPreview1.Size = new System.Drawing.Size(32, 32);
            this.bp0ColorPreview1.TabIndex = 4;
            this.bp0ColorPreview1.TabStop = false;
            this.bp0ColorPreview1.DoubleClick += new System.EventHandler(this.bp0ColorPreview1_DoubleClick);
            // 
            // bp1ColorPreview4
            // 
            this.bp1ColorPreview4.BackColor = System.Drawing.Color.White;
            this.bp1ColorPreview4.Location = new System.Drawing.Point(199, 87);
            this.bp1ColorPreview4.Name = "bp1ColorPreview4";
            this.bp1ColorPreview4.Size = new System.Drawing.Size(32, 32);
            this.bp1ColorPreview4.TabIndex = 11;
            this.bp1ColorPreview4.TabStop = false;
            this.bp1ColorPreview4.DoubleClick += new System.EventHandler(this.bp1ColorPreview4_DoubleClick);
            // 
            // bp1ColorPreview3
            // 
            this.bp1ColorPreview3.BackColor = System.Drawing.Color.White;
            this.bp1ColorPreview3.Location = new System.Drawing.Point(157, 87);
            this.bp1ColorPreview3.Name = "bp1ColorPreview3";
            this.bp1ColorPreview3.Size = new System.Drawing.Size(32, 32);
            this.bp1ColorPreview3.TabIndex = 10;
            this.bp1ColorPreview3.TabStop = false;
            this.bp1ColorPreview3.DoubleClick += new System.EventHandler(this.bp1ColorPreview3_DoubleClick);
            // 
            // bp1ColorPreview2
            // 
            this.bp1ColorPreview2.BackColor = System.Drawing.Color.White;
            this.bp1ColorPreview2.Location = new System.Drawing.Point(112, 87);
            this.bp1ColorPreview2.Name = "bp1ColorPreview2";
            this.bp1ColorPreview2.Size = new System.Drawing.Size(32, 32);
            this.bp1ColorPreview2.TabIndex = 9;
            this.bp1ColorPreview2.TabStop = false;
            this.bp1ColorPreview2.DoubleClick += new System.EventHandler(this.bp1ColorPreview2_DoubleClick);
            // 
            // bp1ColorPreview1
            // 
            this.bp1ColorPreview1.BackColor = System.Drawing.Color.White;
            this.bp1ColorPreview1.Location = new System.Drawing.Point(67, 87);
            this.bp1ColorPreview1.Name = "bp1ColorPreview1";
            this.bp1ColorPreview1.Size = new System.Drawing.Size(32, 32);
            this.bp1ColorPreview1.TabIndex = 8;
            this.bp1ColorPreview1.TabStop = false;
            this.bp1ColorPreview1.DoubleClick += new System.EventHandler(this.bp1ColorPreview1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "BG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "BP0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "BP1:";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(19, 120);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(55, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(80, 120);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(49, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(135, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save All to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PaletteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.palettePreviewGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.paletteSelectGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaletteEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBeak - Palette";
            this.Load += new System.EventHandler(this.PaletteEditor_Load);
            this.paletteSelectGroupBox.ResumeLayout(false);
            this.palettePreviewGroupBox.ResumeLayout(false);
            this.palettePreviewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp0ColorPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1ColorPreview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paletteSelectGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox palettePreviewGroupBox;
        private System.Windows.Forms.ListBox paletteNameListBox;
        private System.Windows.Forms.PictureBox bgColorPreview1;
        private System.Windows.Forms.PictureBox bgColorPreview4;
        private System.Windows.Forms.PictureBox bgColorPreview3;
        private System.Windows.Forms.PictureBox bgColorPreview2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox bp1ColorPreview4;
        private System.Windows.Forms.PictureBox bp1ColorPreview3;
        private System.Windows.Forms.PictureBox bp1ColorPreview2;
        private System.Windows.Forms.PictureBox bp1ColorPreview1;
        private System.Windows.Forms.PictureBox bp0ColorPreview4;
        private System.Windows.Forms.PictureBox bp0ColorPreview3;
        private System.Windows.Forms.PictureBox bp0ColorPreview2;
        private System.Windows.Forms.PictureBox bp0ColorPreview1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
    }
}