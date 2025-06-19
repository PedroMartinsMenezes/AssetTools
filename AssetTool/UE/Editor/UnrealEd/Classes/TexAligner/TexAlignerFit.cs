namespace AssetTool
{
    [JsonAsset("TexAlignerFit")]
    public class UTexAlignerFit : UTexAligner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}