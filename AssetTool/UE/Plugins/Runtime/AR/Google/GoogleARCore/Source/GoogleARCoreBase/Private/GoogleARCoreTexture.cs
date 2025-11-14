namespace AssetTool
{
    [JsonAsset("ARCoreCameraTexture")]
    public class UARCoreCameraTexture : UARTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARCoreDepthTexture")]
    public class UARCoreDepthTexture : UARTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}