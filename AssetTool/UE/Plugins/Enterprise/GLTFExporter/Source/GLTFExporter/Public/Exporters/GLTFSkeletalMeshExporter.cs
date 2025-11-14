namespace AssetTool
{
    [JsonAsset("GLTFSkeletalMeshExporter")]
    public class UGLTFSkeletalMeshExporter : UGLTFExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}