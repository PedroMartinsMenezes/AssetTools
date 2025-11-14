namespace AssetTool
{
    [JsonAsset("CEEffectorTypeBase")]
    public class UCEEffectorTypeBase : UCEEffectorExtensionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}