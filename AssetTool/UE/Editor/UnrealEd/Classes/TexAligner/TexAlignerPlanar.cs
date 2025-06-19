namespace AssetTool
{
    [JsonAsset("TexAlignerPlanar")]
    public class UTexAlignerPlanar : UTexAligner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}