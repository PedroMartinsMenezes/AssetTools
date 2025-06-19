namespace AssetTool
{
    [JsonAsset("InterchangeStaticMeshFactoryNode")]
    public class UInterchangeStaticMeshFactoryNode : UInterchangeMeshFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}