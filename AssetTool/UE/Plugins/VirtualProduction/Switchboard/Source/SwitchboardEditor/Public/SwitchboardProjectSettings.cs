namespace AssetTool
{
    [JsonAsset("SwitchboardProjectSettings")]
    public class USwitchboardProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}