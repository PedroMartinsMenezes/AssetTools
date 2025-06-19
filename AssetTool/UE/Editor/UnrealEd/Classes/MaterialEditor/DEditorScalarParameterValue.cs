namespace AssetTool
{
    [JsonAsset("DEditorScalarParameterValue")]
    public class UDEditorScalarParameterValue : UDEditorParameterValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}