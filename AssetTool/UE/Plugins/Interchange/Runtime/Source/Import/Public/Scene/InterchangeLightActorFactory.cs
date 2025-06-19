namespace AssetTool
{
    [JsonAsset("InterchangeLightActorFactory")]
    public class UInterchangeLightActorFactory : UInterchangeActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}