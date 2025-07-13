namespace AssetTool
{
    [JsonAsset("EditorTutorial")]
    public class UEditorTutorial : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}