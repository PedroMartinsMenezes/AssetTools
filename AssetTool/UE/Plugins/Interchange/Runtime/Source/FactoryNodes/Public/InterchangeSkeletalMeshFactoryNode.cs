namespace AssetTool
{
    [JsonAsset("InterchangeSkeletalMeshFactoryNode")]
    public class UInterchangeSkeletalMeshFactoryNode : UInterchangeMeshFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}