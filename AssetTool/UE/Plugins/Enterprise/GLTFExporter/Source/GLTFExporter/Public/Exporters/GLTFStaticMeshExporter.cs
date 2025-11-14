namespace AssetTool
{
    [JsonAsset("GLTFStaticMeshExporter")]
    public class UGLTFStaticMeshExporter : UGLTFExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}