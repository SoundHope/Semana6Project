using Microsoft.Maui.Controls;
using Semana6Project.Views;

namespace Semana6Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegionsPage();
        }
    }
}