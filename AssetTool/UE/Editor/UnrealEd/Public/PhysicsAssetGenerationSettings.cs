namespace AssetTool
{
    [JsonAsset("PhysicsAssetGenerationSettings")]
    public class UPhysicsAssetGenerationSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}