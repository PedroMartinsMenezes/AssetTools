namespace AssetTool
{
    [JsonAsset("NiagaraHierarchyDataRefreshContext")]
    public class UNiagaraHierarchyDataRefreshContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyItemBase")]
    public class UNiagaraHierarchyItemBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyRoot")]
    public class UNiagaraHierarchyRoot : UNiagaraHierarchyItemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyItem")]
    public class UNiagaraHierarchyItem : UNiagaraHierarchyItemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyCategory")]
    public class UNiagaraHierarchyCategory : UNiagaraHierarchyItemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchySection")]
    public class UNiagaraHierarchySection : UNiagaraHierarchyItemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyObjectProperty")]
    public class UNiagaraHierarchyObjectProperty : UNiagaraHierarchyItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyMenuContext")]
    public class UNiagaraHierarchyMenuContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraHierarchyViewModelBase")]
    public class UNiagaraHierarchyViewModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}