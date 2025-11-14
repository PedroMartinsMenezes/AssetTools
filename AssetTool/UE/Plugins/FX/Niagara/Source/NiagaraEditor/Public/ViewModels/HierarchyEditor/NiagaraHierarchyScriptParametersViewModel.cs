namespace AssetTool
{
    [JsonAsset("NiagaraHierarchyScriptParameterRefreshContext")]
    public class UNiagaraHierarchyScriptParameterRefreshContext : UNiagaraHierarchyDataRefreshContext
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptParameter")]
    public class UNiagaraHierarchyScriptParameter : UNiagaraHierarchyItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptCategory")]
    public class UNiagaraHierarchyScriptCategory : UNiagaraHierarchyCategory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyScriptParametersViewModel")]
    public class UNiagaraHierarchyScriptParametersViewModel : UNiagaraHierarchyViewModelBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}