namespace Lb2
{
    partial class FormContainerLb2
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
            create_err = new Label();
            height = new TextBox();
            country = new TextBox();
            city = new TextBox();
            year_of_birth = new NumericUpDown();
            surname = new TextBox();
            name = new TextBox();
            addButton = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            woman = new RadioButton();
            man = new RadioButton();
            panel2 = new Panel();
            label1 = new Label();
            label12 = new Label();
            number = new NumericUpDown();
            label3 = new Label();
            panel3 = new Panel();
            data = new Label();
            deleteButton = new Button();
            groupBox2 = new GroupBox();
            showAllButton = new Button();
            showTable = new DataGridView();
            rowNumber = new DataGridViewTextBoxColumn();
            rowName = new DataGridViewTextBoxColumn();
            rowSurname = new DataGridViewTextBoxColumn();
            rowGender = new DataGridViewTextBoxColumn();
            rowYear = new DataGridViewTextBoxColumn();
            rowCity = new DataGridViewTextBoxColumn();
            rowCountry = new DataGridViewTextBoxColumn();
            rowHeight = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)year_of_birth).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)number).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showTable).BeginInit();
            SuspendLayout();
            // 
            // create_err
            // 
            create_err.AutoSize = true;
            create_err.Location = new Point(9, 383);
            create_err.Name = "create_err";
            create_err.Size = new Size(0, 20);
            create_err.TabIndex = 59;
            // 
            // height
            // 
            height.Location = new Point(88, 298);
            height.Name = "height";
            height.Size = new Size(125, 27);
            height.TabIndex = 58;
            // 
            // country
            // 
            country.Location = new Point(88, 265);
            country.Name = "country";
            country.Size = new Size(125, 27);
            country.TabIndex = 57;
            // 
            // city
            // 
            city.Location = new Point(88, 232);
            city.Name = "city";
            city.Size = new Size(125, 27);
            city.TabIndex = 56;
            // 
            // year_of_birth
            // 
            year_of_birth.Location = new Point(123, 199);
            year_of_birth.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            year_of_birth.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            year_of_birth.Name = "year_of_birth";
            year_of_birth.Size = new Size(150, 27);
            year_of_birth.TabIndex = 55;
            year_of_birth.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // surname
            // 
            surname.Location = new Point(88, 81);
            surname.Name = "surname";
            surname.Size = new Size(125, 27);
            surname.TabIndex = 52;
            // 
            // name
            // 
            name.Location = new Point(88, 48);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 51;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.Location = new Point(88, 331);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 48);
            addButton.TabIndex = 50;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 301);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 49;
            label11.Text = "Рост";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 268);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 48;
            label10.Text = "Страна";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 238);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 47;
            label9.Text = "Город";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 201);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 46;
            label8.Text = "Год рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 84);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 44;
            label6.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 51);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 43;
            label5.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(64, 12);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 42;
            label2.Text = "Добавление объекта";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(create_err);
            panel1.Controls.Add(height);
            panel1.Controls.Add(country);
            panel1.Controls.Add(city);
            panel1.Controls.Add(year_of_birth);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(name);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 438);
            panel1.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(woman);
            groupBox1.Controls.Add(man);
            groupBox1.Location = new Point(3, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 79);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(88, 44);
            woman.Name = "woman";
            woman.Size = new Size(90, 24);
            woman.TabIndex = 54;
            woman.Text = "женский";
            woman.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            man.AutoSize = true;
            man.Checked = true;
            man.Location = new Point(88, 14);
            man.Name = "man";
            man.Size = new Size(91, 24);
            man.TabIndex = 53;
            man.TabStop = true;
            man.Text = "мужской";
            man.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 91);
            panel2.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(562, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 60);
            label1.TabIndex = 62;
            label1.Text = "Лабораторная работа №7 \r\n23ВП1\r\nБояринова М.Г., Бычкова Н.Р.\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(83, 32);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 64;
            label12.Text = "Введите номер ";
            // 
            // number
            // 
            number.Location = new Point(70, 55);
            number.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            number.Name = "number";
            number.Size = new Size(150, 27);
            number.TabIndex = 63;
            number.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(76, 12);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 62;
            label3.Text = "Удаление объекта";
            // 
            // panel3
            // 
            panel3.Controls.Add(data);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(number);
            panel3.Location = new Point(12, 575);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 165);
            panel3.TabIndex = 65;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Location = new Point(28, 124);
            data.Name = "data";
            data.Size = new Size(0, 20);
            data.TabIndex = 67;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.Location = new Point(28, 88);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(235, 29);
            deleteButton.TabIndex = 66;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(showAllButton);
            groupBox2.Controls.Add(showTable);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(324, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1037, 451);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод всех элементов коллекции";
            // 
            // showAllButton
            // 
            showAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showAllButton.Location = new Point(17, 26);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(1003, 29);
            showAllButton.TabIndex = 1;
            showAllButton.Text = "Вывести все элементы";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // showTable
            // 
            showTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            showTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            showTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showTable.Columns.AddRange(new DataGridViewColumn[] { rowNumber, rowName, rowSurname, rowGender, rowYear, rowCity, rowCountry, rowHeight });
            showTable.Location = new Point(17, 61);
            showTable.Name = "showTable";
            showTable.RowHeadersWidth = 51;
            showTable.Size = new Size(1003, 377);
            showTable.TabIndex = 0;
            // 
            // rowNumber
            // 
            rowNumber.HeaderText = "№";
            rowNumber.MinimumWidth = 6;
            rowNumber.Name = "rowNumber";
            rowNumber.ReadOnly = true;
            rowNumber.Width = 56;
            // 
            // rowName
            // 
            rowName.HeaderText = "Имя";
            rowName.MinimumWidth = 6;
            rowName.Name = "rowName";
            rowName.ReadOnly = true;
            rowName.Width = 71;
            // 
            // rowSurname
            // 
            rowSurname.HeaderText = "Фамилия";
            rowSurname.MinimumWidth = 6;
            rowSurname.Name = "rowSurname";
            rowSurname.ReadOnly = true;
            rowSurname.Width = 107;
            // 
            // rowGender
            // 
            rowGender.HeaderText = "Пол";
            rowGender.MinimumWidth = 6;
            rowGender.Name = "rowGender";
            rowGender.ReadOnly = true;
            rowGender.Width = 67;
            // 
            // rowYear
            // 
            rowYear.HeaderText = "Год рожд.";
            rowYear.MinimumWidth = 6;
            rowYear.Name = "rowYear";
            rowYear.ReadOnly = true;
            rowYear.Width = 111;
            // 
            // rowCity
            // 
            rowCity.HeaderText = "Город";
            rowCity.MinimumWidth = 6;
            rowCity.Name = "rowCity";
            rowCity.ReadOnly = true;
            rowCity.Width = 81;
            // 
            // rowCountry
            // 
            rowCountry.HeaderText = "Страна";
            rowCountry.MinimumWidth = 6;
            rowCountry.Name = "rowCountry";
            rowCountry.ReadOnly = true;
            rowCountry.Width = 88;
            // 
            // rowHeight
            // 
            rowHeight.HeaderText = "Рост";
            rowHeight.MinimumWidth = 6;
            rowHeight.Name = "rowHeight";
            rowHeight.ReadOnly = true;
            rowHeight.Width = 70;
            // 
            // FormContainerLb2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 752);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(350, 799);
            Name = "FormContainerLb2";
            Text = "Lb7";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)year_of_birth).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)number).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)showTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label create_err;
        private TextBox height;
        private TextBox country;
        private TextBox city;
        private NumericUpDown year_of_birth;
        private TextBox surname;
        private TextBox name;
        private Button addButton;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton woman;
        private RadioButton man;
        private Panel panel2;
        private Label label1;
        private Label label12;
        private NumericUpDown number;
        private Label label3;
        private Panel panel3;
        private Label data;
        private Button deleteButton;
        private GroupBox groupBox2;
        private DataGridView showTable;
        private DataGridViewTextBoxColumn rowNumber;
        private DataGridViewTextBoxColumn rowName;
        private DataGridViewTextBoxColumn rowSurname;
        private DataGridViewTextBoxColumn rowGender;
        private DataGridViewTextBoxColumn rowYear;
        private DataGridViewTextBoxColumn rowCity;
        private DataGridViewTextBoxColumn rowCountry;
        private DataGridViewTextBoxColumn rowHeight;
        private Button showAllButton;
    }
}
