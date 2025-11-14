namespace AssetTool
{
    [JsonAsset("GroomActorFactory")]
    public class UGroomActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}