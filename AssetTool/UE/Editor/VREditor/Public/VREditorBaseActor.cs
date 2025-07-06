namespace AssetTool
{
    [JsonAsset("VREditorBaseActor")]
    public class AVREditorBaseActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}