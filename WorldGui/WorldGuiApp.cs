namespace WorldGui
{
    public partial class FormWorldGui : Form
    {
        public FormWorldGui()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // her starter vi � regne ut!!
            var strTallA = txtTallA.Text;
            var strTallB = txtTallB.Text;


            if (strTallA == string.Empty || strTallB == string.Empty)
            {
                MessageBox.Show("M� ha tall i tekstboksene");
                return;
            }

            // konvertere til tall !!
            if (!int.TryParse(strTallA, out int tallA))
            {
                MessageBox.Show("M� ha tall i tekstboks A");
                return;
            }

            if (!int.TryParse(strTallB, out int tallB))
            {
                MessageBox.Show("M� ha tall i tekstboks B");
                return;
            }

            // s� har vi tallA og tallB
            txtSum.Text = $"{tallA + tallB}";


        }
    }
}