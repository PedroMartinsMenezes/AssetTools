namespace AssetTool
{
    [JsonAsset("CEEffectorActorFactory")]
    public class UCEEffectorActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}