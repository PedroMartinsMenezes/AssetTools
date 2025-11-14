namespace AssetTool
{
    [JsonAsset("MeshReconstructorBase")]
    public class UMeshReconstructorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}