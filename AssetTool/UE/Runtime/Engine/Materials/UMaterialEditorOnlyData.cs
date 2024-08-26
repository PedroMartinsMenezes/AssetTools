namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialEditorOnlyData";
    }
}
