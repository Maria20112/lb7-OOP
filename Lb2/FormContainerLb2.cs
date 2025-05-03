namespace Lb2
{
    public partial class FormContainerLb2 : Form
    {
        /// <summary>
        /// ������ ������ ����������, ������������ �������������� ����� ������� � ��������������
        /// </summary>
        Controller controller = new Controller();
        
        /// <summary>
        /// ���������� �������, ������� ������ ���� �����
        /// </summary>
        void changeTable() => showAllButton_Click(null, null);
        public FormContainerLb2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������� ������ ���� ����� � �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllButton_Click(object sender, EventArgs e)
        {
            Array all = controller.getPeople().getAll().ToArray();
            showTable.Rows.Clear();
            showTable.Refresh();
            int count = 0;
            foreach (Person curr in all)
            {
                showTable.Rows.Add();
                showTable.Rows[count].Cells[0].Value = count + 1;
                showTable.Rows[count].Cells[1].Value = curr.name;
                showTable.Rows[count].Cells[2].Value = curr.surname;
                showTable.Rows[count].Cells[3].Value = curr.Gender;
                showTable.Rows[count].Cells[4].Value = curr.Year_of_birth;
                showTable.Rows[count].Cells[5].Value = curr.City;
                showTable.Rows[count].Cells[6].Value = curr.Country;
                showTable.Rows[count].Cells[7].Value = curr.Height;
                count++;
            }
        }

        /// <summary>
        /// �������, ������������� ��� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// �������, ����������� ����� ������ Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                create_err.Text = "";
                controller.getPeople().NotifyAdd += changeTable;
                controller.Add(name.Text, surname.Text, (man.Checked) ? "�������" : "�������",
                    year_of_birth.Text, city.Text, country.Text, height.Text);
                create_err.Text = "������!";

                name.Text = "";
                surname.Text = "";
                year_of_birth.Text = "2000";
                city.Text = "";
                country.Text = "";
                height.Text = "";
            }
            catch (MyOverflowException ex)
            {
                Win32.MessageBox(0, ex.Message + "\n" + ex.TimeOfExeption.ToString(), "�������������", 0);
            }
            catch (PersonArgumentExeption ex)
            {
                create_err.Text = ex.Message + "\n" + ex.TimeOfExeption.ToString();
            }
        }

        /// <summary>
        /// ������� ��� �������� ������� �� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.getPeople().NotifyRemove += changeTable;
            controller.Delete((int)number.Value);
        }
        
    }
}
