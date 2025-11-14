namespace AssetTool
{
    [JsonAsset("CaptureData")]
    public class UCaptureData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshCaptureData")]
    public class UMeshCaptureData : UCaptureData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FootageCaptureData")]
    public class UFootageCaptureData : UCaptureData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}