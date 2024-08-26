namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    [JsonAsset("MaterialEditorOnlyData")]
    public class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialEditorOnlyData";
    }
}
