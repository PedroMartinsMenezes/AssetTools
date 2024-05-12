namespace AssetTool
{
    [Location("void UK2Node_CallFunction::Serialize(FArchive& Ar)")]
    public class UK2Node_CallMaterialParameterCollectionFunction : UK2Node_CallFunction
    {
        public new const string TypeName = "K2Node_CallMaterialParameterCollectionFunction";

        public new UK2Node_CallMaterialParameterCollectionFunction Move(Transfer transfer) => (UK2Node_CallMaterialParameterCollectionFunction)base.Move(transfer);
    }
}
