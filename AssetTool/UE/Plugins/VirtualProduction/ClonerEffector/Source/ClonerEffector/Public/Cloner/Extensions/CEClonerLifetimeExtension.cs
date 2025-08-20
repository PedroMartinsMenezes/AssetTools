namespace AssetTool
{
    [JsonAsset("CEClonerLifetimeExtension")]
    public class UCEClonerLifetimeExtension : UCEClonerExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}