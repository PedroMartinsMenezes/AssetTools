namespace AssetTool
{
    [JsonAsset("InterchangeProjectSettings")]
    public class UInterchangeProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}