namespace AssetTool
{
    [JsonAsset("FleshAssetFactory")]
    public class UFleshAssetFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}