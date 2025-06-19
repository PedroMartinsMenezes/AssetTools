namespace AssetTool
{
    [JsonAsset("InterchangePhysicsAssetFactory")]
    public class UInterchangePhysicsAssetFactory : UInterchangeFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}