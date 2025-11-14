namespace AssetTool
{
    [JsonAsset("VREditorBaseActor")]
    public class AVREditorBaseActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}