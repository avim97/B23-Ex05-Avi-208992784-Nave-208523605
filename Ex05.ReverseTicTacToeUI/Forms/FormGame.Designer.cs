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
            this.labelFirstPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.labelSecondPlayerOverview = new System.Windows.Forms.Label();
            this.labelSecondPlayerTurnIndicator = new System.Windows.Forms.Label();
            this.labelFirstPlayerOverview = new System.Windows.Forms.Label();
            this.groupBoxGameOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBoard.ColumnCount = 2;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(27, 33);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 2;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(750, 385);
            this.tableLayoutPanelBoard.TabIndex = 0;
            // 
            // groupBoxGameOverview
            // 
            this.groupBoxGameOverview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxGameOverview.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGameOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerTurnIndicator);
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerOverview);
            this.groupBoxGameOverview.Controls.Add(this.labelFirstPlayerOverview);
            this.groupBoxGameOverview.Controls.Add(this.labelSecondPlayerTurnIndicator);
            this.groupBoxGameOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGameOverview.ForeColor = System.Drawing.Color.White;
            this.groupBoxGameOverview.Location = new System.Drawing.Point(27, 424);
            this.groupBoxGameOverview.MaximumSize = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.MinimumSize = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.Name = "groupBoxGameOverview";
            this.groupBoxGameOverview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxGameOverview.Size = new System.Drawing.Size(750, 160);
            this.groupBoxGameOverview.TabIndex = 1;
            this.groupBoxGameOverview.TabStop = false;
            this.groupBoxGameOverview.Text = "Overview";
            // 
            // labelFirstPlayerTurnIndicator
            // 
            this.labelFirstPlayerTurnIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstPlayerTurnIndicator.AutoSize = true;
            this.labelFirstPlayerTurnIndicator.BackColor = System.Drawing.Color.Gold;
            this.labelFirstPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFirstPlayerTurnIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelFirstPlayerTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPlayerTurnIndicator.ForeColor = System.Drawing.Color.Black;
            this.labelFirstPlayerTurnIndicator.Location = new System.Drawing.Point(94, 52);
            this.labelFirstPlayerTurnIndicator.Name = "labelFirstPlayerTurnIndicator";
            this.labelFirstPlayerTurnIndicator.Size = new System.Drawing.Size(93, 24);
            this.labelFirstPlayerTurnIndicator.TabIndex = 4;
            this.labelFirstPlayerTurnIndicator.Text = "Your Turn";
            // 
            // labelSecondPlayerOverview
            // 
            this.labelSecondPlayerOverview.AllowDrop = true;
            this.labelSecondPlayerOverview.AutoSize = true;
            this.labelSecondPlayerOverview.BackColor = System.Drawing.Color.Aquamarine;
            this.labelSecondPlayerOverview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSecondPlayerOverview.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondPlayerOverview.ForeColor = System.Drawing.Color.Black;
            this.labelSecondPlayerOverview.Location = new System.Drawing.Point(406, 100);
            this.labelSecondPlayerOverview.Name = "labelSecondPlayerOverview";
            this.labelSecondPlayerOverview.Size = new System.Drawing.Size(68, 23);
            this.labelSecondPlayerOverview.TabIndex = 7;
            this.labelSecondPlayerOverview.Text = "label2";
            this.labelSecondPlayerOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSecondPlayerTurnIndicator
            // 
            this.labelSecondPlayerTurnIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondPlayerTurnIndicator.AutoSize = true;
            this.labelSecondPlayerTurnIndicator.BackColor = System.Drawing.Color.Aquamarine;
            this.labelSecondPlayerTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSecondPlayerTurnIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSecondPlayerTurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondPlayerTurnIndicator.ForeColor = System.Drawing.Color.Black;
            this.labelSecondPlayerTurnIndicator.Location = new System.Drawing.Point(501, 52);
            this.labelSecondPlayerTurnIndicator.Name = "labelSecondPlayerTurnIndicator";
            this.labelSecondPlayerTurnIndicator.Size = new System.Drawing.Size(93, 24);
            this.labelSecondPlayerTurnIndicator.TabIndex = 6;
            this.labelSecondPlayerTurnIndicator.Text = "Your Turn";
            this.labelSecondPlayerTurnIndicator.Visible = false;
            // 
            // labelFirstPlayerOverview
            // 
            this.labelFirstPlayerOverview.AutoSize = true;
            this.labelFirstPlayerOverview.BackColor = System.Drawing.Color.Gold;
            this.labelFirstPlayerOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFirstPlayerOverview.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstPlayerOverview.ForeColor = System.Drawing.Color.Black;
            this.labelFirstPlayerOverview.Location = new System.Drawing.Point(38, 100);
            this.labelFirstPlayerOverview.Name = "labelFirstPlayerOverview";
            this.labelFirstPlayerOverview.Size = new System.Drawing.Size(68, 23);
            this.labelFirstPlayerOverview.TabIndex = 5;
            this.labelFirstPlayerOverview.Text = "label1";
            this.labelFirstPlayerOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBoxGameOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.GroupBox groupBoxGameOverview;
        private System.Windows.Forms.Label labelFirstPlayerTurnIndicator;
        private System.Windows.Forms.Label labelSecondPlayerOverview;
        private System.Windows.Forms.Label labelFirstPlayerOverview;
        private System.Windows.Forms.Label labelSecondPlayerTurnIndicator;
    }
}

