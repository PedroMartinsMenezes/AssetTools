namespace AssetTool
{
    [JsonAsset("UVTransferToolBuilder")]
    public class UUVTransferToolBuilder : UMultiTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTransferToolProperties")]
    public class UUVTransferToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTransferTool")]
    public class UUVTransferTool : UMultiTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}