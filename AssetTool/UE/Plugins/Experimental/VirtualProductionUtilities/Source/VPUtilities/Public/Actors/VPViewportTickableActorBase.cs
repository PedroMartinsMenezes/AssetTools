namespace AssetTool
{
    [JsonAsset("VPViewportTickableActorBase")]
    public class AVPViewportTickableActorBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}