namespace AssetTool
{
    public class UProperty : UField
    {
        public UInt32 ArrayDim;
        public UInt64 SaveFlags;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        [Location("void UProperty::Serialize( FArchive& Ar )")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref ArrayDim);
            transfer.Move(ref SaveFlags);
            transfer.Move(ref RepNotifyFunc);
            if (transfer.Supports.PropertiesSerializeRepCondition)
            {
                transfer.Move(ref BlueprintReplicationCondition);
            }
            return this;
        }
    }
}
