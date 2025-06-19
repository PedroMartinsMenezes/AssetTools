namespace AssetTool
{
    [JsonAsset("DataprepStringFilterMatchingArray")]
    public class UDataprepStringFilterMatchingArray : UDataprepParameterizableObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepStringFilter")]
    public class UDataprepStringFilter : UDataprepFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}