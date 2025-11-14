namespace AssetTool
{
    [JsonAsset("EditorUtilityTest")]
    public class UEditorUtilityTest : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}