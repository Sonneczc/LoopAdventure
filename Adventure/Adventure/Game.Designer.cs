namespace Adventure
{
    partial class Game
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
            this.groupBox_Player = new System.Windows.Forms.GroupBox();
            this.tabControl_Player = new System.Windows.Forms.TabControl();
            this.tabPage_Player_Detail = new System.Windows.Forms.TabPage();
            this.tabPage_Player_Profile = new System.Windows.Forms.TabPage();
            this.tabPage_Player_Inventory = new System.Windows.Forms.TabPage();
            this.tabPage_Player_Skill = new System.Windows.Forms.TabPage();
            this.groupBox_LOG = new System.Windows.Forms.GroupBox();
            this.groupBox_Battle = new System.Windows.Forms.GroupBox();
            this.groupBox_Battle_Map = new System.Windows.Forms.GroupBox();
            this.groupBox_Player.SuspendLayout();
            this.tabControl_Player.SuspendLayout();
            this.groupBox_Battle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Player
            // 
            this.groupBox_Player.Controls.Add(this.tabControl_Player);
            this.groupBox_Player.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Player.Name = "groupBox_Player";
            this.groupBox_Player.Size = new System.Drawing.Size(374, 292);
            this.groupBox_Player.TabIndex = 0;
            this.groupBox_Player.TabStop = false;
            this.groupBox_Player.Text = "groupBox1";
            // 
            // tabControl_Player
            // 
            this.tabControl_Player.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_Player.Controls.Add(this.tabPage_Player_Profile);
            this.tabControl_Player.Controls.Add(this.tabPage_Player_Detail);
            this.tabControl_Player.Controls.Add(this.tabPage_Player_Inventory);
            this.tabControl_Player.Controls.Add(this.tabPage_Player_Skill);
            this.tabControl_Player.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl_Player.Location = new System.Drawing.Point(7, 20);
            this.tabControl_Player.Multiline = true;
            this.tabControl_Player.Name = "tabControl_Player";
            this.tabControl_Player.SelectedIndex = 0;
            this.tabControl_Player.Size = new System.Drawing.Size(361, 266);
            this.tabControl_Player.TabIndex = 0;
            // 
            // tabPage_Player_Detail
            // 
            this.tabPage_Player_Detail.Location = new System.Drawing.Point(22, 4);
            this.tabPage_Player_Detail.Name = "tabPage_Player_Detail";
            this.tabPage_Player_Detail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Player_Detail.Size = new System.Drawing.Size(335, 258);
            this.tabPage_Player_Detail.TabIndex = 1;
            this.tabPage_Player_Detail.Text = "Detail";
            this.tabPage_Player_Detail.UseVisualStyleBackColor = true;
            // 
            // tabPage_Player_Profile
            // 
            this.tabPage_Player_Profile.Location = new System.Drawing.Point(22, 4);
            this.tabPage_Player_Profile.Name = "tabPage_Player_Profile";
            this.tabPage_Player_Profile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Player_Profile.Size = new System.Drawing.Size(335, 258);
            this.tabPage_Player_Profile.TabIndex = 0;
            this.tabPage_Player_Profile.Text = "Profile";
            this.tabPage_Player_Profile.UseVisualStyleBackColor = true;
            // 
            // tabPage_Player_Inventory
            // 
            this.tabPage_Player_Inventory.Location = new System.Drawing.Point(22, 4);
            this.tabPage_Player_Inventory.Name = "tabPage_Player_Inventory";
            this.tabPage_Player_Inventory.Size = new System.Drawing.Size(335, 258);
            this.tabPage_Player_Inventory.TabIndex = 2;
            this.tabPage_Player_Inventory.Text = "Inventory";
            this.tabPage_Player_Inventory.UseVisualStyleBackColor = true;
            // 
            // tabPage_Player_Skill
            // 
            this.tabPage_Player_Skill.Location = new System.Drawing.Point(22, 4);
            this.tabPage_Player_Skill.Name = "tabPage_Player_Skill";
            this.tabPage_Player_Skill.Size = new System.Drawing.Size(335, 258);
            this.tabPage_Player_Skill.TabIndex = 3;
            this.tabPage_Player_Skill.Text = "Skills";
            this.tabPage_Player_Skill.UseVisualStyleBackColor = true;
            // 
            // groupBox_LOG
            // 
            this.groupBox_LOG.Location = new System.Drawing.Point(12, 304);
            this.groupBox_LOG.Name = "groupBox_LOG";
            this.groupBox_LOG.Size = new System.Drawing.Size(374, 232);
            this.groupBox_LOG.TabIndex = 1;
            this.groupBox_LOG.TabStop = false;
            this.groupBox_LOG.Text = "LOG";
            // 
            // groupBox_Battle
            // 
            this.groupBox_Battle.Controls.Add(this.groupBox_Battle_Map);
            this.groupBox_Battle.Location = new System.Drawing.Point(398, 12);
            this.groupBox_Battle.Name = "groupBox_Battle";
            this.groupBox_Battle.Size = new System.Drawing.Size(417, 524);
            this.groupBox_Battle.TabIndex = 2;
            this.groupBox_Battle.TabStop = false;
            // 
            // groupBox_Battle_Map
            // 
            this.groupBox_Battle_Map.Location = new System.Drawing.Point(5, 383);
            this.groupBox_Battle_Map.Name = "groupBox_Battle_Map";
            this.groupBox_Battle_Map.Size = new System.Drawing.Size(406, 135);
            this.groupBox_Battle_Map.TabIndex = 0;
            this.groupBox_Battle_Map.TabStop = false;
            this.groupBox_Battle_Map.Text = "Map";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 548);
            this.Controls.Add(this.groupBox_Battle);
            this.Controls.Add(this.groupBox_LOG);
            this.Controls.Add(this.groupBox_Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adventure";
            this.groupBox_Player.ResumeLayout(false);
            this.tabControl_Player.ResumeLayout(false);
            this.groupBox_Battle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Player;
        private System.Windows.Forms.TabControl tabControl_Player;
        private System.Windows.Forms.TabPage tabPage_Player_Profile;
        private System.Windows.Forms.TabPage tabPage_Player_Detail;
        private System.Windows.Forms.TabPage tabPage_Player_Inventory;
        private System.Windows.Forms.TabPage tabPage_Player_Skill;
        private System.Windows.Forms.GroupBox groupBox_LOG;
        private System.Windows.Forms.GroupBox groupBox_Battle;
        private System.Windows.Forms.GroupBox groupBox_Battle_Map;
    }
}

