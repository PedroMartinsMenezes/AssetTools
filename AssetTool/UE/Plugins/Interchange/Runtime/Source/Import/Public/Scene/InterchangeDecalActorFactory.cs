namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactory")]
    public class UInterchangeDecalActorFactory : UInterchangeActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}