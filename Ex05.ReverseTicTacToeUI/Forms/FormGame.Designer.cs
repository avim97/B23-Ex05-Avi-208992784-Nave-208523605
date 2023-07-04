namespace Ex05.ReverseTicTacToeUI
{
    partial class FormGame
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
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGameOverview = new System.Windows.Forms.GroupBox();
            this.labelSecondPlayerScore = new System.Windows.Forms.Label();
            this.labelSecondPlayerMarker = new System.Windows.Forms.Label();
            this.labelSecondPlayerName = new System.Windows.Forms.Label();
            this.labelFirstPlayerScore = new System.Windows.Forms.Label();
            this.labelFirstPlayerMarker = new System.Windows.Forms.Label();
            this.labelFirstPlayerName = new System.Windows.Forms.Label();
            this.labelSecondPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.labelFirstPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.groupBoxGameOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBoard.ColumnCount = 2;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(22, 12);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 2;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(742, 375);
            this.tableLayoutPanelBoard.TabIndex = 0;
            // 
            // groupBoxGameOverview
            // 
            this.groupBoxGameOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGameOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxGameOverview.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerScore);
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerMarker);
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerName);
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerScore);
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerMarker);
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerName);
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerTurnIndicator);
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerTurnIndicator);
            this.groupBoxGameOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGameOverview.ForeColor = System.Drawing.Color.White;
            this.groupBoxGameOverview.Location = new System.Drawing.Point(22, 405);
            this.groupBoxGameOverview.MaximumSize = new System.Drawing.Size(755, 153);
            this.groupBoxGameOverview.MinimumSize = new System.Drawing.Size(755, 153);
            this.groupBoxGameOverview.Name = "groupBoxGameOverview";
            this.groupBoxGameOverview.Size = new System.Drawing.Size(755, 153);
            this.groupBoxGameOverview.TabIndex = 2;
            this.groupBoxGameOverview.TabStop = false;
            this.groupBoxGameOverview.Text = "Overview";
            // 
            // labelSecondPlayerScore
            // 
            this.labelSecondPlayerScore.AutoSize = true;
            this.labelSecondPlayerScore.Enabled = false;
            this.labelSecondPlayerScore.ForeColor = System.Drawing.Color.White;
            this.labelSecondPlayerScore.Location = new System.Drawing.Point(661, 112);
            this.labelSecondPlayerScore.Name = "labelSecondPlayerScore";
            this.labelSecondPlayerScore.Size = new System.Drawing.Size(70, 25);
            this.labelSecondPlayerScore.TabIndex = 7;
            this.labelSecondPlayerScore.Text = "label6";
            // 
            // labelSecondPlayerMarker
            // 
            this.labelSecondPlayerMarker.AutoSize = true;
            this.labelSecondPlayerMarker.Enabled = false;
            this.labelSecondPlayerMarker.ForeColor = System.Drawing.Color.White;
            this.labelSecondPlayerMarker.Location = new System.Drawing.Point(545, 112);
            this.labelSecondPlayerMarker.Name = "labelSecondPlayerMarker";
            this.labelSecondPlayerMarker.Size = new System.Drawing.Size(70, 25);
            this.labelSecondPlayerMarker.TabIndex = 6;
            this.labelSecondPlayerMarker.Text = "label5";
            // 
            // labelSecondPlayerName
            // 
            this.labelSecondPlayerName.AutoSize = true;
            this.labelSecondPlayerName.Enabled = false;
            this.labelSecondPlayerName.ForeColor = System.Drawing.Color.White;
            this.labelSecondPlayerName.Location = new System.Drawing.Point(418, 112);
            this.labelSecondPlayerName.Name = "labelSecondPlayerName";
            this.labelSecondPlayerName.Size = new System.Drawing.Size(70, 25);
            this.labelSecondPlayerName.TabIndex = 5;
            this.labelSecondPlayerName.Text = "label4";
            // 
            // labelFirstPlayerScore
            // 
            this.labelFirstPlayerScore.AutoSize = true;
            this.labelFirstPlayerScore.Enabled = false;
            this.labelFirstPlayerScore.ForeColor = System.Drawing.Color.White;
            this.labelFirstPlayerScore.Location = new System.Drawing.Point(258, 112);
            this.labelFirstPlayerScore.Name = "labelFirstPlayerScore";
            this.labelFirstPlayerScore.Size = new System.Drawing.Size(70, 25);
            this.labelFirstPlayerScore.TabIndex = 4;
            this.labelFirstPlayerScore.Text = "label3";
            // 
            // labelFirstPlayerMarker
            // 
            this.labelFirstPlayerMarker.AutoSize = true;
            this.labelFirstPlayerMarker.Enabled = false;
            this.labelFirstPlayerMarker.ForeColor = System.Drawing.Color.White;
            this.labelFirstPlayerMarker.Location = new System.Drawing.Point(142, 112);
            this.labelFirstPlayerMarker.Name = "labelFirstPlayerMarker";
            this.labelFirstPlayerMarker.Size = new System.Drawing.Size(70, 25);
            this.labelFirstPlayerMarker.TabIndex = 3;
            this.labelFirstPlayerMarker.Text = "label2";
            // 
            // labelFirstPlayerName
            // 
            this.labelFirstPlayerName.AutoSize = true;
            this.labelFirstPlayerName.Enabled = false;
            this.labelFirstPlayerName.ForeColor = System.Drawing.Color.White;
            this.labelFirstPlayerName.Location = new System.Drawing.Point(15, 112);
            this.labelFirstPlayerName.Name = "labelFirstPlayerName";
            this.labelFirstPlayerName.Size = new System.Drawing.Size(70, 25);
            this.labelFirstPlayerName.TabIndex = 2;
            this.labelFirstPlayerName.Text = "label1";
            // 
            // labelSecondPlayerTurnIndicator
            // 
            this.labelSecondPlayerTurnIndicator.AutoSize = true;
            this.labelSecondPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSecondPlayerTurnIndicator.Enabled = false;
            this.labelSecondPlayerTurnIndicator.ForeColor = System.Drawing.Color.Lime;
            this.labelSecondPlayerTurnIndicator.Location = new System.Drawing.Point(525, 37);
            this.labelSecondPlayerTurnIndicator.Name = "labelSecondPlayerTurnIndicator";
            this.labelSecondPlayerTurnIndicator.Size = new System.Drawing.Size(110, 27);
            this.labelSecondPlayerTurnIndicator.TabIndex = 1;
            this.labelSecondPlayerTurnIndicator.Text = "Your Turn";
            this.labelSecondPlayerTurnIndicator.Visible = false;
            // 
            // labelFirstPlayerTurnIndicator
            // 
            this.labelFirstPlayerTurnIndicator.AutoSize = true;
            this.labelFirstPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirstPlayerTurnIndicator.Enabled = false;
            this.labelFirstPlayerTurnIndicator.ForeColor = System.Drawing.Color.Lime;
            this.labelFirstPlayerTurnIndicator.Location = new System.Drawing.Point(124, 37);
            this.labelFirstPlayerTurnIndicator.Name = "labelFirstPlayerTurnIndicator";
            this.labelFirstPlayerTurnIndicator.Size = new System.Drawing.Size(110, 27);
            this.labelFirstPlayerTurnIndicator.TabIndex = 0;
            this.labelFirstPlayerTurnIndicator.Text = "Your Turn";
            this.labelFirstPlayerTurnIndicator.Click += new System.EventHandler(this.labelFirstPlayerCurrentTurn_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ex05.ReverseTicTacToeUI.Properties.Resources.formGameSessionBackground;
            this.ClientSize = new System.Drawing.Size(795, 574);
            this.Controls.Add(this.groupBoxGameOverview);
            this.Controls.Add(this.tableLayoutPanelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reverse Tic Tac Toe";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.groupBoxGameOverview.ResumeLayout(false);
            this.groupBoxGameOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.GroupBox groupBoxGameOverview;
        private System.Windows.Forms.Label labelFirstPlayerTurnIndicator;
        private System.Windows.Forms.Label labelSecondPlayerTurnIndicator;
        private System.Windows.Forms.Label labelSecondPlayerScore;
        private System.Windows.Forms.Label labelSecondPlayerMarker;
        private System.Windows.Forms.Label labelSecondPlayerName;
        private System.Windows.Forms.Label labelFirstPlayerScore;
        private System.Windows.Forms.Label labelFirstPlayerMarker;
        private System.Windows.Forms.Label labelFirstPlayerName;
    }
}

