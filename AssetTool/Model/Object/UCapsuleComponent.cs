namespace AssetTool
{
    [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UCapsuleComponent : UShapeComponent
    {
        public new const string TypeName = "CapsuleComponent";
    }
}
