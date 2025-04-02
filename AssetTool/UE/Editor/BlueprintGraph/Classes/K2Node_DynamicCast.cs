namespace AssetTool
{
    [JsonAsset("K2Node_DynamicCast")]
    public class UK2Node_DynamicCast : UK2Node
    {
        public EPureState PureState;

        [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DynamicCastNodesUsePureStateEnum)
            {
                PureState = (EPureState)transfer.Move((byte)PureState);
            }
            return this;
        }
    }

    public enum EPureState : uint8
    {
        Pure,
        Impure,
        UseDefault
    }
}