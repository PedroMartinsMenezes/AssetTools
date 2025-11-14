namespace AssetTool
{
    [JsonAsset("InterchangeActorFactory")]
    public class UInterchangeActorFactory : UInterchangeFactoryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}