namespace AssetTool
{
    [JsonAsset("VREditorTeleporter")]
    public class AVREditorTeleporter : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}