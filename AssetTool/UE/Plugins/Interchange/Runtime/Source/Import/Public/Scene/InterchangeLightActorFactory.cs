namespace AssetTool
{
    [JsonAsset("InterchangeLightActorFactory")]
    public class UInterchangeLightActorFactory : UInterchangeActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}