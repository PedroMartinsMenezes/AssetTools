namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UNavMovementComponent : UMovementComponent
    {
        public new UNavMovementComponent Read(BinaryReader reader)
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
