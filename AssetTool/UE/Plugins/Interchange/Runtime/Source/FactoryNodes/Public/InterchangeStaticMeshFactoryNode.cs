namespace AssetTool
{
    [JsonAsset("InterchangeStaticMeshFactoryNode")]
    public class UInterchangeStaticMeshFactoryNode : UInterchangeMeshFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}