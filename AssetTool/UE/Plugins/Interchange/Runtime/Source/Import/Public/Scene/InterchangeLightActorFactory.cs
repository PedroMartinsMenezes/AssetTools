namespace AssetTool
{
    [JsonAsset("InterchangeLightActorFactory")]
    public class UInterchangeLightActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}