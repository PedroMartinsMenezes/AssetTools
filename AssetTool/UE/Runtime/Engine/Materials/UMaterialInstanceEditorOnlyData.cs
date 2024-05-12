namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInstanceEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialInstanceEditorOnlyData";

        public new UMaterialInstanceEditorOnlyData Move(Transfer transfer) => (UMaterialInstanceEditorOnlyData)base.Move(transfer);
    }
}
