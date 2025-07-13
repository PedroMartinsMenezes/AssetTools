namespace AssetTool
{
    [JsonAsset("DataprepOverlappingActorsSelectionTransform")]
    public class UDataprepOverlappingActorsSelectionTransform : UDataprepSelectionTransform
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}