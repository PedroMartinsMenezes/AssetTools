namespace AssetTool
{
    [JsonAsset("PCGNumberOfElementsBaseSettings")]
    public class UPCGNumberOfElementsBaseSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNumberOfPointsSettings")]
    public class UPCGNumberOfPointsSettings : UPCGNumberOfElementsBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNumberOfEntriesSettings")]
    public class UPCGNumberOfEntriesSettings : UPCGNumberOfElementsBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}