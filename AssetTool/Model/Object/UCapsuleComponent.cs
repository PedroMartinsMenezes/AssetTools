namespace AssetTool
{
    [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("CapsuleComponent")]
    public class UCapsuleComponent : UShapeComponent
    {
        public new const string TypeName = "CapsuleComponent";
    }
}
