namespace AssetTool
{
    [JsonAsset("ARTexture")]
    public class UARTexture : UTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTextureCameraImage")]
    public class UARTextureCameraImage : UARTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTextureCameraDepth")]
    public class UARTextureCameraDepth : UARTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AREnvironmentCaptureProbeTexture")]
    public class UAREnvironmentCaptureProbeTexture : UTextureCube
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}