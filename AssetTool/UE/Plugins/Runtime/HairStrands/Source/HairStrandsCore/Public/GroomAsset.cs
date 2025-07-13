namespace AssetTool
{
    [JsonAsset("GroomAsset")]
    public class UGroomAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}