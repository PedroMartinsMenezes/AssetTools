namespace AssetTool
{
    [Location("void ULightComponentBase::Serialize(FArchive& Ar)")]
    public class ULightComponentBase : USceneComponent
    {
        public new ULightComponentBase Read(BinaryReader reader)
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
