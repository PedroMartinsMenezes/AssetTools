namespace AssetTool
{
    [JsonAsset("VCamBaseActor")]
    public class AVCamBaseActor : ACineCameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}