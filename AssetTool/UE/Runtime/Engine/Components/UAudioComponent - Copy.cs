namespace AssetTool
{
    [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("AudioComponent")]
    public class UAudioComponent : USceneComponent
    {
        public new const string TypeName = "AudioComponent";
    }
}
