namespace AssetTool
{
    [JsonAsset("PhysicsAssetFactory")]
    public class UPhysicsAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}