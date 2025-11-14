namespace AssetTool
{
    [JsonAsset("MeshCaptureDataFactory")]
    public class UMeshCaptureDataFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FootageCaptureDataFactory")]
    public class UFootageCaptureDataFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}