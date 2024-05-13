namespace Semana6Project.Views;

using Semana6Project.Services;
using System.Diagnostics;
using System.Text.Json;
using myRegions = Semana6Project.Models.Region;

public partial class RegionsPage : ContentPage
{
	public RegionsPage()
	{
		InitializeComponent();
	}
    private async Task LoadRegions()
    {
        try
        {
            var apiService = new ApiService();
            var response = await apiService.GetRegionsAsync();
            Debug.WriteLine($"Respuesta del endpoint: {response}");
            var regions = JsonSerializer.Deserialize<List<myRegions>>(response);
            this.BindingContext = new RegionsViewModel(regions);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error al cargar las regiones: {ex.Message}");
        }
    }
    public class RegionsViewModel
    {
        public List<myRegions> Regions { get; set; }

        public RegionsViewModel(List<myRegions> regions)
        {
            Regions = regions;
        }
    }

}