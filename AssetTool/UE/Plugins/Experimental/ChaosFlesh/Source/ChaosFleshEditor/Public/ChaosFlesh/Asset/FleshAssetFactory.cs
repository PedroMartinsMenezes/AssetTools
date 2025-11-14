namespace AssetTool
{
    [JsonAsset("FleshAssetFactory")]
    public class UFleshAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}