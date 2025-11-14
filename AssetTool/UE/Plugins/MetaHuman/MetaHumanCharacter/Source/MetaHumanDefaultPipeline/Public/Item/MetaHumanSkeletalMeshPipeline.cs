namespace AssetTool
{
    [JsonAsset("MetaHumanSkeletalMeshPipeline")]
    public class UMetaHumanSkeletalMeshPipeline : UMetaHumanItemPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}