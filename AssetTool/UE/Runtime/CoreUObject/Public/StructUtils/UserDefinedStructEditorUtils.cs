namespace AssetTool
{
    [JsonAsset("UserDefinedStructEditorDataBase")]
    public class UUserDefinedStructEditorDataBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
