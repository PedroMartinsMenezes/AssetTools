namespace AssetTool
{
    [JsonAsset("IndicatorDescriptor")]
    public class UIndicatorDescriptor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}