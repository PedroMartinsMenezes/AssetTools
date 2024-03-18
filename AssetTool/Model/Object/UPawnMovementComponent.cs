namespace AssetTool
{
    [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
    public class UPawnMovementComponent : UNavMovementComponent
    {
        public new UPawnMovementComponent Read(BinaryReader reader)
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
