namespace Пекарня
{
    partial class ProdProd
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
            System.Windows.Forms.Label иД_ВыпечкиLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label кол_воLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdProd));
            this.бД_ПекарняDataSet = new Пекарня.БД_ПекарняDataSet();
            this.выпечка_в_магBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выпечка_в_магTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.Выпечка_в_магTableAdapter();
            this.tableAdapterManager = new Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager();
            this.выпечка_в_магBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выпечка_в_магDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иД_ВыпечкиTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кол_воTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.выпечка_в_магBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            иД_ВыпечкиLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            кол_воLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магBindingNavigator)).BeginInit();
            this.выпечка_в_магBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ПекарняDataSet
            // 
            this.бД_ПекарняDataSet.DataSetName = "БД_ПекарняDataSet";
            this.бД_ПекарняDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выпечка_в_магBindingSource
            // 
            this.выпечка_в_магBindingSource.DataMember = "Выпечка_в_маг";
            this.выпечка_в_магBindingSource.DataSource = this.бД_ПекарняDataSet;
            // 
            // выпечка_в_магTableAdapter
            // 
            this.выпечка_в_магTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпечка_в_договоре_Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_договореTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_магTableAdapter = this.выпечка_в_магTableAdapter;
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
            this.tableAdapterManager.Состав_ПродукцииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Строка_чекаTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // выпечка_в_магBindingNavigator
            // 
            this.выпечка_в_магBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выпечка_в_магBindingNavigator.BindingSource = this.выпечка_в_магBindingSource;
            this.выпечка_в_магBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выпечка_в_магBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выпечка_в_магBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выпечка_в_магBindingNavigatorSaveItem});
            this.выпечка_в_магBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выпечка_в_магBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выпечка_в_магBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выпечка_в_магBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выпечка_в_магBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выпечка_в_магBindingNavigator.Name = "выпечка_в_магBindingNavigator";
            this.выпечка_в_магBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выпечка_в_магBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.выпечка_в_магBindingNavigator.TabIndex = 0;
            this.выпечка_в_магBindingNavigator.Text = "bindingNavigator1";
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
            // выпечка_в_магDataGridView
            // 
            this.выпечка_в_магDataGridView.AutoGenerateColumns = false;
            this.выпечка_в_магDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.выпечка_в_магDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выпечка_в_магDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.выпечка_в_магDataGridView.DataSource = this.выпечка_в_магBindingSource;
            this.выпечка_в_магDataGridView.Location = new System.Drawing.Point(425, 28);
            this.выпечка_в_магDataGridView.Name = "выпечка_в_магDataGridView";
            this.выпечка_в_магDataGridView.Size = new System.Drawing.Size(395, 360);
            this.выпечка_в_магDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кол_во";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кол_во";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // иД_ВыпечкиLabel
            // 
            иД_ВыпечкиLabel.AutoSize = true;
            иД_ВыпечкиLabel.Location = new System.Drawing.Point(26, 47);
            иД_ВыпечкиLabel.Name = "иД_ВыпечкиLabel";
            иД_ВыпечкиLabel.Size = new System.Drawing.Size(100, 18);
            иД_ВыпечкиLabel.TabIndex = 2;
            иД_ВыпечкиLabel.Text = "ИД Выпечки:";
            // 
            // иД_ВыпечкиTextBox
            // 
            this.иД_ВыпечкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпечка_в_магBindingSource, "ИД_Выпечки", true));
            this.иД_ВыпечкиTextBox.Location = new System.Drawing.Point(132, 44);
            this.иД_ВыпечкиTextBox.Name = "иД_ВыпечкиTextBox";
            this.иД_ВыпечкиTextBox.Size = new System.Drawing.Size(128, 24);
            this.иД_ВыпечкиTextBox.TabIndex = 3;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(26, 101);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(47, 18);
            датаLabel.TabIndex = 4;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выпечка_в_магBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(132, 95);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.датаDateTimePicker.TabIndex = 5;
            // 
            // кол_воLabel
            // 
            кол_воLabel.AutoSize = true;
            кол_воLabel.Location = new System.Drawing.Point(23, 154);
            кол_воLabel.Name = "кол_воLabel";
            кол_воLabel.Size = new System.Drawing.Size(61, 18);
            кол_воLabel.TabIndex = 6;
            кол_воLabel.Text = "Кол во:";
            // 
            // кол_воTextBox
            // 
            this.кол_воTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпечка_в_магBindingSource, "Кол_во", true));
            this.кол_воTextBox.Location = new System.Drawing.Point(132, 148);
            this.кол_воTextBox.Name = "кол_воTextBox";
            this.кол_воTextBox.Size = new System.Drawing.Size(128, 24);
            this.кол_воTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // выпечка_в_магBindingNavigatorSaveItem
            // 
            this.выпечка_в_магBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выпечка_в_магBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выпечка_в_магBindingNavigatorSaveItem.Image")));
            this.выпечка_в_магBindingNavigatorSaveItem.Name = "выпечка_в_магBindingNavigatorSaveItem";
            this.выпечка_в_магBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.выпечка_в_магBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выпечка_в_магBindingNavigatorSaveItem.Click += new System.EventHandler(this.выпечка_в_магBindingNavigatorSaveItem_Click);
            // 
            // ProdProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(843, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(кол_воLabel);
            this.Controls.Add(this.кол_воTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(иД_ВыпечкиLabel);
            this.Controls.Add(this.иД_ВыпечкиTextBox);
            this.Controls.Add(this.выпечка_в_магDataGridView);
            this.Controls.Add(this.выпечка_в_магBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProdProd";
            this.Text = "Продукция для продажи";
            this.Load += new System.EventHandler(this.ProdProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магBindingNavigator)).EndInit();
            this.выпечка_в_магBindingNavigator.ResumeLayout(false);
            this.выпечка_в_магBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_магDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_ПекарняDataSet бД_ПекарняDataSet;
        private System.Windows.Forms.BindingSource выпечка_в_магBindingSource;
        private БД_ПекарняDataSetTableAdapters.Выпечка_в_магTableAdapter выпечка_в_магTableAdapter;
        private БД_ПекарняDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выпечка_в_магBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выпечка_в_магBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView выпечка_в_магDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox иД_ВыпечкиTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox кол_воTextBox;
        private System.Windows.Forms.Button button1;
    }
}