namespace AssetTool
{
    [JsonAsset("InterchangeLevelInstanceActorFactory")]
    public class UInterchangeLevelInstanceActorFactory : UInterchangeActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}