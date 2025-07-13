namespace AssetTool
{
    [JsonAsset("EditorUtilityTest")]
    public class UEditorUtilityTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}