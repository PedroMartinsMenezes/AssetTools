namespace AssetTool
{
    public class UK2Node_Knot : UK2Node
    {
        public const string TypeName = "K2Node_Knot";

        public new UK2Node_Knot Read(BinaryReader reader)
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
