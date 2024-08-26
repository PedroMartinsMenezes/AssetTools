namespace AssetTool
{
    [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
    [JsonAsset("StaticMesh")]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public const string TypeName = "StaticMesh";
    }
}
