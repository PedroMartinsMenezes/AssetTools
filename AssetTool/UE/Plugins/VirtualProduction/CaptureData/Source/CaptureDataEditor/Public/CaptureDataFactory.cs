namespace AssetTool
{
    [JsonAsset("MeshCaptureDataFactory")]
    public class UMeshCaptureDataFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FootageCaptureDataFactory")]
    public class UFootageCaptureDataFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}