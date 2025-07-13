namespace AssetTool
{
    [JsonAsset("MetaSoundBuilderBase")]
    public class UMetaSoundBuilderBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}