namespace AssetTool
{
    [JsonAsset("FusionPatchAssetFactory")]
    public class UFusionPatchAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}