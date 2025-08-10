namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultSkeletalMeshPipelineMaterialParameters")]
    public class UMetaHumanDefaultSkeletalMeshPipelineMaterialParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanDefaultSkeletalMeshPipeline")]
    public class UMetaHumanDefaultSkeletalMeshPipeline : UMetaHumanSkeletalMeshPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}