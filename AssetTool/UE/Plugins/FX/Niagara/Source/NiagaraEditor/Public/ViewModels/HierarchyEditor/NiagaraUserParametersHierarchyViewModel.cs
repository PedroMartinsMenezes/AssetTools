namespace AssetTool
{
    [JsonAsset("NiagaraHierarchyUserParameterRefreshContext")]
    public class UNiagaraHierarchyUserParameterRefreshContext : UNiagaraHierarchyDataRefreshContext
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyUserParameter")]
    public class UNiagaraHierarchyUserParameter : UNiagaraHierarchyItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraUserParametersHierarchyViewModel")]
    public class UNiagaraUserParametersHierarchyViewModel : UNiagaraHierarchyViewModelBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}