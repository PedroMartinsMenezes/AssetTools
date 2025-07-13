namespace AssetTool
{
    [JsonAsset("CEEffectorModeBase")]
    public class UCEEffectorModeBase : UCEEffectorExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}