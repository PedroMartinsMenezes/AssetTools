namespace AssetTool
{
    [JsonAsset("DummyMeshReconstructor")]
    public class UDummyMeshReconstructor : UMeshReconstructorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}