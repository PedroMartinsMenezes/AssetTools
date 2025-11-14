namespace AssetTool
{
    [JsonAsset("BrushBinding")]
    public class UBrushBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}