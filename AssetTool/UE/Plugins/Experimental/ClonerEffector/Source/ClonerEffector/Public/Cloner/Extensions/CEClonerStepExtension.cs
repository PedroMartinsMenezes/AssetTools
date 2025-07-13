namespace AssetTool
{
    [JsonAsset("CEClonerStepExtension")]
    public class UCEClonerStepExtension : UCEClonerExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}