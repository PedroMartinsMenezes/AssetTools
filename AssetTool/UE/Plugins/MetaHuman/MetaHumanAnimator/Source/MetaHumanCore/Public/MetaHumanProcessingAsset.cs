namespace AssetTool
{
    [JsonAsset("MetaHumanProcessingAsset")]
    public class UMetaHumanProcessingAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}