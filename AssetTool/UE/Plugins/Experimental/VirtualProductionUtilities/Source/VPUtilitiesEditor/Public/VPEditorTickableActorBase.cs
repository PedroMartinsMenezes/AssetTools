namespace AssetTool
{
    [JsonAsset("VPEditorTickableActorBase")]
    public class AVPEditorTickableActorBase : AVPViewportTickableActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}