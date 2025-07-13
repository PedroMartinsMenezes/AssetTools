namespace AssetTool
{
    [JsonAsset("MeshReconstructorBase")]
    public class UMeshReconstructorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}