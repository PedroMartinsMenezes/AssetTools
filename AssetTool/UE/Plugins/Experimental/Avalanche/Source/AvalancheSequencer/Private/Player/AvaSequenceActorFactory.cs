namespace AssetTool
{
    [JsonAsset("AvaSequenceActorFactory")]
    public class UAvaSequenceActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}