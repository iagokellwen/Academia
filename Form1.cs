namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void lb_acesso_Click(object sender, EventArgs e)
        {

        }
    }
}