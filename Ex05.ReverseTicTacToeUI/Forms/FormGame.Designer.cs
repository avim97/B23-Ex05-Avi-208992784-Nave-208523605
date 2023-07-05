namespace Ex05.ReverseTicTacToeUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGameOverview = new System.Windows.Forms.GroupBox();
            this.splitContainerPlayersOverview = new System.Windows.Forms.SplitContainer();
            this.labelFirstPlayerOverview = new System.Windows.Forms.Label();
            this.labelFirstPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.labelSecondPlayerOverview = new System.Windows.Forms.Label();
            this.labelSecondPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.groupBoxGameOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPlayersOverview)).BeginInit();
            this.splitContainerPlayersOverview.Panel1.SuspendLayout();
            this.splitContainerPlayersOverview.Panel2.SuspendLayout();
            this.splitContainerPlayersOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBoard.ColumnCount = 2;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(35, 33);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 2;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(742, 375);
            this.tableLayoutPanelBoard.TabIndex = 0;
            // 
            // groupBoxGameOverview
            // 
            this.groupBoxGameOverview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxGameOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxGameOverview.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGameOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxGameOverview.Controls.Add(this.splitContainerPlayersOverview);
            this.groupBoxGameOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGameOverview.ForeColor = System.Drawing.Color.White;
            this.groupBoxGameOverview.Location = new System.Drawing.Point(35, 424);
            this.groupBoxGameOverview.MaximumSize = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.MinimumSize = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.Name = "groupBoxGameOverview";
            this.groupBoxGameOverview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxGameOverview.Size = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.TabIndex = 1;
            this.groupBoxGameOverview.TabStop = false;
            this.groupBoxGameOverview.Text = "Overview";
            // 
            // splitContainerPlayersOverview
            // 
            this.splitContainerPlayersOverview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerPlayersOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPlayersOverview.IsSplitterFixed = true;
            this.splitContainerPlayersOverview.Location = new System.Drawing.Point(3, 26);
            this.splitContainerPlayersOverview.MaximumSize = new System.Drawing.Size(742, 125);
            this.splitContainerPlayersOverview.Name = "splitContainerPlayersOverview";
            // 
            // splitContainerPlayersOverview.Panel1
            // 
            this.splitContainerPlayersOverview.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainerPlayersOverview.Panel1.Controls.Add(this.labelFirstPlayerOverview);
            this.splitContainerPlayersOverview.Panel1.Controls.Add(this.labelFirstPlayerTurnIndicator);
            this.splitContainerPlayersOverview.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerPlayersOverview.Panel1MinSize = 125;
            // 
            // splitContainerPlayersOverview.Panel2
            // 
            this.splitContainerPlayersOverview.Panel2.Controls.Add(this.labelSecondPlayerOverview);
            this.splitContainerPlayersOverview.Panel2.Controls.Add(this.labelSecondPlayerTurnIndicator);
            this.splitContainerPlayersOverview.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainerPlayersOverview.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerPlayersOverview.Panel2MinSize = 125;
            this.splitContainerPlayersOverview.Size = new System.Drawing.Size(742, 125);
            this.splitContainerPlayersOverview.SplitterDistance = 377;
            this.splitContainerPlayersOverview.SplitterWidth = 1;
            this.splitContainerPlayersOverview.TabIndex = 8;
            // 
            // labelFirstPlayerOverview
            // 
            this.labelFirstPlayerOverview.AutoSize = true;
            this.labelFirstPlayerOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPlayerOverview.ForeColor = System.Drawing.Color.White;
            this.labelFirstPlayerOverview.Location = new System.Drawing.Point(14, 83);
            this.labelFirstPlayerOverview.Name = "labelFirstPlayerOverview";
            this.labelFirstPlayerOverview.Size = new System.Drawing.Size(64, 22);
            this.labelFirstPlayerOverview.TabIndex = 1;
            this.labelFirstPlayerOverview.Text = "label1";
            this.labelFirstPlayerOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstPlayerTurnIndicator
            // 
            this.labelFirstPlayerTurnIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstPlayerTurnIndicator.AutoSize = true;
            this.labelFirstPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirstPlayerTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPlayerTurnIndicator.ForeColor = System.Drawing.Color.Gold;
            this.labelFirstPlayerTurnIndicator.Location = new System.Drawing.Point(121, 13);
            this.labelFirstPlayerTurnIndicator.Name = "labelFirstPlayerTurnIndicator";
            this.labelFirstPlayerTurnIndicator.Size = new System.Drawing.Size(102, 24);
            this.labelFirstPlayerTurnIndicator.TabIndex = 0;
            this.labelFirstPlayerTurnIndicator.Text = "Your Turn";
            // 
            // labelSecondPlayerOverview
            // 
            this.labelSecondPlayerOverview.AllowDrop = true;
            this.labelSecondPlayerOverview.AutoSize = true;
            this.labelSecondPlayerOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondPlayerOverview.ForeColor = System.Drawing.Color.White;
            this.labelSecondPlayerOverview.Location = new System.Drawing.Point(13, 83);
            this.labelSecondPlayerOverview.Name = "labelSecondPlayerOverview";
            this.labelSecondPlayerOverview.Size = new System.Drawing.Size(64, 22);
            this.labelSecondPlayerOverview.TabIndex = 3;
            this.labelSecondPlayerOverview.Text = "label2";
            this.labelSecondPlayerOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondPlayerTurnIndicator
            // 
            this.labelSecondPlayerTurnIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondPlayerTurnIndicator.AutoSize = true;
            this.labelSecondPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSecondPlayerTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondPlayerTurnIndicator.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelSecondPlayerTurnIndicator.Location = new System.Drawing.Point(135, 13);
            this.labelSecondPlayerTurnIndicator.Name = "labelSecondPlayerTurnIndicator";
            this.labelSecondPlayerTurnIndicator.Size = new System.Drawing.Size(102, 24);
            this.labelSecondPlayerTurnIndicator.TabIndex = 2;
            this.labelSecondPlayerTurnIndicator.Text = "Your Turn";
            this.labelSecondPlayerTurnIndicator.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ex05.ReverseTicTacToeUI.Properties.Resources.formGameSessionBackground;
            this.ClientSize = new System.Drawing.Size(816, 609);
            this.Controls.Add(this.groupBoxGameOverview);
            this.Controls.Add(this.tableLayoutPanelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reverse Tic Tac Toe";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.groupBoxGameOverview.ResumeLayout(false);
            this.splitContainerPlayersOverview.Panel1.ResumeLayout(false);
            this.splitContainerPlayersOverview.Panel1.PerformLayout();
            this.splitContainerPlayersOverview.Panel2.ResumeLayout(false);
            this.splitContainerPlayersOverview.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPlayersOverview)).EndInit();
            this.splitContainerPlayersOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.Label labelFirstPlayerTurnIndicator;
        private System.Windows.Forms.Label labelSecondPlayerTurnIndicator;
        private System.Windows.Forms.Label labelSecondPlayerOverview;
        private System.Windows.Forms.Label labelFirstPlayerOverview;
        private System.Windows.Forms.SplitContainer splitContainerPlayersOverview;
        private System.Windows.Forms.GroupBox groupBoxGameOverview;
    }
}

