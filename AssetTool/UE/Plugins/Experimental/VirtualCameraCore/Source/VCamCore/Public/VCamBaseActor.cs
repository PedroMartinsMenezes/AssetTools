namespace AssetTool
{
    [JsonAsset("VCamBaseActor")]
    public class AVCamBaseActor : ACineCameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}