namespace AssetTool
{
    [JsonAsset("VCamBaseActorWithPreset")]
    public class AVCamBaseActorWithPreset : AVCamBaseActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}