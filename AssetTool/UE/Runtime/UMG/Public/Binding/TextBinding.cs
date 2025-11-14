namespace AssetTool
{
    [JsonAsset("TextBinding")]
    public class UTextBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}