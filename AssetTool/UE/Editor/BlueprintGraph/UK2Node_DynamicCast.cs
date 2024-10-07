namespace AssetTool
{
    [JsonAsset("K2Node_DynamicCast")]
    public class UK2Node_DynamicCast : UK2Node
    {
        public byte PureState = 1;

        [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.DynamicCastNodesUsePureStateEnum))
            {
                transfer.Move(ref PureState);
            }
            return this;
        }
    }
}
