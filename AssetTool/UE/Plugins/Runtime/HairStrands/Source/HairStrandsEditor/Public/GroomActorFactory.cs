namespace AssetTool
{
    [JsonAsset("GroomActorFactory")]
    public class UGroomActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}