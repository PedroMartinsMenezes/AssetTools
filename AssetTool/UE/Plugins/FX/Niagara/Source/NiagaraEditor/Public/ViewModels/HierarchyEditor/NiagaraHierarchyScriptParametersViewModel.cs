namespace AssetTool
{
    [JsonAsset("NiagaraHierarchyScriptParameterRefreshContext")]
    public class UNiagaraHierarchyScriptParameterRefreshContext : UNiagaraHierarchyDataRefreshContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptParameter")]
    public class UNiagaraHierarchyScriptParameter : UNiagaraHierarchyItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptCategory")]
    public class UNiagaraHierarchyScriptCategory : UNiagaraHierarchyCategory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptParametersViewModel")]
    public class UNiagaraHierarchyScriptParametersViewModel : UNiagaraHierarchyViewModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}