namespace AssetTool
{
    [JsonAsset("VPTransientEditorTickableActorBase")]
    public class AVPTransientEditorTickableActorBase : AVPEditorTickableActorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}