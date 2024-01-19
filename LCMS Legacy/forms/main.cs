using LCMS_Legacy.forms;

namespace LCMS_Legacy
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings form = new settings();
            form.ShowDialog();
        }
    }
}
