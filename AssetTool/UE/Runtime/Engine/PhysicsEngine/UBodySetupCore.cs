namespace AssetTool
{
    public class UBodySetupCore : UObject
    {
        public UBodySetupCore Read(BinaryReader reader)
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
