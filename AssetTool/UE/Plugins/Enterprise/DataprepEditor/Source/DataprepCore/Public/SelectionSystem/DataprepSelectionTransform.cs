namespace AssetTool
{
    [JsonAsset("DataprepSelectionTransform")]
    public class UDataprepSelectionTransform : UDataprepParameterizableObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepRecursiveSelectionTransform")]
    public class UDataprepRecursiveSelectionTransform : UDataprepSelectionTransform
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}