using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(TStaticMeshVertexData<TUInt32>), "TStaticMeshVertexDataTUInt32")]
    [JsonDerivedType(typeof(TStaticMeshVertexData<TDouble>), "TStaticMeshVertexDataTDouble")]
    [JsonDerivedType(typeof(TStaticMeshVertexData<TFloat>), "TStaticMeshVertexDataTFloat")]
    [JsonDerivedType(typeof(FSkinWeightVertexData<TLegacySkinWeightInfo<ConstTrue>>), "FSkinWeightVertexDataTLegacySkinWeightInfoConstTrue")]
    [JsonDerivedType(typeof(FSkinWeightVertexData<TLegacySkinWeightInfo<ConstFalse>>), "FSkinWeightVertexDataTLegacySkinWeightInfoConstFalse")]
    [JsonDerivedType(typeof(FSkinWeightVertexData<TUInt8>), "FSkinWeightVertexDataTUInt8")]
    public interface FStaticMeshVertexDataInterface : ITransferible
    {
    }
}
