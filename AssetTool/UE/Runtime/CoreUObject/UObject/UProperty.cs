namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UProperty : UField
    {
        public UInt32 ArrayDim;
        public UInt64 SaveFlags;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        public new UProperty Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref ArrayDim);
            transfer.Move(ref SaveFlags);
            transfer.Move(ref RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                transfer.Move(ref BlueprintReplicationCondition);
            }
            return this;
        }
    }
}
