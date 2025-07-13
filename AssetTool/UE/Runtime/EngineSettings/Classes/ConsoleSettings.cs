namespace AssetTool
{
    [JsonAsset("ConsoleSettings")]
    public class UConsoleSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}