namespace AssetTool
{
    [JsonAsset("ShallowWaterPhysicsAssetOverridesDataAsset")]
    public class UShallowWaterPhysicsAssetOverridesDataAsset : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}