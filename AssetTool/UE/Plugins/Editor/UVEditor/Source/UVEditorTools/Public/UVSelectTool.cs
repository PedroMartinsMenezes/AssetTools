namespace AssetTool
{
    [JsonAsset("UVSelectToolBuilder")]
    public class UUVSelectToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVSelectTool")]
    public class UUVSelectTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}