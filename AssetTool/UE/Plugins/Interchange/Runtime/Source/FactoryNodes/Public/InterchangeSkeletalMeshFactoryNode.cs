namespace AssetTool
{
    [JsonAsset("InterchangeSkeletalMeshFactoryNode")]
    public class UInterchangeSkeletalMeshFactoryNode : UInterchangeMeshFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}