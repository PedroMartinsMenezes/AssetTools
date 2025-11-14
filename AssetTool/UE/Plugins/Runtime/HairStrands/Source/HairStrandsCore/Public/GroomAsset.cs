namespace AssetTool
{
    [JsonAsset("GroomAsset")]
    public class UGroomAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}