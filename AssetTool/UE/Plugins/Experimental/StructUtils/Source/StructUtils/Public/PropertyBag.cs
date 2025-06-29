using System.ComponentModel;
using System.Diagnostics;

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
        public virtual ITransferible Move(Transfer transfer)
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

    public class FPropertyBagPropertyDesc : ITransferible
    {
        public UInt32 ValueTypeObject;
        public FGuid ID;
        public FName Name;
        public EPropertyBagPropertyType ValueType;
        public EPropertyBagContainerType TmpContainerType;
        public FBool bHasMetaData;
        public List<FPropertyBagPropertyDescMetaData> MetaData;
        public UInt32 MetaClass; //TObjectPtr<class UClass>
        public List<FPropertyBagPropertyDescMetaData> TempMetaData;
        public UInt32 TempMetaClass; //TObjectPtr<UClass>
        public FPropertyBagContainerTypes ContainerTypes;

        [Location("static FArchive& operator<<(FArchive& Ar, FPropertyBagPropertyDesc& Bag)")]
        public ITransferible Move(Transfer transfer)
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

    public class FPropertyBagContainerTypes : ITransferible
    {
        public uint8 NumContainers;
        [Description("EPropertyBagContainerType")] public uint8[] Types;

        [Location("void FPropertyBagContainerTypes::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumContainers);
            transfer.Move(ref Types, NumContainers);
            return this;
        }
    }

    [DebuggerDisplay("Key={Key} Value={Value}")]
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