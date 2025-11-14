namespace AssetTool
{
    [JsonAsset("TexAlignerDefault")]
    public class UTexAlignerDefault : UTexAligner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}