namespace AssetTool
{
    [Location("void USCS_Node::Serialize(FArchive& Ar)")]
    public class USCS_Node : UObject
    {
        public const string TypeName = "SCS_Node";

        public USCS_Node Read(BinaryReader reader)
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
