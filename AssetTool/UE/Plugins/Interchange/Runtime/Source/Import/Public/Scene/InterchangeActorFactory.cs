namespace AssetTool
{
    [JsonAsset("InterchangeActorFactory")]
    public class UInterchangeActorFactory : UInterchangeFactoryBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}