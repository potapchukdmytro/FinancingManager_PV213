namespace FinancingManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAll = new DataGridView();
            menuStrip1 = new MenuStrip();
            menuItemAdd = new ToolStripMenuItem();
            menuItemEdit = new ToolStripMenuItem();
            menuItemDelete = new ToolStripMenuItem();
            menuItemShow = new ToolStripMenuItem();
            menuItemShowAll = new ToolStripMenuItem();
            ьenuItemCosts = new ToolStripMenuItem();
            ьenuItemRevenue = new ToolStripMenuItem();
            textBoxSearch = new ToolStripTextBox();
            menuItemUSD = new ToolStripMenuItem();
            menuItemUAH = new ToolStripMenuItem();
            menuItemExit = new ToolStripMenuItem();
            dataGridViewTotal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTotal).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Location = new Point(12, 40);
            dataGridViewAll.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAll.MultiSelect = false;
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.RowHeadersVisible = false;
            dataGridViewAll.RowHeadersWidth = 51;
            dataGridViewAll.RowTemplate.Height = 25;
            dataGridViewAll.Size = new Size(857, 429);
            dataGridViewAll.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemAdd, menuItemEdit, menuItemDelete, menuItemShow, textBoxSearch, menuItemUSD, menuItemUAH, menuItemExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(881, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemAdd
            // 
            menuItemAdd.Image = Properties.Resources.free_icon_font_square_plus_9239975;
            menuItemAdd.Name = "menuItemAdd";
            menuItemAdd.Size = new Size(34, 27);
            // 
            // menuItemEdit
            // 
            menuItemEdit.Image = Properties.Resources.free_icon_font_settings_3917035;
            menuItemEdit.Name = "menuItemEdit";
            menuItemEdit.Size = new Size(34, 27);
            // 
            // menuItemDelete
            // 
            menuItemDelete.Image = Properties.Resources.free_icon_font_trash_3917176;
            menuItemDelete.Name = "menuItemDelete";
            menuItemDelete.Size = new Size(34, 27);
            // 
            // menuItemShow
            // 
            menuItemShow.DropDownItems.AddRange(new ToolStripItem[] { menuItemShowAll, ьenuItemCosts, ьenuItemRevenue });
            menuItemShow.Name = "menuItemShow";
            menuItemShow.Size = new Size(97, 27);
            menuItemShow.Text = "Показати...";
            // 
            // menuItemShowAll
            // 
            menuItemShowAll.Name = "menuItemShowAll";
            menuItemShowAll.Size = new Size(148, 26);
            menuItemShowAll.Text = "Все";
            // 
            // ьenuItemCosts
            // 
            ьenuItemCosts.Name = "ьenuItemCosts";
            ьenuItemCosts.Size = new Size(148, 26);
            ьenuItemCosts.Text = "Витрати";
            // 
            // ьenuItemRevenue
            // 
            ьenuItemRevenue.Name = "ьenuItemRevenue";
            ьenuItemRevenue.Size = new Size(148, 26);
            ьenuItemRevenue.Text = "Доходи";
            // 
            // textBoxSearch
            // 
            textBoxSearch.AutoSize = false;
            textBoxSearch.AutoToolTip = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(514, 27);
            textBoxSearch.Text = "Пошук";
            // 
            // menuItemUSD
            // 
            menuItemUSD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemUSD.Name = "menuItemUSD";
            menuItemUSD.Size = new Size(53, 27);
            menuItemUSD.Text = "USD";
            // 
            // menuItemUAH
            // 
            menuItemUAH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemUAH.Name = "menuItemUAH";
            menuItemUAH.Size = new Size(56, 27);
            menuItemUAH.Text = "UAH";
            // 
            // menuItemExit
            // 
            menuItemExit.Image = Properties.Resources.gui_check_no_icon_157196;
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new Size(34, 27);
            // 
            // dataGridViewTotal
            // 
            dataGridViewTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTotal.Location = new Point(14, 477);
            dataGridViewTotal.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTotal.Name = "dataGridViewTotal";
            dataGridViewTotal.RowHeadersWidth = 51;
            dataGridViewTotal.RowTemplate.Height = 25;
            dataGridViewTotal.Size = new Size(855, 107);
            dataGridViewTotal.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 589);
            Controls.Add(dataGridViewTotal);
            Controls.Add(dataGridViewAll);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Financing manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAll;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemAdd;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem menuItemDelete;
        private ToolStripMenuItem menuItemShow;
        private ToolStripMenuItem menuItemShowAll;
        private ToolStripMenuItem ьenuItemCosts;
        private ToolStripMenuItem ьenuItemRevenue;
        private ToolStripTextBox textBoxSearch;
        private ToolStripMenuItem menuItemUSD;
        private ToolStripMenuItem menuItemUAH;
        private ToolStripMenuItem menuItemExit;
        private DataGridView dataGridViewTotal;
    }
}
