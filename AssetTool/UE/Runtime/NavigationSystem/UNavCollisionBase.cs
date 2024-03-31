namespace AssetTool
{
    public class UNavCollisionBase : UObject
    {
        public UNavCollisionBase Read(BinaryReader reader)
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
