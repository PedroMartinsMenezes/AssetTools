namespace AssetTool
{
    [JsonAsset("UserDefinedStructEditorData")]
    public class UUserDefinedStructEditorData : UUserDefinedStructEditorDataBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}