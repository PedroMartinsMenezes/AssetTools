namespace AssetTool
{
    public class UK2Node_Tunnel : UK2Node_EditablePinBase
    {
        public new UK2Node_Tunnel Read(BinaryReader reader)
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
