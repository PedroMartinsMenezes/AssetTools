namespace AssetTool
{
    [JsonAsset("MultiButtonClickDragBehavior")]
    public class UMultiButtonClickDragBehavior : UClickDragInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}