namespace AssetTool
{
    [JsonAsset("CEEffectorTypeBase")]
    public class UCEEffectorTypeBase : UCEEffectorExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}