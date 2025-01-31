using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroCurso : MaterialForm
    {
        String cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroCurso()
        {
            InitializeComponent();
        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCurso.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodCurso.Text))
            {
                MessageBox.Show("Código do curso obrigatório!");
                txtCodCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Nome do curso obrigatório!");
                txtNomeCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxNivel.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxDuracao.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxDuracao.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxArea.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxArea.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbxPeriodo.Text))
            {
                MessageBox.Show("Nível do curso obrigatório!");
                cbxPeriodo.Focus();
                return false;
            }

            return true;
        }

        private void Salvar()
        {
            var line = $"{txtCodCurso.Text};" +
                $"{txtNomeCurso.Text};" +
                $"{cbxNivel.Text};" +
                $"{cbxDuracao.Text};" +
                $"{cbxArea.Text};" +
                $"{cbxPeriodo.Text};";

            if (!isAlteracao)
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] curso = File.ReadAllLines(cursosFileName);
                curso[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, curso);
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            lvCursos.Columns.Clear();
            lvCursos.Items.Clear();
            lvCursos.Columns.Add("Código");
            lvCursos.Columns.Add("Nome");
            lvCursos.Columns.Add("Nível");
            lvCursos.Columns.Add("Duração em semestres");
            lvCursos.Columns.Add("Área");
            lvCursos.Columns.Add("Período");

            string[] cursos = File.ReadAllLines(cursosFileName);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(";");
                lvCursos.Items.Add(new ListViewItem(campos));
            }
            lvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void Editar()
        {
            if (lvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = lvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = lvCursos.SelectedItems[0];
                txtCodCurso.Text = item.SubItems[0].Text;
                txtNomeCurso.Text = item.SubItems[1].Text;
                cbxNivel.Text = item.SubItems[2].Text;
                cbxDuracao.Text = item.SubItems[3].Text;
                cbxArea.Text = item.SubItems[4].Text;
                cbxPeriodo.Text = item.SubItems[5].Text;

                TabControlCurso.SelectedIndex = 0;
                txtCodCurso.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsultaCurso_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void lvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n" +
                                    "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCurso.SelectedIndex = 1;
            }
        }

        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCurso.SelectedIndex = 0;
            txtCodCurso.Focus();
        }

        private void Excluir()
        {
            List<string> cursos = File.ReadAllLines(cursosFileName).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFileName, cursos);
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            if (lvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o aluno selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = lvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

