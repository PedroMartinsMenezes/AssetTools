namespace AssetTool
{
    [JsonAsset("ShallowWaterPhysicsAssetOverridesDataAsset")]
    public class UShallowWaterPhysicsAssetOverridesDataAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}