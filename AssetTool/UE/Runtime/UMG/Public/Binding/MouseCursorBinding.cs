namespace AssetTool
{
    [JsonAsset("MouseCursorBinding")]
    public class UMouseCursorBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}