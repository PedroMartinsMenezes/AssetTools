namespace AssetTool
{
    [JsonAsset("OptimusSettings")]
    public class UOptimusSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}