namespace AssetTool
{
    [JsonAsset("PhysicsAssetFactory")]
    public class UPhysicsAssetFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}