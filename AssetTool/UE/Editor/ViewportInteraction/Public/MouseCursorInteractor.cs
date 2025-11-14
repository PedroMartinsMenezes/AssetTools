namespace AssetTool
{
    [JsonAsset("MouseCursorInteractor")]
    public class UMouseCursorInteractor : UViewportInteractor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}