namespace AssetTool
{
    [JsonAsset("TexAlignerBox")]
    public class UTexAlignerBox : UTexAligner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}