namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactory")]
    public class UInterchangeDecalActorFactory : UInterchangeActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}