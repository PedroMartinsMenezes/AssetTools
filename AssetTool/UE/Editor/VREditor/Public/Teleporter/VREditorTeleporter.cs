namespace AssetTool
{
    [JsonAsset("VREditorTeleporter")]
    public class AVREditorTeleporter : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}