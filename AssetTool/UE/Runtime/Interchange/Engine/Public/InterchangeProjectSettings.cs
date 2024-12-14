namespace AssetTool
{
    [JsonAsset("InterchangeProjectSettings")]
    public class UInterchangeProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}