namespace AssetTool
{
    [JsonAsset("InterchangeLevelInstanceActorFactory")]
    public class UInterchangeLevelInstanceActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}