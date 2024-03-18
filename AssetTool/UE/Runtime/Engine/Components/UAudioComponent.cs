namespace AssetTool
{
    [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
    public class UAudioComponent : USceneComponent
    {
        public new const string TypeName = "AudioComponent";

        public new UAudioComponent Read(BinaryReader reader)
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
