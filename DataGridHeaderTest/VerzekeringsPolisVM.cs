using CommunityToolkit.Mvvm.ComponentModel;

namespace DataGridHeaderTest;

public partial class VerzekeringsPolisVM : ObservableObject
{
    public VerzekeringsPolisVM(string? polisNummer, decimal? premie, decimal? taksen)
    {
        PolisNummer = polisNummer;
        Premie = premie;
        Taksen = taksen;
    }

    [ObservableProperty]
    private string? _polisNummer;

    [ObservableProperty]
    private string? _muntDisp = "EUR";

    [ObservableProperty]
    private decimal? _premie;

    [ObservableProperty]
    private decimal? _taksen;

}
