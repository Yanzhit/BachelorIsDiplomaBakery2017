namespace Пекарня
{
    partial class fmain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.бД_ПекарняDataSet = new Пекарня.БД_ПекарняDataSet();
            this.выпечкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выпечкаTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.ВыпечкаTableAdapter();
            this.tableAdapterManager = new Пекарня.БД_ПекарняDataSetTableAdapters.TableAdapterManager();
            this.выпечка_в_договореTableAdapter = new Пекарня.БД_ПекарняDataSetTableAdapters.Выпечка_в_договореTableAdapter();
            this.btnGotProd = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnCotrud = new System.Windows.Forms.Button();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.btnPostav = new System.Windows.Forms.Button();
            this.btnOtch = new System.Windows.Forms.Button();
            this.btnSir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.выпечка_в_договореBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_договореBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
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
            this.tableAdapterManager.Выпечка_в_договореTableAdapter = this.выпечка_в_договореTableAdapter;
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
            // выпечка_в_договореTableAdapter
            // 
            this.выпечка_в_договореTableAdapter.ClearBeforeFill = true;
            // 
            // btnGotProd
            // 
            this.btnGotProd.BackColor = System.Drawing.SystemColors.Info;
            this.btnGotProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGotProd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGotProd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGotProd.Location = new System.Drawing.Point(65, 44);
            this.btnGotProd.Margin = new System.Windows.Forms.Padding(6);
            this.btnGotProd.Name = "btnGotProd";
            this.btnGotProd.Size = new System.Drawing.Size(224, 58);
            this.btnGotProd.TabIndex = 2;
            this.btnGotProd.Text = "Готовая продукция";
            this.btnGotProd.UseVisualStyleBackColor = false;
            this.btnGotProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.SystemColors.Info;
            this.btnDoc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoc.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDoc.Location = new System.Drawing.Point(358, 363);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(6);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(224, 57);
            this.btnDoc.TabIndex = 4;
            this.btnDoc.Text = "Документы";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCotrud
            // 
            this.btnCotrud.BackColor = System.Drawing.SystemColors.Info;
            this.btnCotrud.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCotrud.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCotrud.Location = new System.Drawing.Point(358, 44);
            this.btnCotrud.Margin = new System.Windows.Forms.Padding(6);
            this.btnCotrud.Name = "btnCotrud";
            this.btnCotrud.Size = new System.Drawing.Size(224, 58);
            this.btnCotrud.TabIndex = 5;
            this.btnCotrud.Text = "Сотрудники";
            this.btnCotrud.UseVisualStyleBackColor = false;
            this.btnCotrud.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnZakaz
            // 
            this.btnZakaz.BackColor = System.Drawing.SystemColors.Info;
            this.btnZakaz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZakaz.ForeColor = System.Drawing.Color.DarkRed;
            this.btnZakaz.Location = new System.Drawing.Point(358, 114);
            this.btnZakaz.Margin = new System.Windows.Forms.Padding(6);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(224, 58);
            this.btnZakaz.TabIndex = 6;
            this.btnZakaz.Text = "Заказчики";
            this.btnZakaz.UseVisualStyleBackColor = false;
            this.btnZakaz.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPostav
            // 
            this.btnPostav.BackColor = System.Drawing.SystemColors.Info;
            this.btnPostav.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPostav.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPostav.Location = new System.Drawing.Point(358, 184);
            this.btnPostav.Margin = new System.Windows.Forms.Padding(6);
            this.btnPostav.Name = "btnPostav";
            this.btnPostav.Size = new System.Drawing.Size(224, 58);
            this.btnPostav.TabIndex = 7;
            this.btnPostav.Text = "Поставщики";
            this.btnPostav.UseVisualStyleBackColor = false;
            this.btnPostav.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnOtch
            // 
            this.btnOtch.BackColor = System.Drawing.SystemColors.Info;
            this.btnOtch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOtch.Location = new System.Drawing.Point(65, 363);
            this.btnOtch.Margin = new System.Windows.Forms.Padding(6);
            this.btnOtch.Name = "btnOtch";
            this.btnOtch.Size = new System.Drawing.Size(224, 57);
            this.btnOtch.TabIndex = 8;
            this.btnOtch.Text = "Отчеты";
            this.btnOtch.UseVisualStyleBackColor = false;
            this.btnOtch.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSir
            // 
            this.btnSir.BackColor = System.Drawing.SystemColors.Info;
            this.btnSir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSir.Location = new System.Drawing.Point(358, 256);
            this.btnSir.Name = "btnSir";
            this.btnSir.Size = new System.Drawing.Size(226, 58);
            this.btnSir.TabIndex = 9;
            this.btnSir.Text = "Сырье";
            this.btnSir.UseVisualStyleBackColor = false;
            this.btnSir.Click += new System.EventHandler(this.btnSir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(67, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Состав продукции";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(67, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Продукция для поставки";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(65, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 58);
            this.button3.TabIndex = 12;
            this.button3.Text = "Продукция для продажи";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // выпечка_в_договореBindingSource
            // 
            this.выпечка_в_договореBindingSource.DataMember = "Выпечка_в_договоре_вк";
            this.выпечка_в_договореBindingSource.DataSource = this.выпечкаBindingSource;
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSir);
            this.Controls.Add(this.btnOtch);
            this.Controls.Add(this.btnPostav);
            this.Controls.Add(this.btnZakaz);
            this.Controls.Add(this.btnCotrud);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGotProd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmain";
            this.Text = "Пекарня";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ПекарняDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпечка_в_договореBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private БД_ПекарняDataSet бД_ПекарняDataSet;
        private System.Windows.Forms.BindingSource выпечкаBindingSource;
        private БД_ПекарняDataSetTableAdapters.ВыпечкаTableAdapter выпечкаTableAdapter;
        private БД_ПекарняDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private БД_ПекарняDataSetTableAdapters.Выпечка_в_договореTableAdapter выпечка_в_договореTableAdapter;
        private System.Windows.Forms.BindingSource выпечка_в_договореBindingSource;
        private System.Windows.Forms.Button btnGotProd;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnCotrud;
        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.Button btnPostav;
        private System.Windows.Forms.Button btnOtch;
        private System.Windows.Forms.Button btnSir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

