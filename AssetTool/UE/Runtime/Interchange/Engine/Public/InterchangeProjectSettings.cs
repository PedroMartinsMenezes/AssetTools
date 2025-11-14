namespace AssetTool
{
    [JsonAsset("InterchangeProjectSettings")]
    public class UInterchangeProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}