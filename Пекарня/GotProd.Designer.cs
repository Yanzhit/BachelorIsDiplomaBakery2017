namespace Пекарня
{
    partial class GotProd
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label цена__шт_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GotProd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.бД_ПекарняDataSet = new Пекарня.БД_ПекарняDataSet();
            this.выпечкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выпечкаTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.ВыпечкаTableAdapter();
            this.tableAdapterManager = new Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager();
            this.выпечкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.выпечкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.иД_ВыпечкиTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.цена__шт_TextBox = new System.Windows.Forms.TextBox();
            this.выпечкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObnovit = new System.Windows.Forms.Button();
            иД_ВыпечкиLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            цена__шт_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingNavigator)).BeginInit();
            this.выпечкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // иД_ВыпечкиLabel
            // 
            иД_ВыпечкиLabel.AutoSize = true;
            иД_ВыпечкиLabel.BackColor = System.Drawing.SystemColors.Menu;
            иД_ВыпечкиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            иД_ВыпечкиLabel.ForeColor = System.Drawing.Color.Maroon;
            иД_ВыпечкиLabel.Location = new System.Drawing.Point(29, 57);
            иД_ВыпечкиLabel.Name = "иД_ВыпечкиLabel";
            иД_ВыпечкиLabel.Size = new System.Drawing.Size(106, 20);
            иД_ВыпечкиLabel.TabIndex = 1;
            иД_ВыпечкиLabel.Text = "ИД Выпечки:";
            иД_ВыпечкиLabel.Click += new System.EventHandler(this.иД_ВыпечкиLabel_Click);
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.BackColor = System.Drawing.SystemColors.Menu;
            наименованиеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеLabel.ForeColor = System.Drawing.Color.Maroon;
            наименованиеLabel.Location = new System.Drawing.Point(29, 120);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(126, 20);
            наименованиеLabel.TabIndex = 3;
            наименованиеLabel.Text = "Наименование:";
            наименованиеLabel.Click += new System.EventHandler(this.наименованиеLabel_Click);
            // 
            // цена__шт_Label
            // 
            цена__шт_Label.AutoSize = true;
            цена__шт_Label.BackColor = System.Drawing.SystemColors.Menu;
            цена__шт_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            цена__шт_Label.ForeColor = System.Drawing.Color.Maroon;
            цена__шт_Label.Location = new System.Drawing.Point(29, 189);
            цена__шт_Label.Name = "цена__шт_Label";
            цена__шт_Label.Size = new System.Drawing.Size(88, 20);
            цена__шт_Label.TabIndex = 5;
            цена__шт_Label.Text = "Цена (шт):";
            цена__шт_Label.Click += new System.EventHandler(this.цена__шт_Label_Click);
            // 
            // бД_ПекарняDataSet
            // 
            this.бД_ПекарняDataSet.DataSetName = "БД_ПекарняDataSet";
            this.бД_ПекарняDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выпечкаBindingSource
            // 
            this.выпечкаBindingSource.DataMember = "Выпечка";
            this.выпечкаBindingSource.DataSource = this.бД_ПекарняDataSet;
            // 
            // выпечкаTableAdapter
            // 
            this.выпечкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпечка_в_договоре_Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_договореTableAdapter = null;
            this.tableAdapterManager.Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.Выпечка_Выпечка_в_магTableAdapter = null;
            this.tableAdapterManager.ВыпечкаTableAdapter = this.выпечкаTableAdapter;
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
            // выпечкаBindingNavigator
            // 
            this.выпечкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выпечкаBindingNavigator.BindingSource = this.выпечкаBindingSource;
            this.выпечкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выпечкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выпечкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выпечкаBindingNavigatorSaveItem});
            this.выпечкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выпечкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выпечкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выпечкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выпечкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выпечкаBindingNavigator.Name = "выпечкаBindingNavigator";
            this.выпечкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выпечкаBindingNavigator.Size = new System.Drawing.Size(826, 25);
            this.выпечкаBindingNavigator.TabIndex = 0;
            this.выпечкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // выпечкаBindingNavigatorSaveItem
            // 
            this.выпечкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выпечкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выпечкаBindingNavigatorSaveItem.Image")));
            this.выпечкаBindingNavigatorSaveItem.Name = "выпечкаBindingNavigatorSaveItem";
            this.выпечкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.выпечкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выпечкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.выпечкаBindingNavigatorSaveItem_Click);
            // 
            // иД_ВыпечкиTextBox
            // 
            this.иД_ВыпечкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпечкаBindingSource, "ИД_Выпечки", true));
            this.иД_ВыпечкиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.иД_ВыпечкиTextBox.Location = new System.Drawing.Point(161, 57);
            this.иД_ВыпечкиTextBox.Name = "иД_ВыпечкиTextBox";
            this.иД_ВыпечкиTextBox.Size = new System.Drawing.Size(97, 24);
            this.иД_ВыпечкиTextBox.TabIndex = 2;
            this.иД_ВыпечкиTextBox.TextChanged += new System.EventHandler(this.иД_ВыпечкиTextBox_TextChanged);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпечкаBindingSource, "Наименование", true));
            this.наименованиеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименованиеTextBox.Location = new System.Drawing.Point(161, 118);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(159, 24);
            this.наименованиеTextBox.TabIndex = 4;
            // 
            // цена__шт_TextBox
            // 
            this.цена__шт_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпечкаBindingSource, "Цена (шт)", true));
            this.цена__шт_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.цена__шт_TextBox.Location = new System.Drawing.Point(161, 187);
            this.цена__шт_TextBox.Name = "цена__шт_TextBox";
            this.цена__шт_TextBox.Size = new System.Drawing.Size(97, 24);
            this.цена__шт_TextBox.TabIndex = 6;
            this.цена__шт_TextBox.TextChanged += new System.EventHandler(this.цена__шт_TextBox_TextChanged);
            // 
            // выпечкаDataGridView
            // 
            this.выпечкаDataGridView.AutoGenerateColumns = false;
            this.выпечкаDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.выпечкаDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.выпечкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выпечкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.выпечкаDataGridView.DataSource = this.выпечкаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.выпечкаDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.выпечкаDataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.выпечкаDataGridView.Location = new System.Drawing.Point(337, 57);
            this.выпечкаDataGridView.Name = "выпечкаDataGridView";
            this.выпечкаDataGridView.RowHeadersWidth = 42;
            this.выпечкаDataGridView.Size = new System.Drawing.Size(465, 344);
            this.выпечкаDataGridView.TabIndex = 7;
            this.выпечкаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.выпечкаDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_Выпечки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена (шт)";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена (шт)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnObnovit
            // 
            this.btnObnovit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnObnovit.Location = new System.Drawing.Point(88, 272);
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.Size = new System.Drawing.Size(113, 29);
            this.btnObnovit.TabIndex = 8;
            this.btnObnovit.Text = "Обновить";
            this.btnObnovit.UseVisualStyleBackColor = true;
            this.btnObnovit.Click += new System.EventHandler(this.btnObnovit_Click);
            // 
            // GotProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(826, 426);
            this.Controls.Add(this.btnObnovit);
            this.Controls.Add(this.выпечкаDataGridView);
            this.Controls.Add(цена__шт_Label);
            this.Controls.Add(this.цена__шт_TextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(иД_ВыпечкиLabel);
            this.Controls.Add(this.иД_ВыпечкиTextBox);
            this.Controls.Add(this.выпечкаBindingNavigator);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "GotProd";
            this.Text = "Готовая продукция";
            this.Load += new System.EventHandler(this.GotProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingNavigator)).EndInit();
            this.выпечкаBindingNavigator.ResumeLayout(false);
            this.выпечкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_ПекарняDataSet бД_ПекарняDataSet;
        private System.Windows.Forms.BindingSource выпечкаBindingSource;
        private БД_ПекарняDataSetTableAdapters.ВыпечкаTableAdapter выпечкаTableAdapter;
        private БД_ПекарняDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выпечкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выпечкаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox иД_ВыпечкиTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox цена__шт_TextBox;
        private System.Windows.Forms.DataGridView выпечкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnObnovit;
    }
}