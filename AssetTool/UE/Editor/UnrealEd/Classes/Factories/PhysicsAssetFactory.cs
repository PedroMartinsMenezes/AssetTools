namespace AssetTool
{
    [JsonAsset("PhysicsAssetFactory")]
    public class UPhysicsAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}