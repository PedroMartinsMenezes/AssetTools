namespace AssetTool
{
    [JsonAsset("VCamTestActor")]
    public class AVCamTestActor : AVCamBaseActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}