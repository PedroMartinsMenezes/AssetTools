namespace AssetTool
{
    [JsonAsset("MetaHumanItemPipeline")]
    public class UMetaHumanItemPipeline : UMetaHumanCharacterPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}