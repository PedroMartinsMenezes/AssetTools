namespace AssetTool
{
    [JsonAsset("InterchangeLevelInstanceActorFactory")]
    public class UInterchangeLevelInstanceActorFactory : UInterchangeActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}