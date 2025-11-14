namespace AssetTool
{
    [JsonAsset("ARTexture")]
    public class UARTexture : UTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTextureCameraImage")]
    public class UARTextureCameraImage : UARTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTextureCameraDepth")]
    public class UARTextureCameraDepth : UARTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AREnvironmentCaptureProbeTexture")]
    public class UAREnvironmentCaptureProbeTexture : UTextureCube
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}