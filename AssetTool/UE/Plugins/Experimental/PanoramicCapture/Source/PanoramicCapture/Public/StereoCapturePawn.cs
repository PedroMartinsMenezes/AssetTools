namespace AssetTool
{
    [JsonAsset("StereoCapturePawn")]
    public class AStereoCapturePawn : ADefaultPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}