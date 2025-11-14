namespace AssetTool
{
    [JsonAsset("CEClonerLayoutBase")]
    public class UCEClonerLayoutBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}