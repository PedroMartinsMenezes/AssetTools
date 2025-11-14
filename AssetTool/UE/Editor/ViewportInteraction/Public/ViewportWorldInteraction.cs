namespace AssetTool
{
    [JsonAsset("ViewportWorldInteraction")]
    public class UViewportWorldInteraction : UEditorWorldExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}