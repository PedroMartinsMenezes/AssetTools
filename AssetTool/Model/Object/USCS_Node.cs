namespace AssetTool
{
    [JsonAsset("SCS_Node")]
    public class USCS_Node : UObject
    {
        [Location("void USCS_Node::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
