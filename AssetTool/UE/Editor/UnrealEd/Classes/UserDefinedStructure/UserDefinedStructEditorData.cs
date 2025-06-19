namespace AssetTool
{
    [JsonAsset("UserDefinedStructEditorData")]
    public class UUserDefinedStructEditorData : UUserDefinedStructEditorDataBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}