namespace AssetTool
{
    [JsonAsset("StateTreeSettings")]
    public class UStateTreeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}