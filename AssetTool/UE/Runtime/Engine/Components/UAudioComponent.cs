namespace AssetTool
{
    [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UAudioComponent : USceneComponent
    {
        public new const string TypeName = "AudioComponent";
    }
}
