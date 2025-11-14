namespace AssetTool
{
    [JsonAsset("DataprepSelectionTransform")]
    public class UDataprepSelectionTransform : UDataprepParameterizableObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepRecursiveSelectionTransform")]
    public class UDataprepRecursiveSelectionTransform : UDataprepSelectionTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}