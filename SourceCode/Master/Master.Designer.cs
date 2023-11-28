namespace BD5
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            System.Windows.Forms.Label фИОLabel1;
            System.Windows.Forms.Label специализацияLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.мастерскаяDataSet = new BD5.МастерскаяDataSet();
            this.мастерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерTableAdapter = new BD5.МастерскаяDataSetTableAdapters.МастерTableAdapter();
            this.tableAdapterManager = new BD5.МастерскаяDataSetTableAdapters.TableAdapterManager();
            this.мастерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.мастерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox1 = new System.Windows.Forms.TextBox();
            this.специализацияTextBox = new System.Windows.Forms.TextBox();
            фИОLabel1 = new System.Windows.Forms.Label();
            специализацияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingNavigator)).BeginInit();
            this.мастерBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(210, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблица \"Мастер\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Последняя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Следующая";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 45);
            this.button5.TabIndex = 14;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 45);
            this.button6.TabIndex = 15;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(480, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 45);
            this.button7.TabIndex = 16;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 403);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 45);
            this.button8.TabIndex = 17;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(480, 403);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 45);
            this.button9.TabIndex = 18;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мастерBindingSource
            // 
            this.мастерBindingSource.DataMember = "Мастер";
            this.мастерBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерTableAdapter
            // 
            this.мастерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD5.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГарантияTableAdapter = null;
            this.tableAdapterManager.Запчасти_НеисправностиTableAdapter = null;
            this.tableAdapterManager.ЗапчастиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.МастерTableAdapter = this.мастерTableAdapter;
            this.tableAdapterManager.НеисправностиTableAdapter = null;
            // 
            // мастерBindingNavigator
            // 
            this.мастерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.мастерBindingNavigator.BindingSource = this.мастерBindingSource;
            this.мастерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.мастерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.мастерBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.мастерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.мастерBindingNavigatorSaveItem});
            this.мастерBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.мастерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.мастерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.мастерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.мастерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.мастерBindingNavigator.Name = "мастерBindingNavigator";
            this.мастерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.мастерBindingNavigator.Size = new System.Drawing.Size(600, 33);
            this.мастерBindingNavigator.TabIndex = 22;
            this.мастерBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // мастерBindingNavigatorSaveItem
            // 
            this.мастерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.мастерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("мастерBindingNavigatorSaveItem.Image")));
            this.мастерBindingNavigatorSaveItem.Name = "мастерBindingNavigatorSaveItem";
            this.мастерBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.мастерBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.мастерBindingNavigatorSaveItem.Click += new System.EventHandler(this.мастерBindingNavigatorSaveItem_Click_1);
            // 
            // фИОLabel1
            // 
            фИОLabel1.AutoSize = true;
            фИОLabel1.Location = new System.Drawing.Point(69, 119);
            фИОLabel1.Name = "фИОLabel1";
            фИОLabel1.Size = new System.Drawing.Size(51, 20);
            фИОLabel1.TabIndex = 22;
            фИОLabel1.Text = "ФИО:";
            // 
            // фИОTextBox1
            // 
            this.фИОTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастерBindingSource, "ФИО", true));
            this.фИОTextBox1.Location = new System.Drawing.Point(216, 113);
            this.фИОTextBox1.Name = "фИОTextBox1";
            this.фИОTextBox1.Size = new System.Drawing.Size(231, 26);
            this.фИОTextBox1.TabIndex = 23;
            // 
            // специализацияLabel
            // 
            специализацияLabel.AutoSize = true;
            специализацияLabel.Location = new System.Drawing.Point(69, 165);
            специализацияLabel.Name = "специализацияLabel";
            специализацияLabel.Size = new System.Drawing.Size(132, 20);
            специализацияLabel.TabIndex = 23;
            специализацияLabel.Text = "Специализация:";
            // 
            // специализацияTextBox
            // 
            this.специализацияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастерBindingSource, "Специализация", true));
            this.специализацияTextBox.Location = new System.Drawing.Point(216, 162);
            this.специализацияTextBox.Name = "специализацияTextBox";
            this.специализацияTextBox.Size = new System.Drawing.Size(231, 26);
            this.специализацияTextBox.TabIndex = 24;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 468);
            this.Controls.Add(специализацияLabel);
            this.Controls.Add(this.специализацияTextBox);
            this.Controls.Add(фИОLabel1);
            this.Controls.Add(this.фИОTextBox1);
            this.Controls.Add(this.мастерBindingNavigator);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Master";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерBindingNavigator)).EndInit();
            this.мастерBindingNavigator.ResumeLayout(false);
            this.мастерBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource мастерBindingSource;
        private МастерскаяDataSetTableAdapters.МастерTableAdapter мастерTableAdapter;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator мастерBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton мастерBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox1;
        private System.Windows.Forms.TextBox специализацияTextBox;
    }
}