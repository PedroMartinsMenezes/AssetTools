namespace AssetTool
{
    [JsonAsset("PhysicsAssetGenerationSettings")]
    public class UPhysicsAssetGenerationSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}