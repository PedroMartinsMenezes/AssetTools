namespace AssetTool
{
    [JsonAsset("CEClonerRangeExtension")]
    public class UCEClonerRangeExtension : UCEClonerExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}