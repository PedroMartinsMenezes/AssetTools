namespace AssetTool
{
    [JsonAsset("SlateBrushAsset")]
    public class USlateBrushAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}