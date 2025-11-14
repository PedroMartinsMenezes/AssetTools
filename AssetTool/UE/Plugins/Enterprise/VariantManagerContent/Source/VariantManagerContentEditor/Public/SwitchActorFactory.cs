namespace AssetTool
{
    [JsonAsset("SwitchActorFactory")]
    public class USwitchActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}