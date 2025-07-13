namespace AssetTool
{
    [JsonAsset("VPViewportTickableActorBase")]
    public class AVPViewportTickableActorBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}