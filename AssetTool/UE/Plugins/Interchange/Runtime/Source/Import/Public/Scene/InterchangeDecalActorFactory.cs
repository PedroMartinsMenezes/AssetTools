namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactory")]
    public class UInterchangeDecalActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}