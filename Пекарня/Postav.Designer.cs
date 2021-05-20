namespace Пекарня
{
    partial class Postav
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
            System.Windows.Forms.Label иД_КлиентаLabel;
            System.Windows.Forms.Label назв_ОргLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postav));
            this.бД_ПекарняDataSet = new Пекарня.БД_ПекарняDataSet();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager();
            this.поставщикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.поставщикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.поставщикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иД_КлиентаTextBox = new System.Windows.Forms.TextBox();
            this.назв_ОргTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.btnObnovit4 = new System.Windows.Forms.Button();
            иД_КлиентаLabel = new System.Windows.Forms.Label();
            назв_ОргLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).BeginInit();
            this.поставщикBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // иД_КлиентаLabel
            // 
            иД_КлиентаLabel.AutoSize = true;
            иД_КлиентаLabel.Location = new System.Drawing.Point(30, 47);
            иД_КлиентаLabel.Name = "иД_КлиентаLabel";
            иД_КлиентаLabel.Size = new System.Drawing.Size(97, 18);
            иД_КлиентаLabel.TabIndex = 2;
            иД_КлиентаLabel.Text = "ИД Клиента:";
            // 
            // назв_ОргLabel
            // 
            назв_ОргLabel.AutoSize = true;
            назв_ОргLabel.Location = new System.Drawing.Point(30, 96);
            назв_ОргLabel.Name = "назв_ОргLabel";
            назв_ОргLabel.Size = new System.Drawing.Size(77, 18);
            назв_ОргLabel.TabIndex = 4;
            назв_ОргLabel.Text = "Назв Орг:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(30, 142);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(54, 18);
            адресLabel.TabIndex = 6;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(472, 50);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(76, 18);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // бД_ПекарняDataSet
            // 
            this.бД_ПекарняDataSet.DataSetName = "БД_ПекарняDataSet";
            this.бД_ПекарняDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.бД_ПекарняDataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.Состав_ПродукцииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Строка_чекаTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // поставщикBindingNavigator
            // 
            this.поставщикBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщикBindingNavigator.BindingSource = this.поставщикBindingSource;
            this.поставщикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикBindingNavigatorSaveItem});
            this.поставщикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикBindingNavigator.Name = "поставщикBindingNavigator";
            this.поставщикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.поставщикBindingNavigator.TabIndex = 0;
            this.поставщикBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // поставщикBindingNavigatorSaveItem
            // 
            this.поставщикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикBindingNavigatorSaveItem.Image")));
            this.поставщикBindingNavigatorSaveItem.Name = "поставщикBindingNavigatorSaveItem";
            this.поставщикBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.поставщикBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщикBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикBindingNavigatorSaveItem_Click);
            // 
            // поставщикDataGridView
            // 
            this.поставщикDataGridView.AutoGenerateColumns = false;
            this.поставщикDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.поставщикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставщикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.поставщикDataGridView.DataSource = this.поставщикBindingSource;
            this.поставщикDataGridView.Location = new System.Drawing.Point(24, 189);
            this.поставщикDataGridView.Name = "поставщикDataGridView";
            this.поставщикDataGridView.Size = new System.Drawing.Size(786, 230);
            this.поставщикDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_Клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_Клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Назв_Орг";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назв_Орг";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 270;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 230;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // иД_КлиентаTextBox
            // 
            this.иД_КлиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "ИД_Клиента", true));
            this.иД_КлиентаTextBox.Location = new System.Drawing.Point(133, 44);
            this.иД_КлиентаTextBox.Name = "иД_КлиентаTextBox";
            this.иД_КлиентаTextBox.Size = new System.Drawing.Size(100, 24);
            this.иД_КлиентаTextBox.TabIndex = 3;
            // 
            // назв_ОргTextBox
            // 
            this.назв_ОргTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Назв_Орг", true));
            this.назв_ОргTextBox.Location = new System.Drawing.Point(133, 93);
            this.назв_ОргTextBox.Name = "назв_ОргTextBox";
            this.назв_ОргTextBox.Size = new System.Drawing.Size(306, 24);
            this.назв_ОргTextBox.TabIndex = 5;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(133, 136);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(306, 24);
            this.адресTextBox.TabIndex = 7;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(583, 47);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(170, 24);
            this.телефонTextBox.TabIndex = 9;
            // 
            // btnObnovit4
            // 
            this.btnObnovit4.Location = new System.Drawing.Point(583, 93);
            this.btnObnovit4.Name = "btnObnovit4";
            this.btnObnovit4.Size = new System.Drawing.Size(170, 36);
            this.btnObnovit4.TabIndex = 10;
            this.btnObnovit4.Text = "Обновить";
            this.btnObnovit4.UseVisualStyleBackColor = true;
            this.btnObnovit4.Click += new System.EventHandler(this.btnObnovit4_Click);
            // 
            // Postav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(834, 439);
            this.Controls.Add(this.btnObnovit4);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(назв_ОргLabel);
            this.Controls.Add(this.назв_ОргTextBox);
            this.Controls.Add(иД_КлиентаLabel);
            this.Controls.Add(this.иД_КлиентаTextBox);
            this.Controls.Add(this.поставщикDataGridView);
            this.Controls.Add(this.поставщикBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Postav";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Postav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).EndInit();
            this.поставщикBindingNavigator.ResumeLayout(false);
            this.поставщикBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_ПекарняDataSet бД_ПекарняDataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private БД_ПекарняDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private БД_ПекарняDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщикBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView поставщикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox иД_КлиентаTextBox;
        private System.Windows.Forms.TextBox назв_ОргTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.Button btnObnovit4;
    }
}