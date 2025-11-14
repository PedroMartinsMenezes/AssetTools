namespace AssetTool
{
    [JsonAsset("StereoCapturePawn")]
    public class AStereoCapturePawn : ADefaultPawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}