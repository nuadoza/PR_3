using System.Windows.Forms;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.RowCount;
            int colCount = dataGridView1.ColumnCount;
            int[,] matrix = new int[rowCount, colCount];
            try
            {
                // ��������� ������� ������� �� DataGridView
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }
                // ��������� ���������� ������������� ���������
                int negativeCount = MatrixHelper<int>.CountNegativeElements(matrix);
                lblResult.Text = $"���������� ������������� ���������: {negativeCount}";
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� ������������� �������� � �������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRows.Clear();
            txtCols.Clear();
            dataGridView1.Rows.Clear();
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}




