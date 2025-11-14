namespace AssetTool
{
    [JsonAsset("CEEffectorEffectBase")]
    public class UCEEffectorEffectBase : UCEEffectorExtensionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}