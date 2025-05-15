namespace MecanicaForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private async void SplashForm_Load(object sender, EventArgs e)
        {

            await Task.Delay(500);

            for (int i = 0; i <= 100; i++)
            {
                progressBarInitialize.Value = i;
                loadingText.Text = $"Carregando: {i.ToString()}%";

                await Task.Delay(10);
                    
            }

            HomeForm homeForm = new HomeForm();
            homeForm.Show();

            this.Hide();
        }
    }
}
