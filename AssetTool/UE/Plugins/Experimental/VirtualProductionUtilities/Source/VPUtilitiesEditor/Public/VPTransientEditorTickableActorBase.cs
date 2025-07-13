namespace AssetTool
{
    [JsonAsset("VPTransientEditorTickableActorBase")]
    public class AVPTransientEditorTickableActorBase : AVPEditorTickableActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}