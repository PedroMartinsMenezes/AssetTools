namespace AssetTool
{
    [JsonAsset("VPBookmarkActor")]
    public class AVPBookmarkActor : AVPViewportTickableActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}