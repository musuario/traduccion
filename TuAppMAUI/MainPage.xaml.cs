using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TuAppMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEntryFocused(object sender, FocusEventArgs e)
        {
            // Ocultar el teclado predeterminado
            ((Entry)sender).Unfocus();
            // Mostrar el teclado personalizado
            CustomKeyboard.IsVisible = true;
        }

        private void OnKeyPressed(string key)
        {
            if (key == "Enter")
            {
                // Ocultar el teclado personalizado
                CustomKeyboard.IsVisible = false;
            }
            else
            {
                // Agregar la tecla presionada al Entry
                TextInput.Text += key;
            }
        }
    }
}
