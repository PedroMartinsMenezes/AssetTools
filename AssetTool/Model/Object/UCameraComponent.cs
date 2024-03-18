namespace AssetTool
{
    [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
    public class UCameraComponent : USceneComponent
    {
        public new const string TypeName = "CameraComponent";

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }

        public new UCameraComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
    }
}
