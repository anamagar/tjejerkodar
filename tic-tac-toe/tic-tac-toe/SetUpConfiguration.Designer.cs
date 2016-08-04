namespace tic_tac_toe
{
    partial class SetUpConfiguration
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
            this.play = new System.Windows.Forms.Button();
            this.boardSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enablePlayer2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.player1PanelInfo = new System.Windows.Forms.Panel();
            this.turnPlayer1 = new System.Windows.Forms.CheckBox();
            this.player1Piece0 = new System.Windows.Forms.CheckBox();
            this.player1PieceX = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.player2PanelInfo = new System.Windows.Forms.Panel();
            this.turnPlayer2 = new System.Windows.Forms.CheckBox();
            this.player2Piece0 = new System.Windows.Forms.CheckBox();
            this.player2PieceX = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player1PanelInfo.SuspendLayout();
            this.player2PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(63, 388);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(208, 42);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // boardSize
            // 
            this.boardSize.Location = new System.Drawing.Point(18, 32);
            this.boardSize.Name = "boardSize";
            this.boardSize.Size = new System.Drawing.Size(100, 20);
            this.boardSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert the size of the board, by default is 3x3";
            // 
            // enablePlayer2
            // 
            this.enablePlayer2.AutoSize = true;
            this.enablePlayer2.Location = new System.Drawing.Point(16, 207);
            this.enablePlayer2.Name = "enablePlayer2";
            this.enablePlayer2.Size = new System.Drawing.Size(254, 17);
            this.enablePlayer2.TabIndex = 5;
            this.enablePlayer2.TabStop = true;
            this.enablePlayer2.Text = "Choose another player otherwise is the computer";
            this.enablePlayer2.UseVisualStyleBackColor = true;
            this.enablePlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enablePlayer2_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player 1";
            // 
            // player1PanelInfo
            // 
            this.player1PanelInfo.Controls.Add(this.turnPlayer1);
            this.player1PanelInfo.Controls.Add(this.player1Piece0);
            this.player1PanelInfo.Controls.Add(this.player1PieceX);
            this.player1PanelInfo.Controls.Add(this.label7);
            this.player1PanelInfo.Controls.Add(this.player1Name);
            this.player1PanelInfo.Controls.Add(this.label6);
            this.player1PanelInfo.Location = new System.Drawing.Point(16, 91);
            this.player1PanelInfo.Name = "player1PanelInfo";
            this.player1PanelInfo.Size = new System.Drawing.Size(316, 100);
            this.player1PanelInfo.TabIndex = 10;
            // 
            // turnPlayer1
            // 
            this.turnPlayer1.AutoSize = true;
            this.turnPlayer1.Checked = true;
            this.turnPlayer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.turnPlayer1.Location = new System.Drawing.Point(169, 67);
            this.turnPlayer1.Name = "turnPlayer1";
            this.turnPlayer1.Size = new System.Drawing.Size(70, 17);
            this.turnPlayer1.TabIndex = 10;
            this.turnPlayer1.Text = "First Turn";
            this.turnPlayer1.UseVisualStyleBackColor = true;
            this.turnPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.turnPlayer_MouseClick);
            // 
            // player1Piece0
            // 
            this.player1Piece0.AutoSize = true;
            this.player1Piece0.Location = new System.Drawing.Point(47, 67);
            this.player1Piece0.Name = "player1Piece0";
            this.player1Piece0.Size = new System.Drawing.Size(32, 17);
            this.player1Piece0.TabIndex = 9;
            this.player1Piece0.Text = "0";
            this.player1Piece0.UseVisualStyleBackColor = true;
            this.player1Piece0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pieceOfPlayer);
            // 
            // player1PieceX
            // 
            this.player1PieceX.AutoSize = true;
            this.player1PieceX.Checked = true;
            this.player1PieceX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player1PieceX.Location = new System.Drawing.Point(8, 67);
            this.player1PieceX.Name = "player1PieceX";
            this.player1PieceX.Size = new System.Drawing.Size(33, 17);
            this.player1PieceX.TabIndex = 8;
            this.player1PieceX.Text = "X";
            this.player1PieceX.UseVisualStyleBackColor = true;
            this.player1PieceX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pieceOfPlayer);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Piece";
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(6, 21);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(143, 20);
            this.player1Name.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // player2PanelInfo
            // 
            this.player2PanelInfo.Controls.Add(this.turnPlayer2);
            this.player2PanelInfo.Controls.Add(this.player2Piece0);
            this.player2PanelInfo.Controls.Add(this.player2PieceX);
            this.player2PanelInfo.Controls.Add(this.label2);
            this.player2PanelInfo.Controls.Add(this.player2Name);
            this.player2PanelInfo.Controls.Add(this.label3);
            this.player2PanelInfo.Enabled = false;
            this.player2PanelInfo.Location = new System.Drawing.Point(12, 263);
            this.player2PanelInfo.Name = "player2PanelInfo";
            this.player2PanelInfo.Size = new System.Drawing.Size(316, 100);
            this.player2PanelInfo.TabIndex = 11;
            // 
            // turnPlayer2
            // 
            this.turnPlayer2.AutoSize = true;
            this.turnPlayer2.Location = new System.Drawing.Point(173, 67);
            this.turnPlayer2.Name = "turnPlayer2";
            this.turnPlayer2.Size = new System.Drawing.Size(70, 17);
            this.turnPlayer2.TabIndex = 11;
            this.turnPlayer2.Text = "First Turn";
            this.turnPlayer2.UseVisualStyleBackColor = true;
            this.turnPlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.turnPlayer_MouseClick);
            // 
            // player2Piece0
            // 
            this.player2Piece0.AutoSize = true;
            this.player2Piece0.Checked = true;
            this.player2Piece0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player2Piece0.Location = new System.Drawing.Point(47, 67);
            this.player2Piece0.Name = "player2Piece0";
            this.player2Piece0.Size = new System.Drawing.Size(32, 17);
            this.player2Piece0.TabIndex = 9;
            this.player2Piece0.Text = "0";
            this.player2Piece0.UseVisualStyleBackColor = true;
            this.player2Piece0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pieceOfPlayer);
            // 
            // player2PieceX
            // 
            this.player2PieceX.AutoSize = true;
            this.player2PieceX.Location = new System.Drawing.Point(8, 67);
            this.player2PieceX.Name = "player2PieceX";
            this.player2PieceX.Size = new System.Drawing.Size(33, 17);
            this.player2PieceX.TabIndex = 8;
            this.player2PieceX.Text = "X";
            this.player2PieceX.UseVisualStyleBackColor = true;
            this.player2PieceX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pieceOfPlayer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Piece";
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(6, 21);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(143, 20);
            this.player2Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Player 2";
            // 
            // SetUpConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player2PanelInfo);
            this.Controls.Add(this.player1PanelInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enablePlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boardSize);
            this.Controls.Add(this.play);
            this.Name = "SetUpConfiguration";
            this.Text = "Tic-Tac-Toe";
            this.player1PanelInfo.ResumeLayout(false);
            this.player1PanelInfo.PerformLayout();
            this.player2PanelInfo.ResumeLayout(false);
            this.player2PanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.TextBox boardSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton enablePlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel player1PanelInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox player1Piece0;
        private System.Windows.Forms.CheckBox player1PieceX;
        private System.Windows.Forms.Panel player2PanelInfo;
        private System.Windows.Forms.CheckBox player2Piece0;
        private System.Windows.Forms.CheckBox player2PieceX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox turnPlayer1;
        private System.Windows.Forms.CheckBox turnPlayer2;
    }
}