namespace AssetTool
{
    [JsonAsset("BoolBinding")]
    public class UBoolBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}