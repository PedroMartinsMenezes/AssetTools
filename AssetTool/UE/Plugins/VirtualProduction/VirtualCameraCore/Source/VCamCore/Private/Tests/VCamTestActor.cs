namespace AssetTool
{
    [JsonAsset("VCamTestActor")]
    public class AVCamTestActor : AVCamBaseActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}