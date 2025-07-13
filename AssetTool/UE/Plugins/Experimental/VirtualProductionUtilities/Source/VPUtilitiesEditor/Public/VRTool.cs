namespace AssetTool
{
    [JsonAsset("VRTool")]
    public class AVRTool : AVPTransientEditorTickableActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}