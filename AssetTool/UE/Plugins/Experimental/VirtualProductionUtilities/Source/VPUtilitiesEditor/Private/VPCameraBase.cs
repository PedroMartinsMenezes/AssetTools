namespace AssetTool
{
    [JsonAsset("VPCameraBase")]
    public class AVPCameraBase : ACineCameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}