namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UMaterialInstanceEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialInstanceEditorOnlyData";
    }
}
