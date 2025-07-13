namespace AssetTool
{
    [JsonAsset("MetaHumanSDKSettings")]
    public class UMetaHumanSDKSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}