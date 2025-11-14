namespace AssetTool
{
    [JsonAsset("CommonInputSettings")]
    public class UCommonInputSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}