namespace AssetTool
{
    [JsonAsset("SlateBrushAssetFactory")]
    public class USlateBrushAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}