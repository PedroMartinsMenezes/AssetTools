namespace AssetTool
{
    [JsonAsset("VRTool")]
    public class AVRTool : AVPTransientEditorTickableActorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}