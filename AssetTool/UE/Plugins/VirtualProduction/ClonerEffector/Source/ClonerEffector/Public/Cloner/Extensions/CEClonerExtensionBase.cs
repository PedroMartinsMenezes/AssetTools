namespace AssetTool
{
    [JsonAsset("CEClonerExtensionBase")]
    public class UCEClonerExtensionBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}