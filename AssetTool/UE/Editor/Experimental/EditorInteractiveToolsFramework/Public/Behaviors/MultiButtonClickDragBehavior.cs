namespace AssetTool
{
    [JsonAsset("MultiButtonClickDragBehavior")]
    public class UMultiButtonClickDragBehavior : UClickDragInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}