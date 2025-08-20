namespace AssetTool
{
    [JsonAsset("CEClonerEffectorExtension")]
    public class UCEClonerEffectorExtension : UCEClonerExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}