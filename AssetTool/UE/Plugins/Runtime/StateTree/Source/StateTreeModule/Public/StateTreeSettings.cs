namespace AssetTool
{
    [JsonAsset("StateTreeSettings")]
    public class UStateTreeSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}