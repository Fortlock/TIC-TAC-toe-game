namespace Tic_tac_toe_game
{
    partial class TicTacToe
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameField = new System.Windows.Forms.Panel();
            this.MessageField = new System.Windows.Forms.Label();
            this.Gamer = new System.Windows.Forms.RadioButton();
            this.Comp = new System.Windows.Forms.RadioButton();
            this.NGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameField.Location = new System.Drawing.Point(12, 12);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(302, 302);
            this.GameField.TabIndex = 0;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.GameField_Paint);
            this.GameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameField_MouseClick);
            // 
            // MessageField
            // 
            this.MessageField.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageField.Location = new System.Drawing.Point(320, 12);
            this.MessageField.Name = "MessageField";
            this.MessageField.Size = new System.Drawing.Size(266, 26);
            this.MessageField.TabIndex = 0;
            this.MessageField.Text = "Кто первый?";
            // 
            // Gamer
            // 
            this.Gamer.AutoSize = true;
            this.Gamer.Location = new System.Drawing.Point(324, 41);
            this.Gamer.Name = "Gamer";
            this.Gamer.Size = new System.Drawing.Size(56, 17);
            this.Gamer.TabIndex = 1;
            this.Gamer.TabStop = true;
            this.Gamer.Text = "Игрок";
            this.Gamer.UseVisualStyleBackColor = true;
            this.Gamer.CheckedChanged += new System.EventHandler(this.Gamer_CheckedChanged);
            // 
            // Comp
            // 
            this.Comp.AutoSize = true;
            this.Comp.Location = new System.Drawing.Point(415, 41);
            this.Comp.Name = "Comp";
            this.Comp.Size = new System.Drawing.Size(83, 17);
            this.Comp.TabIndex = 2;
            this.Comp.TabStop = true;
            this.Comp.Text = "Компьютер";
            this.Comp.UseVisualStyleBackColor = true;
            this.Comp.CheckedChanged += new System.EventHandler(this.Comp_CheckedChanged);
            // 
            // NGame
            // 
            this.NGame.Location = new System.Drawing.Point(324, 64);
            this.NGame.Name = "NGame";
            this.NGame.Size = new System.Drawing.Size(174, 23);
            this.NGame.TabIndex = 3;
            this.NGame.Text = "Новая игра";
            this.NGame.UseVisualStyleBackColor = true;
            this.NGame.Click += new System.EventHandler(this.NGame_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 326);
            this.Controls.Add(this.NGame);
            this.Controls.Add(this.Comp);
            this.Controls.Add(this.Gamer);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.GameField);
            this.Name = "TicTacToe";
            this.Text = "Крестики - нолики";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Label MessageField;
        private System.Windows.Forms.RadioButton Gamer;
        private System.Windows.Forms.RadioButton Comp;
        private System.Windows.Forms.Button NGame;
    }
}

