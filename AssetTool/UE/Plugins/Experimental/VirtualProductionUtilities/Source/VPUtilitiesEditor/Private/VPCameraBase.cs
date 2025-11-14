namespace AssetTool
{
    [JsonAsset("VPCameraBase")]
    public class AVPCameraBase : ACineCameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}