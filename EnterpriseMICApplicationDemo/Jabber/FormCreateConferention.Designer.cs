﻿namespace EnterpriseMICApplicationDemo
{
    partial class FormCreateConferention
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.listViewUsers = new System.Windows.Forms.ListView();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.label2 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.textBoxConfName = new System.Windows.Forms.TextBox();
			this.label3 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.textBoxConfIdent = new System.Windows.Forms.TextBox();
			this.checkBoxHistory = new System.Windows.Forms.CheckBox();
			this.checkBoxPersistentRoom = new System.Windows.Forms.CheckBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label4 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.opacityLabel1 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCreate
			// 
			this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreate.Location = new System.Drawing.Point(317, 389);
			this.buttonCreate.Margin = new System.Windows.Forms.Padding(6);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(235, 63);
			this.buttonCreate.TabIndex = 0;
			this.buttonCreate.Text = "Создать конференцию";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// listViewUsers
			// 
			this.listViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewUsers.CheckBoxes = true;
			this.listViewUsers.Location = new System.Drawing.Point(414, 46);
			this.listViewUsers.Margin = new System.Windows.Forms.Padding(6);
			this.listViewUsers.Name = "listViewUsers";
			this.listViewUsers.Size = new System.Drawing.Size(334, 326);
			this.listViewUsers.TabIndex = 1;
			this.listViewUsers.UseCompatibleStateImageBehavior = false;
			this.listViewUsers.View = System.Windows.Forms.View.List;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(564, 389);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(191, 63);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label1.Location = new System.Drawing.Point(410, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Участники";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label2.Location = new System.Drawing.Point(22, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Название конференции";
			// 
			// textBoxConfName
			// 
			this.textBoxConfName.Location = new System.Drawing.Point(22, 39);
			this.textBoxConfName.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxConfName.Name = "textBoxConfName";
			this.textBoxConfName.Size = new System.Drawing.Size(380, 31);
			this.textBoxConfName.TabIndex = 4;
			this.textBoxConfName.Text = "Конференция IT-разработчиков";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label3.Location = new System.Drawing.Point(22, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(285, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Идентификатор конференции";
			// 
			// textBoxConfIdent
			// 
			this.textBoxConfIdent.Location = new System.Drawing.Point(22, 106);
			this.textBoxConfIdent.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxConfIdent.Name = "textBoxConfIdent";
			this.textBoxConfIdent.Size = new System.Drawing.Size(380, 31);
			this.textBoxConfIdent.TabIndex = 6;
			this.textBoxConfIdent.Text = "grrconf";
			// 
			// checkBoxHistory
			// 
			this.checkBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxHistory.AutoSize = true;
			this.checkBoxHistory.Location = new System.Drawing.Point(22, 312);
			this.checkBoxHistory.Margin = new System.Windows.Forms.Padding(6);
			this.checkBoxHistory.Name = "checkBoxHistory";
			this.checkBoxHistory.Size = new System.Drawing.Size(337, 28);
			this.checkBoxHistory.TabIndex = 8;
			this.checkBoxHistory.Text = "Сохранять историю конференции";
			this.checkBoxHistory.UseVisualStyleBackColor = true;
			// 
			// checkBoxPersistentRoom
			// 
			this.checkBoxPersistentRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxPersistentRoom.AutoSize = true;
			this.checkBoxPersistentRoom.Location = new System.Drawing.Point(22, 349);
			this.checkBoxPersistentRoom.Margin = new System.Windows.Forms.Padding(6);
			this.checkBoxPersistentRoom.Name = "checkBoxPersistentRoom";
			this.checkBoxPersistentRoom.Size = new System.Drawing.Size(351, 28);
			this.checkBoxPersistentRoom.TabIndex = 9;
			this.checkBoxPersistentRoom.Text = "Сделать конференцию постоянной";
			this.checkBoxPersistentRoom.UseVisualStyleBackColor = true;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxDescription.Location = new System.Drawing.Point(22, 240);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(380, 60);
			this.textBoxDescription.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label4.Location = new System.Drawing.Point(22, 210);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(185, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "Описание комнаты";
			// 
			// opacityLabel1
			// 
			this.opacityLabel1.AutoSize = true;
			this.opacityLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.opacityLabel1.ForeColor = System.Drawing.Color.Black;
			this.opacityLabel1.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.opacityLabel1.Location = new System.Drawing.Point(22, 143);
			this.opacityLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.opacityLabel1.Name = "opacityLabel1";
			this.opacityLabel1.Size = new System.Drawing.Size(79, 24);
			this.opacityLabel1.TabIndex = 13;
			this.opacityLabel1.Text = "Пароль";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(22, 173);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(380, 31);
			this.textBoxPassword.TabIndex = 12;
			this.textBoxPassword.Text = "grrconf";
			// 
			// FormCreateConferention
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 468);
			this.Controls.Add(this.opacityLabel1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.checkBoxPersistentRoom);
			this.Controls.Add(this.checkBoxHistory);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxConfIdent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxConfName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.listViewUsers);
			this.Controls.Add(this.buttonCreate);
			this.Margin = new System.Windows.Forms.Padding(9);
			this.Name = "FormCreateConferention";
			this.Text = "FormCreateConferention";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Button buttonCancel;
		private EnterpriseMICApplicationDemo.OpacityLabel label1;
        private EnterpriseMICApplicationDemo.OpacityLabel label2;
        private System.Windows.Forms.TextBox textBoxConfName;
        private EnterpriseMICApplicationDemo.OpacityLabel label3;
        private System.Windows.Forms.TextBox textBoxConfIdent;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.CheckBox checkBoxPersistentRoom;
        private System.Windows.Forms.TextBox textBoxDescription;
        private EnterpriseMICApplicationDemo.OpacityLabel label4;
		private OpacityLabel opacityLabel1;
		private System.Windows.Forms.TextBox textBoxPassword;
    }
}