namespace Sesion11
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUser = new MetroFramework.Controls.MetroTextBox();
            this.TxtPw = new MetroFramework.Controls.MetroTextBox();
            this.BtnOk = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            // 
            // TxtUser
            // 
            // 
            // 
            // 
            this.TxtUser.CustomButton.Image = null;
            this.TxtUser.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.TxtUser.CustomButton.Name = "";
            this.TxtUser.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TxtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUser.CustomButton.TabIndex = 1;
            this.TxtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUser.CustomButton.UseSelectable = true;
            this.TxtUser.CustomButton.Visible = false;
            this.TxtUser.Lines = new string[0];
            this.TxtUser.Location = new System.Drawing.Point(144, 96);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUser.SelectedText = "";
            this.TxtUser.SelectionLength = 0;
            this.TxtUser.SelectionStart = 0;
            this.TxtUser.ShortcutsEnabled = true;
            this.TxtUser.Size = new System.Drawing.Size(219, 31);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUser.UseSelectable = true;
            this.TxtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPw
            // 
            // 
            // 
            // 
            this.TxtPw.CustomButton.Image = null;
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(144, 158);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '*';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(219, 31);
            this.TxtPw.TabIndex = 3;
            this.TxtPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnOk.Location = new System.Drawing.Point(100, 227);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(128, 59);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseCustomBackColor = true;
            this.BtnOk.UseSelectable = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancel.Location = new System.Drawing.Point(247, 227);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(128, 59);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseCustomBackColor = true;
            this.BtnCancel.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 408);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Universidad Americana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TxtUser;
        private MetroFramework.Controls.MetroTextBox TxtPw;
        private MetroFramework.Controls.MetroButton BtnOk;
        private MetroFramework.Controls.MetroButton BtnCancel;
    }
}

