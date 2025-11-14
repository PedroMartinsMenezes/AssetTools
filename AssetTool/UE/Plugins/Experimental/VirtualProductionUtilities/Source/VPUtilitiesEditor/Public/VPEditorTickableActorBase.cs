namespace AssetTool
{
    [JsonAsset("VPEditorTickableActorBase")]
    public class AVPEditorTickableActorBase : AVPViewportTickableActorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}