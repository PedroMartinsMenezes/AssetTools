namespace AssetTool
{
    [JsonAsset("AvaTextActorFactory")]
    public class UAvaTextActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}