namespace AssetTool
{
    [JsonAsset("CEEffectorEffectBase")]
    public class UCEEffectorEffectBase : UCEEffectorExtensionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}