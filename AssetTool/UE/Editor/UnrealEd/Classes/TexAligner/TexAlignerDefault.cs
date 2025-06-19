namespace AssetTool
{
    [JsonAsset("TexAlignerDefault")]
    public class UTexAlignerDefault : UTexAligner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}