namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UMovementComponent : UActorComponent
    {
        public new UMovementComponent Read(BinaryReader reader)
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
