namespace AssetTool
{
    [JsonAsset("HierarchyDataRefreshContext")]
    public class UHierarchyDataRefreshContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchyElement")]
    public class UHierarchyElement : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchySection")]
    public class UHierarchySection : UHierarchyElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchyRoot")]
    public class UHierarchyRoot : UHierarchyElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchyItem")]
    public class UHierarchyItem : UHierarchyElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchyCategory")]
    public class UHierarchyCategory : UHierarchyElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HierarchyMenuContext")]
    public class UHierarchyMenuContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataHierarchyViewModelBase")]
    public class UDataHierarchyViewModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}