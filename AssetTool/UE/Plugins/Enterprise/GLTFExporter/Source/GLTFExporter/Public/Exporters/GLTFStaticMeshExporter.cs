namespace AssetTool
{
    [JsonAsset("GLTFStaticMeshExporter")]
    public class UGLTFStaticMeshExporter : UGLTFExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}