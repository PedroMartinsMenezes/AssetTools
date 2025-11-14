namespace AssetTool
{
    [JsonAsset("AvaSequenceActorFactory")]
    public class UAvaSequenceActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}