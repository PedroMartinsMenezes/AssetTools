namespace AssetTool
{
    [JsonAsset("CEEffectorActorFactory")]
    public class UCEEffectorActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}