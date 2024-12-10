using System.Windows.Forms;

namespace DisenyQuiz;

public partial class DisneyQuiz : Form
{
    public DisneyQuiz()
    {
        InitializeComponent();
    }
    private void btnGame_Click(object sender, EventArgs e)
    {
        DisneyQuizGame frm = new();
        frm.Show();
        this.Hide();
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        MessageBox.Show("V�rlak vissza!", "Viszl�t", MessageBoxButtons.OK);
        this.Close();
    }
}
