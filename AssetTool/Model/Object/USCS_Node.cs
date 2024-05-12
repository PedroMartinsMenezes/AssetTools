namespace AssetTool
{
    [Location("void USCS_Node::Serialize(FArchive& Ar)")]
    public class USCS_Node : UObject
    {
        public const string TypeName = "SCS_Node";

        public new USCS_Node Move(Transfer transfer) => (USCS_Node)base.Move(transfer);
    }
}
