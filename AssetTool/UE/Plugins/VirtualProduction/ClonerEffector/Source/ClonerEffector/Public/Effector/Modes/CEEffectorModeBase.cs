namespace AssetTool
{
    [JsonAsset("CEEffectorModeBase")]
    public class UCEEffectorModeBase : UCEEffectorExtensionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}