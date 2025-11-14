namespace AssetTool
{
    [JsonAsset("DummyMeshReconstructor")]
    public class UDummyMeshReconstructor : UMeshReconstructorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}