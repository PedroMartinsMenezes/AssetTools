namespace AssetTool
{
    [JsonAsset("DMXControlConsoleActorFactory")]
    public class UDMXControlConsoleActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}