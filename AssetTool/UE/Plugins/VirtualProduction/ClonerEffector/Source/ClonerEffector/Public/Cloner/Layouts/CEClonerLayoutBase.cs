namespace AssetTool
{
    [JsonAsset("CEClonerLayoutBase")]
    public class UCEClonerLayoutBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}