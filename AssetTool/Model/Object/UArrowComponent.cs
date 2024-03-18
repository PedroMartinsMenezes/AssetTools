namespace AssetTool
{
    public class UArrowComponent : UPrimitiveComponent
    {
        public new const string TypeName = "ArrowComponent";

        public new UArrowComponent Read(BinaryReader reader)
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
