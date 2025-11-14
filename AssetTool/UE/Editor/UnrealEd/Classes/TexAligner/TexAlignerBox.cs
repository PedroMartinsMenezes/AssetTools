namespace AssetTool
{
    [JsonAsset("TexAlignerBox")]
    public class UTexAlignerBox : UTexAligner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}