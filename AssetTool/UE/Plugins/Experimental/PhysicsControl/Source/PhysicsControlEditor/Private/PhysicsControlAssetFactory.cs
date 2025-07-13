namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetFactory")]
    public class UPhysicsControlAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}