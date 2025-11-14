namespace AssetTool
{
    [JsonAsset("PhysicsAssetGenerationSettings")]
    public class UPhysicsAssetGenerationSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}