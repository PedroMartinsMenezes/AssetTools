namespace AssetTool
{
    [JsonAsset("AvaTextActorFactory")]
    public class UAvaTextActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}