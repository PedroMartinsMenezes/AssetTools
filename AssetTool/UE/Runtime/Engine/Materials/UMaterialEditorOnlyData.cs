namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialEditorOnlyData";

        public new UMaterialEditorOnlyData Move(Transfer transfer) => (UMaterialEditorOnlyData)base.Move(transfer);
    }
}
