namespace AssetTool
{
    public class FProperty : FField
    {
        public new const string TYPE_NAME = "Property";
        public override string TypeName => "FProperty";

        public Int32 ArrayDim;
        public Int32 ElementSize;
        public UInt64 PropertyFlags;
        public UInt16 RepIndex;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        [Location("void FProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref ArrayDim);
            transfer.Move(ref ElementSize);
            transfer.Move(ref PropertyFlags);
            transfer.Move(ref RepIndex);
            transfer.Move(ref RepNotifyFunc);
            transfer.Move(ref BlueprintReplicationCondition);

            return this;
        }
    }
}
