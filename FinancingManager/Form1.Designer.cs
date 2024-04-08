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
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ьenuItemCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.ьenuItemRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUAH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUSD = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowTemplate.Height = 25;
            this.dataGridViewAll.Size = new System.Drawing.Size(723, 322);
            this.dataGridViewAll.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemEdit,
            this.menuItemDelete,
            this.menuItemShow,
            this.textBoxSearch,
            this.menuItemUSD,
            this.menuItemUAH,
            this.menuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Image = global::FinancingManager.Properties.Resources.free_icon_font_square_plus_9239975;
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(28, 23);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Image = global::FinancingManager.Properties.Resources.free_icon_font_settings_3917035;
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(28, 23);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = global::FinancingManager.Properties.Resources.free_icon_font_trash_3917176;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(28, 23);
            // 
            // menuItemShow
            // 
            this.menuItemShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShowAll,
            this.ьenuItemCosts,
            this.ьenuItemRevenue});
            this.menuItemShow.Name = "menuItemShow";
            this.menuItemShow.Size = new System.Drawing.Size(79, 23);
            this.menuItemShow.Text = "Показати...";
            // 
            // menuItemShowAll
            // 
            this.menuItemShowAll.Name = "menuItemShowAll";
            this.menuItemShowAll.Size = new System.Drawing.Size(180, 22);
            this.menuItemShowAll.Text = "Все";
            // 
            // ьenuItemCosts
            // 
            this.ьenuItemCosts.Name = "ьenuItemCosts";
            this.ьenuItemCosts.Size = new System.Drawing.Size(180, 22);
            this.ьenuItemCosts.Text = "Витрати";
            // 
            // ьenuItemRevenue
            // 
            this.ьenuItemRevenue.Name = "ьenuItemRevenue";
            this.ьenuItemRevenue.Size = new System.Drawing.Size(180, 22);
            this.ьenuItemRevenue.Text = "Доходи";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoSize = false;
            this.textBoxSearch.AutoToolTip = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 23);
            this.textBoxSearch.Text = "Пошук";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::FinancingManager.Properties.Resources.gui_check_no_icon_157196;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(28, 23);
            // 
            // menuItemUAH
            // 
            this.menuItemUAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItemUAH.Name = "menuItemUAH";
            this.menuItemUAH.Size = new System.Drawing.Size(45, 23);
            this.menuItemUAH.Text = "UAH";
            // 
            // menuItemUSD
            // 
            this.menuItemUSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItemUSD.Name = "menuItemUSD";
            this.menuItemUSD.Size = new System.Drawing.Size(44, 23);
            this.menuItemUSD.Text = "USD";
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(12, 358);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.RowTemplate.Height = 25;
            this.dataGridViewTotal.Size = new System.Drawing.Size(723, 148);
            this.dataGridViewTotal.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 516);
            this.Controls.Add(this.dataGridViewTotal);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Financing Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
