namespace AssetTool
{
    [TransferibleStruct("InstancedPropertyBag")]
    public class FInstancedPropertyBag : ITransferible
    {
        public EVersion Version = EVersion.LatestVersion;
        public FBool bHasData;
        public List<FPropertyBagPropertyDesc> PropertyDescs;
        public Int32 SerialSize;
        public UPropertyBag BagStruct;

        [Location("bool FInstancedPropertyBag::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.ContainerTypes)
            {
                Version = (EVersion)transfer.Move((uint8)Version);
            }
            transfer.Move(ref bHasData);
            if (bHasData)
            {
                transfer.Move(ref PropertyDescs);
                if (Version >= EVersion.SerializeStructSize)
                {
                    transfer.Move(ref SerialSize);
                }
                BagStruct ??= new();
                BagStruct.SerializeItem(transfer);
            }

            return this;
        }
    }

    public class FPropertyBagPropertyDesc : ITransferible
    {
        public UInt32 ValueTypeObject;
        public FGuid ID;
        public FName Name;
        public EPropertyBagPropertyType ValueType;
        public EPropertyBagContainerType TmpContainerType;
        public FBool bHasMetaData;
        public List<FPropertyBagPropertyDescMetaData> MetaData;

        [Location("static FArchive& operator<<(FArchive& Ar, FPropertyBagPropertyDesc& Bag)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ValueTypeObject);
            transfer.Move(ref ID);
            transfer.Move(ref Name);
            ValueType = (EPropertyBagPropertyType)transfer.Move((uint8)ValueType);
            if (Supports.ContainerTypes)
            {
                if (Supports.NestedContainerTypes)
                {
                    TmpContainerType = (EPropertyBagContainerType)transfer.Move((uint8)TmpContainerType);
                }
            }
            transfer.Move(ref bHasMetaData);
            if (bHasMetaData)
            {
                transfer.Move(ref MetaData);
            }
            return this;
        }
    }

    public class FPropertyBagPropertyDescMetaData : ITransferible
    {
        public FName Key;
        public FString Value;

        [Location("void FPropertyBagPropertyDescMetaData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            transfer.Move(ref Value);
            return this;
        }
    }

    public enum EVersion : uint8
    {
        InitialVersion = 0,
        SerializeStructSize,
        VersionPlusOne,
        LatestVersion = VersionPlusOne - 1
    }

    public enum EPropertyBagPropertyType : uint8
    {
        None,
        Bool,
        Byte,
        Int32,
        Int64,
        Float,
        Double,
        Name,
        String,
        Text,
        Enum,
        Struct,
        Object,
        SoftObject,
        Class,
        SoftClass,
        Count
    }

    public enum EPropertyBagContainerType : uint8
    {
        None,
        Array,
        Count
    }
}