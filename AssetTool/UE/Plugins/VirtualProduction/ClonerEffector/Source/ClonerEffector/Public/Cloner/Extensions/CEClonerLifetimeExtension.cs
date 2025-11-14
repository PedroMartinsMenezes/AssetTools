namespace AssetTool
{
    [JsonAsset("CEClonerLifetimeExtension")]
    public class UCEClonerLifetimeExtension : UCEClonerExtensionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}