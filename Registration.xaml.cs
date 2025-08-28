namespace MauiApp3;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private void RegionPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedIndex = RegionPicker.SelectedIndex;

        if (selectedIndex == -1)
            return;

        List<string> provinces = new();

        switch (selectedIndex)
        {
            case 0: // Ilocos Region (Region I)
                provinces = new() { "Ilocos Norte", "Ilocos Sur", "La Union", "Pangasinan" };
                break;

            case 1: // Cagayan Valley (Region II)
                provinces = new() { "Batanes", "Cagayan", "Isabela", "Nueva Vizcaya", "Quirino" };
                break;

            case 2: // Central Luzon (Region III)
                provinces = new() { "Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Pampanga", "Tarlac", "Zambales" };
                break;

            case 3: // CALABARZON (Region IV-A)
                provinces = new() { "Cavite", "Laguna", "Batangas", "Rizal", "Quezon" };
                break;

            case 4: // MIMAROPA (Region IV-B)
                provinces = new() { "Occidental Mindoro", "Oriental Mindoro", "Marinduque", "Romblon", "Palawan" };
                break;

            case 5: // Bicol Region (Region V)
                provinces = new() { "Albay", "Camarines Norte", "Camarines Sur", "Catanduanes", "Masbate", "Sorsogon" };
                break;

            case 6: // Western Visayas (Region VI)
                provinces = new() { "Aklan", "Antique", "Capiz", "Guimaras", "Iloilo", "Negros Occidental" };
                break;

            case 7: // Central Visayas (Region VII)
                provinces = new() { "Bohol", "Cebu", "Negros Oriental", "Siquijor" };
                break;

            case 8: // Eastern Visayas (Region VIII)
                provinces = new() { "Biliran", "Eastern Samar", "Leyte", "Northern Samar", "Samar", "Southern Leyte" };
                break;

            case 9: // Zamboanga Peninsula (Region IX)
                provinces = new() { "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay" };
                break;

            case 10: // Northern Mindanao (Region X)
                provinces = new() { "Bukidnon", "Camiguin", "Lanao del Norte", "Misamis Occidental", "Misamis Oriental" };
                break;

            case 11: // Davao Region (Region XI)
                provinces = new() { "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental" };
                break;

            case 12: // SOCCSKSARGEN (Region XII)
                provinces = new() { "Cotabato", "Sarangani", "South Cotabato", "Sultan Kudarat" };
                break;

            case 13: // Caraga (Region XIII)
                provinces = new() { "Agusan del Norte", "Agusan del Sur", "Dinagat Islands", "Surigao del Norte", "Surigao del Sur" };
                break;

            case 14: // BARMM
                provinces = new() { "Basilan", "Lanao del Sur", "Maguindanao del Norte", "Maguindanao del Sur", "Sulu", "Tawi-Tawi" };
                break;

            case 15: // CAR
                provinces = new() { "Abra", "Apayao", "Benguet", "Ifugao", "Kalinga", "Mountain Province" };
                break;

            case 16: // NCR
                provinces = new() { "Metro Manila" }; // technically not provinces, but cities
                break;
        }

        ProvincePicker.ItemsSource = provinces;
    }
}

