using System.ComponentModel;
using System.Diagnostics;

namespace AssetTool
{
    [TransferableStruct("InstancedPropertyBag")]
    public class FInstancedPropertyBag : ITransferable
    {
        public EVersion Version = EVersion.LatestVersion;
        public bool bHasData;
        public List<FPropertyBagPropertyDesc> PropertyDescs;
        public Int32 SerialSize;
        public UScriptStruct BagStruct;

        [Location("bool FInstancedPropertyBag::Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.ContainerTypes)
            {
                transfer.MoveEnum(ref Version);
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

    public class FPropertyBagPropertyDesc : ITransferable
    {
        public FObjectPtr ValueTypeObject;
        public FGuid ID;
        public FName Name;
        public EPropertyBagPropertyType ValueType;
        public EPropertyBagContainerType TmpContainerType;
        public bool bHasMetaData;
        public List<FPropertyBagPropertyDescMetaData> MetaData;
        public FObjectPtr MetaClass;
        public List<FPropertyBagPropertyDescMetaData> TempMetaData;
        public FObjectPtr TempMetaClass;
        public FPropertyBagContainerTypes ContainerTypes;

        [Location("FArchive& operator<<(FArchive& Ar, FPropertyBagPropertyDesc& Bag)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ValueTypeObject);
            transfer.Move(ref ID);
            transfer.Move(ref Name);
            transfer.MoveEnum(ref ValueType);
            if (transfer.Supports.ContainerTypes)
            {
                if (!transfer.Supports.NestedContainerTypes)
                {
                    transfer.MoveEnum(ref TmpContainerType);
                }
                else
                {
                    transfer.Move(ref ContainerTypes);
                }
            }
            transfer.Move(ref bHasMetaData);
            if (bHasMetaData)
            {
                transfer.Move(ref MetaData);
                if (transfer.Supports.MetaClass)
                {
                    transfer.Move(ref MetaClass);
                }
            }
            return this;
        }
    }

    public class FPropertyBagContainerTypes : ITransferable
    {
        public uint8 NumContainers;
        [Description("EPropertyBagContainerType")] public EPropertyBagContainerType[] Types;

        [Location("void FPropertyBagContainerTypes::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NumContainers);
            transfer.MoveEnum(ref Types, NumContainers);
            return this;
        }
    }

    [DebuggerDisplay("Key={Key} Value={Value}")]
    public class FPropertyBagPropertyDescMetaData : ITransferable
    {
        public FName Key;
        public FString Value;

        [Location("void FPropertyBagPropertyDescMetaData::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
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