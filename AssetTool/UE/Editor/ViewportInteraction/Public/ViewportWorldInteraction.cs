namespace AssetTool
{
    [JsonAsset("ViewportWorldInteraction")]
    public class UViewportWorldInteraction : UEditorWorldExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}