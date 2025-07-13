namespace AssetTool
{
    [JsonAsset("CEClonerExtensionBase")]
    public class UCEClonerExtensionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}