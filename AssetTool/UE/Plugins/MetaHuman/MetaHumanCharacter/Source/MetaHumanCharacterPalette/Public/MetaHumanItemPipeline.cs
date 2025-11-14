namespace AssetTool
{
    [JsonAsset("MetaHumanItemPipeline")]
    public class UMetaHumanItemPipeline : UMetaHumanCharacterPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}