namespace AssetTool
{
    [JsonAsset("PCGNumberOfElementsBaseSettings")]
    public class UPCGNumberOfElementsBaseSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNumberOfPointsSettings")]
    public class UPCGNumberOfPointsSettings : UPCGNumberOfElementsBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNumberOfEntriesSettings")]
    public class UPCGNumberOfEntriesSettings : UPCGNumberOfElementsBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}