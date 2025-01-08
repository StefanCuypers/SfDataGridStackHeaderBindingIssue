using CommunityToolkit.Mvvm.ComponentModel;

namespace DataGridHeaderTest;

public partial class MachineGegevensInfoVM : ObservableObject
{
    [ObservableProperty]
    private VerzekeringsPolissenVM _verzekeringsPolissen = [];
}
