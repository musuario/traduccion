using System;

namespace TuAppMAUI.Views
{
    public partial class CustomKeyboard : ContentView
    {
        public event Action<string> KeyPressed;

        public CustomKeyboard()
        {
            InitializeComponent();
        }

        //crear una logica de igualdad de letra y emoji
        private async void OnKeyClicked(object sender, EventArgs e)
        {
            if (sender is ImageButton button)
            {
                string key = button.AutomationId switch
                {
                    "ButtonQ" => "Q",
                    "ButtonW" => "W",
                    "ButtonE" => "E",
                    "ButtonR" => "R",
                    "ButtonT" => "T",
                    "ButtonY" => "Y",
                    "ButtonU" => "U",
                    "ButtonI" => "I",
                    "ButtonO" => "O",
                    "ButtonP" => "P",
                    _ => string.Empty
                };

                if (!string.IsNullOrEmpty(key))
                {
                    // Verifica si el Parent es una Page y luego muestra la alerta
                    if (Parent is Page parentPage)
                    {
                        await parentPage.DisplayAlert("Tecla presionada", $"Letra: {key}", "OK");
                    }
                }
            }
        }





        private void OnEnterClicked(object sender, EventArgs e)
        {
            KeyPressed?.Invoke("Enter");
        }
    }
}
