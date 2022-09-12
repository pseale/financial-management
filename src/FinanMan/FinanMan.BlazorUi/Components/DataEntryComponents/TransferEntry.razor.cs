using FinanMan.Shared.DataEntryModels;
using FinanMan.Shared.LookupModels;
using FinanMan.Shared.StateInterfaces;
using Microsoft.AspNetCore.Components;

namespace FinanMan.BlazorUi.Components.DataEntryComponents;

public partial class TransferEntry
{
    [Inject] private ILookupListState LookupListState { get; set; } = default!;

    private TransferEntryViewModel _newTransfer = new();
    private List<ILookupItemViewModel<int, AccountViewModel>>? _accounts;
    protected override async Task OnInitializedAsync()
    {
        await LookupListState.Initialize();
        await Task.Delay(2000);
        _accounts = LookupListState.GetLookupItems<int, AccountViewModel>().ToList();
    }
}