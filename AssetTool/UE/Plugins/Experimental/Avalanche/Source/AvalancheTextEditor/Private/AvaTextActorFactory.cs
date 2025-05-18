namespace AssetTool
{
    [JsonAsset("AvaTextActorFactory")]
    public class UAvaTextActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}