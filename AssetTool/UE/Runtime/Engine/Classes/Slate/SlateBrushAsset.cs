namespace AssetTool
{
    [JsonAsset("SlateBrushAsset")]
    public class USlateBrushAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}