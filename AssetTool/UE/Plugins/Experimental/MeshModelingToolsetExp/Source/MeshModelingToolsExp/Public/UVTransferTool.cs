namespace AssetTool
{
    [JsonAsset("UVTransferToolBuilder")]
    public class UUVTransferToolBuilder : UMultiTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTransferToolProperties")]
    public class UUVTransferToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTransferTool")]
    public class UUVTransferTool : UMultiTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}