namespace AssetTool
{
    [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    public class UCapsuleComponent : UShapeComponent
    {
        public new const string TypeName = "CapsuleComponent";

        public new UCapsuleComponent Read(BinaryReader reader)
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
