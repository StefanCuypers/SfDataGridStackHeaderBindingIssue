using CommunityToolkit.Mvvm.ComponentModel;

namespace DataGridHeaderTest;

public partial class VerzekeringsPolissenTotals : ObservableObject
{
    [ObservableProperty]
    private decimal _totaalPremie;

    [ObservableProperty]
    private decimal _totaalTaks;

    [ObservableProperty]
    private string? _muntDisp = "EUR";
}

