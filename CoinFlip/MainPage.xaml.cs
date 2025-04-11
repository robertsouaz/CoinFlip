namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        // Assume que você tenha uma imagem chamada "cara.jpg" e "coroa.jpg" na pasta de recursos do seu projeto
        // private Image MoedaImagem;

        public MainPage()
        {
            InitializeComponent();
        }
        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int sorteio = random.Next(2);
            //Animação();
            if (sorteio == 0)
            {
                MoedaImagem.Source = "cara.jpg";
            }
            else
            {
                MoedaImagem.Source = "coroa.jpg";
            }

            if (SelecaoPiker.SelectedIndex == sorteio)
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Tente novamente", "Você perdeu!", "Ok");
            }
        }
    }

}
