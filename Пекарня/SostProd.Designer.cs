namespace Пекарня
{
    partial class SostProd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SostProd));
            System.Windows.Forms.Label иД_СоставаLabel;
            System.Windows.Forms.Label иД_ВыпечкиLabel;
            System.Windows.Forms.Label иД_ИнгредиентаLabel;
            System.Windows.Forms.Label кол_воLabel;
            this.бД_ПекарняDataSet = new Пекарня.БД_ПекарняDataSet();
            this.состав_ПродукцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состав_ПродукцииTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.Состав_ПродукцииTableAdapter();
            this.tableAdapterManager = new Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager();
            this.состав_ПродукцииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.состав_ПродукцииDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.состав_ПродукцииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иД_СоставаTextBox = new System.Windows.Forms.TextBox();
            this.иД_ВыпечкиTextBox = new System.Windows.Forms.TextBox();
            this.иД_ИнгредиентаTextBox = new System.Windows.Forms.TextBox();
            this.кол_воTextBox = new System.Windows.Forms.TextBox();
            this.btnObnovit4 = new System.Windows.Forms.Button();
            иД_СоставаLabel = new System.Windows.Forms.Label();
            иД_ВыпечкиLabel = new System.Windows.Forms.Label();
            иД_ИнгредиентаLabel = new System.Windows.Forms.Label();
            кол_воLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииBindingNavigator)).BeginInit();
            this.состав_ПродукцииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ПекарняDataSet
            // 
            this.бД_ПекарняDataSet.DataSetName = "БД_ПекарняDataSet";
            this.бД_ПекарняDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // состав_ПродукцииBindingSource
            // 
            this.состав_ПродукцииBindingSource.DataMember = "Состав_Продукции";
            this.состав_ПродукцииBindingSource.DataSource = this.бД_ПекарняDataSet;
            // 
            // состав_ПродукцииTableAdapter
            // 
            this.состав_ПродукцииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпечка_в_договоре_Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_договореTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.Выпечка_Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.ВыпечкаTableAdapter = null;
            this.tableAdapterManager.Договор_1TableAdapter = null;
            this.tableAdapterManager.Договор_2TableAdapter = null;
            this.tableAdapterManager.ЗаказчикTableAdapter = null;
            this.tableAdapterManager.Ингредиенты_в_договореTableAdapter = null;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.Квитанция_1TableAdapter = null;
            this.tableAdapterManager.Квитанция_2TableAdapter = null;
            this.tableAdapterManager.План_продажTableAdapter = null;
            this.tableAdapterManager.План_производстваTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Состав_ПродукцииTableAdapter = this.состав_ПродукцииTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Строка_чекаTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // состав_ПродукцииBindingNavigator
            // 
            this.состав_ПродукцииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.состав_ПродукцииBindingNavigator.BindingSource = this.состав_ПродукцииBindingSource;
            this.состав_ПродукцииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.состав_ПродукцииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.состав_ПродукцииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.состав_ПродукцииBindingNavigatorSaveItem});
            this.состав_ПродукцииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.состав_ПродукцииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.состав_ПродукцииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.состав_ПродукцииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.состав_ПродукцииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.состав_ПродукцииBindingNavigator.Name = "состав_ПродукцииBindingNavigator";
            this.состав_ПродукцииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.состав_ПродукцииBindingNavigator.Size = new System.Drawing.Size(831, 25);
            this.состав_ПродукцииBindingNavigator.TabIndex = 0;
            this.состав_ПродукцииBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // состав_ПродукцииDataGridView
            // 
            this.состав_ПродукцииDataGridView.AutoGenerateColumns = false;
            this.состав_ПродукцииDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.состав_ПродукцииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.состав_ПродукцииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.состав_ПродукцииDataGridView.DataSource = this.состав_ПродукцииBindingSource;
            this.состав_ПродукцииDataGridView.Location = new System.Drawing.Point(332, 28);
            this.состав_ПродукцииDataGridView.Name = "состав_ПродукцииDataGridView";
            this.состав_ПродукцииDataGridView.Size = new System.Drawing.Size(479, 365);
            this.состав_ПродукцииDataGridView.TabIndex = 1;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // состав_ПродукцииBindingNavigatorSaveItem
            // 
            this.состав_ПродукцииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.состав_ПродукцииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("состав_ПродукцииBindingNavigatorSaveItem.Image")));
            this.состав_ПродукцииBindingNavigatorSaveItem.Name = "состав_ПродукцииBindingNavigatorSaveItem";
            this.состав_ПродукцииBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.состав_ПродукцииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.состав_ПродукцииBindingNavigatorSaveItem.Click += new System.EventHandler(this.состав_ПродукцииBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_Состава";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_Состава";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ИД_Ингредиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД_Ингредиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Кол_во";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол_во";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // иД_СоставаLabel
            // 
            иД_СоставаLabel.AutoSize = true;
            иД_СоставаLabel.Location = new System.Drawing.Point(25, 63);
            иД_СоставаLabel.Name = "иД_СоставаLabel";
            иД_СоставаLabel.Size = new System.Drawing.Size(98, 18);
            иД_СоставаLabel.TabIndex = 2;
            иД_СоставаLabel.Text = "ИД Состава:";
            // 
            // иД_СоставаTextBox
            // 
            this.иД_СоставаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.состав_ПродукцииBindingSource, "ИД_Состава", true));
            this.иД_СоставаTextBox.Location = new System.Drawing.Point(157, 63);
            this.иД_СоставаTextBox.Name = "иД_СоставаTextBox";
            this.иД_СоставаTextBox.Size = new System.Drawing.Size(121, 24);
            this.иД_СоставаTextBox.TabIndex = 3;
            // 
            // иД_ВыпечкиLabel
            // 
            иД_ВыпечкиLabel.AutoSize = true;
            иД_ВыпечкиLabel.Location = new System.Drawing.Point(23, 121);
            иД_ВыпечкиLabel.Name = "иД_ВыпечкиLabel";
            иД_ВыпечкиLabel.Size = new System.Drawing.Size(100, 18);
            иД_ВыпечкиLabel.TabIndex = 4;
            иД_ВыпечкиLabel.Text = "ИД Выпечки:";
            // 
            // иД_ВыпечкиTextBox
            // 
            this.иД_ВыпечкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.состав_ПродукцииBindingSource, "ИД_Выпечки", true));
            this.иД_ВыпечкиTextBox.Location = new System.Drawing.Point(157, 118);
            this.иД_ВыпечкиTextBox.Name = "иД_ВыпечкиTextBox";
            this.иД_ВыпечкиTextBox.Size = new System.Drawing.Size(121, 24);
            this.иД_ВыпечкиTextBox.TabIndex = 5;
            // 
            // иД_ИнгредиентаLabel
            // 
            иД_ИнгредиентаLabel.AutoSize = true;
            иД_ИнгредиентаLabel.Location = new System.Drawing.Point(23, 179);
            иД_ИнгредиентаLabel.Name = "иД_ИнгредиентаLabel";
            иД_ИнгредиентаLabel.Size = new System.Drawing.Size(128, 18);
            иД_ИнгредиентаLabel.TabIndex = 6;
            иД_ИнгредиентаLabel.Text = "ИД Ингредиента:";
            // 
            // иД_ИнгредиентаTextBox
            // 
            this.иД_ИнгредиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.состав_ПродукцииBindingSource, "ИД_Ингредиента", true));
            this.иД_ИнгредиентаTextBox.Location = new System.Drawing.Point(157, 179);
            this.иД_ИнгредиентаTextBox.Name = "иД_ИнгредиентаTextBox";
            this.иД_ИнгредиентаTextBox.Size = new System.Drawing.Size(121, 24);
            this.иД_ИнгредиентаTextBox.TabIndex = 7;
            // 
            // кол_воLabel
            // 
            кол_воLabel.AutoSize = true;
            кол_воLabel.Location = new System.Drawing.Point(23, 231);
            кол_воLabel.Name = "кол_воLabel";
            кол_воLabel.Size = new System.Drawing.Size(61, 18);
            кол_воLabel.TabIndex = 8;
            кол_воLabel.Text = "Кол во:";
            // 
            // кол_воTextBox
            // 
            this.кол_воTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.состав_ПродукцииBindingSource, "Кол_во", true));
            this.кол_воTextBox.Location = new System.Drawing.Point(157, 231);
            this.кол_воTextBox.Name = "кол_воTextBox";
            this.кол_воTextBox.Size = new System.Drawing.Size(121, 24);
            this.кол_воTextBox.TabIndex = 9;
            // 
            // btnObnovit4
            // 
            this.btnObnovit4.Location = new System.Drawing.Point(79, 296);
            this.btnObnovit4.Name = "btnObnovit4";
            this.btnObnovit4.Size = new System.Drawing.Size(121, 30);
            this.btnObnovit4.TabIndex = 11;
            this.btnObnovit4.Text = "Обновить";
            this.btnObnovit4.UseVisualStyleBackColor = true;
            this.btnObnovit4.Click += new System.EventHandler(this.btnObnovit4_Click);
            // 
            // SostProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(831, 413);
            this.Controls.Add(this.btnObnovit4);
            this.Controls.Add(кол_воLabel);
            this.Controls.Add(this.кол_воTextBox);
            this.Controls.Add(иД_ИнгредиентаLabel);
            this.Controls.Add(this.иД_ИнгредиентаTextBox);
            this.Controls.Add(иД_ВыпечкиLabel);
            this.Controls.Add(this.иД_ВыпечкиTextBox);
            this.Controls.Add(иД_СоставаLabel);
            this.Controls.Add(this.иД_СоставаTextBox);
            this.Controls.Add(this.состав_ПродукцииDataGridView);
            this.Controls.Add(this.состав_ПродукцииBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SostProd";
            this.Text = "Состав продукции";
            this.Load += new System.EventHandler(this.SostProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииBindingNavigator)).EndInit();
            this.состав_ПродукцииBindingNavigator.ResumeLayout(false);
            this.состав_ПродукцииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.состав_ПродукцииDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_ПекарняDataSet бД_ПекарняDataSet;
        private System.Windows.Forms.BindingSource состав_ПродукцииBindingSource;
        private БД_ПекарняDataSetTableAdapters.Состав_ПродукцииTableAdapter состав_ПродукцииTableAdapter;
        private БД_ПекарняDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator состав_ПродукцииBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton состав_ПродукцииBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView состав_ПродукцииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox иД_СоставаTextBox;
        private System.Windows.Forms.TextBox иД_ВыпечкиTextBox;
        private System.Windows.Forms.TextBox иД_ИнгредиентаTextBox;
        private System.Windows.Forms.TextBox кол_воTextBox;
        private System.Windows.Forms.Button btnObnovit4;
    }
}