namespace AssetTool
{
    [JsonAsset("FloatBinding")]
    public class UFloatBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}