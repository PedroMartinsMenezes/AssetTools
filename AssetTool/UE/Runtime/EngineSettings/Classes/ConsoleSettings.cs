namespace AssetTool
{
    [JsonAsset("ConsoleSettings")]
    public class UConsoleSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}