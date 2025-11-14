namespace AssetTool
{
    [JsonAsset("DEditorScalarParameterValue")]
    public class UDEditorScalarParameterValue : UDEditorParameterValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}