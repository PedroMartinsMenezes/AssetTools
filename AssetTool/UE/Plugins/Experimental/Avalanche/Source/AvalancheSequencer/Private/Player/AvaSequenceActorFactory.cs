namespace AssetTool
{
    [JsonAsset("AvaSequenceActorFactory")]
    public class UAvaSequenceActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}