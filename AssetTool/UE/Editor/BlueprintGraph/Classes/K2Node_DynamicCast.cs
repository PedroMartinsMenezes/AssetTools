namespace AssetTool
{
    [JsonAsset("K2Node_DynamicCast")]
    public class UK2Node_DynamicCast : UEdGraphNode
    {
        public EPureState PureState;

        [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DynamicCastNodesUsePureStateEnum)
            {
                transfer.MoveEnum(ref PureState);
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