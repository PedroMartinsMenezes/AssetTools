namespace AssetTool
{
    [JsonAsset("TexAlignerPlanar")]
    public class UTexAlignerPlanar : UTexAligner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}