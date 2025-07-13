namespace AssetTool
{
    [JsonAsset("EditorTutorialFactory")]
    public class UEditorTutorialFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}