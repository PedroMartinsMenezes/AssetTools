namespace AssetTool
{
    [JsonAsset("CEEffectorExtensionBase")]
    public class UCEEffectorExtensionBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}