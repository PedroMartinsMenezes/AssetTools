namespace AssetTool
{
    [JsonAsset("CEEffectorExtensionBase")]
    public class UCEEffectorExtensionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}