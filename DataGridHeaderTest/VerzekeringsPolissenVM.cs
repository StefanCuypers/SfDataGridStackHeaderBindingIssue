using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DataGridHeaderTest;


public class VerzekeringsPolissenVM : ObservableCollection<VerzekeringsPolisVM>
{
    public VerzekeringsPolissenTotals Totals { get; } = new();

    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    {
        base.OnCollectionChanged(e);
        CalcTotalInsuranceCost();
    }

    private void CalcTotalInsuranceCost()
    {
        Totals.TotaalPremie = this.Sum(x => x.Premie) ?? 0m;
        Totals.TotaalTaks = this.Sum(x => x.Taksen) ?? 0m;
    }

}
