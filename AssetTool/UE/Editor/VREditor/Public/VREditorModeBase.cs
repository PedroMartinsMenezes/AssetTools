namespace AssetTool
{
    [JsonAsset("VREditorModeBase")]
    public class UVREditorModeBase : UEditorWorldExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}