namespace MyHousekeepingBook
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変更EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧表示LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new MyHousekeepingBook.MoneyDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.categoryDataSet1 = new MyHousekeepingBook.CategoryDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.sumDgv = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summaryDataSet = new MyHousekeepingBook.SummaryDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(1361, 36);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.変更EToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 追加AToolStripMenuItem
            // 
            this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
            this.追加AToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.追加AToolStripMenuItem.Text = "追加(&A)";
            this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
            // 
            // 変更EToolStripMenuItem
            // 
            this.変更EToolStripMenuItem.Name = "変更EToolStripMenuItem";
            this.変更EToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.変更EToolStripMenuItem.Text = "変更(&C)";
            this.変更EToolStripMenuItem.Click += new System.EventHandler(this.変更EToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表示LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(85, 30);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 一覧表示LToolStripMenuItem
            // 
            this.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem";
            this.一覧表示LToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)";
            this.一覧表示LToolStripMenuItem.Click += new System.EventHandler(this.一覧表示LToolStripMenuItem_Click);
            // 
            // 集計表示SToolStripMenuItem
            // 
            this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
            this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
            this.集計表示SToolStripMenuItem.Click += new System.EventHandler(this.集計表示SToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moneyDataTableBindingSource;
            this.dgv.Location = new System.Drawing.Point(10, 9);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(1002, 516);
            this.dgv.TabIndex = 1;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.Width = 150;
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            this.分類DataGridViewTextBoxColumn.Width = 150;
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            this.品名DataGridViewTextBoxColumn.Width = 150;
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            this.金額DataGridViewTextBoxColumn.Width = 150;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.Width = 150;
            // 
            // moneyDataTableBindingSource
            // 
            this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource.DataSource = this.moneyDataSet;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 534);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(145, 534);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(125, 34);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "変更";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(280, 534);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 34);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(887, 533);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(125, 34);
            this.buttonEnd.TabIndex = 5;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // categoryDataSet1
            // 
            this.categoryDataSet1.DataSetName = "CategoryDataSet";
            this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Location = new System.Drawing.Point(20, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 616);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.pictureBox2);
            this.tabList.Controls.Add(this.pictureBox1);
            this.tabList.Controls.Add(this.dgv);
            this.tabList.Controls.Add(this.buttonEnd);
            this.tabList.Controls.Add(this.buttonAdd);
            this.tabList.Controls.Add(this.buttonDelete);
            this.tabList.Controls.Add(this.buttonChange);
            this.tabList.Location = new System.Drawing.Point(4, 28);
            this.tabList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabList.Size = new System.Drawing.Size(1285, 584);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "一覧表示";
            this.tabList.UseVisualStyleBackColor = true;
            this.tabList.Click += new System.EventHandler(this.tabList_Click);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.sumDgv);
            this.tabSummary.Location = new System.Drawing.Point(4, 28);
            this.tabSummary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabSummary.Size = new System.Drawing.Size(1285, 584);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "集計表示";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // sumDgv
            // 
            this.sumDgv.AutoGenerateColumns = false;
            this.sumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn1,
            this.入金合計DataGridViewTextBoxColumn,
            this.出金合計DataGridViewTextBoxColumn});
            this.sumDgv.DataSource = this.sumDataTableBindingSource;
            this.sumDgv.Location = new System.Drawing.Point(10, 9);
            this.sumDgv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sumDgv.Name = "sumDgv";
            this.sumDgv.RowHeadersWidth = 62;
            this.sumDgv.RowTemplate.Height = 21;
            this.sumDgv.Size = new System.Drawing.Size(1260, 560);
            this.sumDgv.TabIndex = 0;
            // 
            // 日付DataGridViewTextBoxColumn1
            // 
            this.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn1.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1";
            this.日付DataGridViewTextBoxColumn1.Width = 150;
            // 
            // 入金合計DataGridViewTextBoxColumn
            // 
            this.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn";
            this.入金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // 出金合計DataGridViewTextBoxColumn
            // 
            this.出金合計DataGridViewTextBoxColumn.DataPropertyName = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.HeaderText = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.出金合計DataGridViewTextBoxColumn.Name = "出金合計DataGridViewTextBoxColumn";
            this.出金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // sumDataTableBindingSource
            // 
            this.sumDataTableBindingSource.DataMember = "SumDataTable";
            this.sumDataTableBindingSource.DataSource = this.summaryDataSet;
            // 
            // summaryDataSet
            // 
            this.summaryDataSet.DataSetName = "SummaryDataSet";
            this.summaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyHousekeepingBook.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(1078, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyHousekeepingBook.Properties.Resources.sako_pornhub;
            this.pictureBox1.Location = new System.Drawing.Point(821, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "簡易家計簿";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sumDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変更EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧表示LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
        private MoneyDataSet moneyDataSet;
        private CategoryDataSet categoryDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.DataGridView sumDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sumDataTableBindingSource;
        private SummaryDataSet summaryDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

