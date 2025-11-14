namespace AssetTool
{
    [JsonAsset("LensFile")]
    public class ULensFile : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}