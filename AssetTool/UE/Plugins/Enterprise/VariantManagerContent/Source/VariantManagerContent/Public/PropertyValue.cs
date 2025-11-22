namespace AssetTool
{
    [JsonAsset("PropertyValue")]
    public class UPropertyValue : UObject
    {
        public FName Name;
        public UInt64 LeafPropertyClass;
        public FSoftObjectPtr TempObjPtr;
        public FName TempName;
        public FString TempStr;
        public FText TempText;

        [Location("void UPropertyValue::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.Supports.FProperties)
            {
                transfer.Move(ref LeafPropertyClass);
            }
            transfer.Move(ref TempObjPtr);
            if (transfer.Supports.CorrectSerializationOfFStringBytes)
            {
                transfer.Move(ref TempName);
                transfer.Move(ref TempStr);
                transfer.Move(ref TempText);
            }
            else
            {
                transfer.Move(ref Name);
            }
            return this;
        }
    }
}