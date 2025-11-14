namespace AssetTool
{
    [JsonAsset("UVSelectToolBuilder")]
    public class UUVSelectToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVSelectTool")]
    public class UUVSelectTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}