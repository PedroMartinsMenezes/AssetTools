namespace AssetTool
{
    [JsonAsset("VCamBaseActorWithPreset")]
    public class AVCamBaseActorWithPreset : AVCamBaseActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}