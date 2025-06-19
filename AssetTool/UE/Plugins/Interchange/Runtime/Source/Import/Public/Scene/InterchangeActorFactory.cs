namespace AssetTool
{
    [JsonAsset("InterchangeActorFactory")]
    public class UInterchangeActorFactory : UInterchangeFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}