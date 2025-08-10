namespace AssetTool
{
    [JsonAsset("MetaHumanSkeletalMeshPipeline")]
    public class UMetaHumanSkeletalMeshPipeline : UMetaHumanItemPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}