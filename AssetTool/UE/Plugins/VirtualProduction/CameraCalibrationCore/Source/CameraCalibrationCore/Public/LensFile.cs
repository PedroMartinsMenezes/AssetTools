namespace AssetTool
{
    [JsonAsset("LensFile")]
    public class ULensFile : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}