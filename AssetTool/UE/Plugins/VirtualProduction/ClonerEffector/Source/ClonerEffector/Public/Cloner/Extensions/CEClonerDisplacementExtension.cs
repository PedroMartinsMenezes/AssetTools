namespace AssetTool
{
    [JsonAsset("CEClonerDisplacementExtension")]
    public class UCEClonerDisplacementExtension : UCEClonerExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}