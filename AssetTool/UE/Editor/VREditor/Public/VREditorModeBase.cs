namespace AssetTool
{
    [JsonAsset("VREditorModeBase")]
    public class UVREditorModeBase : UEditorWorldExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}