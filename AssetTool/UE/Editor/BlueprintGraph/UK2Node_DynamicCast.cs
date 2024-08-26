namespace AssetTool
{
    [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UK2Node_DynamicCast : UK2Node
    {
        public const string TypeName = "K2Node_DynamicCast";

        public byte PureState;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PureState);
            return this;
        }
    }
}
