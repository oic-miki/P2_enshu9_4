

namespace P2_enshu9_4
{
    public partial class FormDivision : Form
    {
        public FormDivision()
        {
            InitializeComponent();
        }

        private void buttonAllData_Click(object sender, EventArgs e)
        {
            //fncAllSelect();
        }

        private void FormDivision_Load(object sender, EventArgs e)
        {
            ////�f�[�^�O���b�h�r���[�̗�ݒ�
            ////�񐔂̎w��
            //dataGridViewDsp.ColumnCount = 4;
            ////0�Ԗځi���[�j�̗񕝂�ݒ�
            //dataGridViewDsp.Columns[0].Width = 70;
            ////0�Ԗځi���[�j�̍��ږ���ݒ�
            //dataGridViewDsp.Columns[0].HeaderText = "����ID";
            //dataGridViewDsp.Columns[1].Width = 130;
            //dataGridViewDsp.Columns[1].HeaderText = "������";
            //dataGridViewDsp.Columns[2].Width = 70;
            //dataGridViewDsp.Columns[2].HeaderText = "�\��";
            //dataGridViewDsp.Columns[3].Width = 250;
            //dataGridViewDsp.Columns[3].HeaderText = "���l";
            ////�S�f�[�^�\�����Ăяo��
            //fncAllSelect();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


        }
        private void fncAllSelect()
        {
            ////�S�f�[�^�̕\��
            //dataGridViewDsp.Rows.Clear();
            //var context = new DivisionContext();
            //foreach (var p in context.M_Divisions)
            //{
            //    dataGridViewDsp.Rows.Add(p.MDivisionId, p.DivisionName, p.DspFlg, p.Comments);
            //}
            //context.Dispose();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////�f�[�^�O���b�h�r���[����N���b�N���ꂽ�f�[�^���e�L�X�g�{�b�N�X��
            //textBoxDivisionID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            //textBoxDivisionName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            //checkBoxDispFLG.Checked = (bool)dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value;
            //textBoxComments.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {


        }

        private void buttonUpdata_Click(object sender, EventArgs e)
        {


        }

        private void buttonFormDivisionClose_Click(object sender, EventArgs e)
        {
            //// �����}�X�^�Ǘ���ʂ���邪�ǂ�����MessageBox�֕\��
            //DialogResult result = MessageBox.Show("�����}�X�^�̃E�B���h�E����Ă������ł����H",
            //    "�m�F", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (result == DialogResult.OK)
            //{
            //    // OK�̎��̏���
            //    this.Close();
            //}
            //else
            //{
            //    // �L�����Z���̎��̏���
            //}
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //textBoxDivisionID.Text = "";
            //textBoxDivisionName.Text = "";
            //checkBoxDispFLG.Checked = true;
            //textBoxComments.Text = "";
            //dataGridViewDsp.Rows.Clear();
        }
    }
}
