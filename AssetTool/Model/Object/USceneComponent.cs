namespace AssetTool
{
    [Location("void USceneComponent::Serialize(FArchive& Ar)")]
    public class USceneComponent : UActorComponent
    {
        public const string TypeName = "SceneComponent";

        public new USceneComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
