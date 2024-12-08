namespace AssetTool
{
    [JsonAsset("VCamBaseActor")]
    public class AVCamBaseActor : ACineCameraActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}