namespace AssetTool
{
    [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public const string TypeName = "StaticMesh";
    }
}
