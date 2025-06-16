namespace AssetTool
{
    [JsonAsset("UserDefinedStructEditorData")]
    public class UUserDefinedStructEditorData : UUserDefinedStructEditorDataBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}