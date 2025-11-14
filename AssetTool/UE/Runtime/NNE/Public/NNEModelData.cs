namespace AssetTool.UE.NNE.ModelData
{
    [JsonAsset("NNEModelData")]
    public class UNNEModelData : UObject
    {
        private Guid guid = new Guid("9513202e-eba1-b279-f17f-e5baab90c3f2");

        public FString FileType;
        public uint8[] Data_Size32Bits;
        public FGuid FileId;
        public List<FString> TargetRuntimes;
        public TArray64Byte FileData;
        public List<ItemV0> ItemsV0;
        public List<ItemV1> ItemsV1;
        public List<ItemV2> ItemsV2;
        public List<ItemV3> ItemsV3;
        public List<ItemV3Extra> ItemsV3Extra;
        public List<ItemV4> ItemsV4;
        public List<ItemV4Extra> ItemsV4Extra;

        [Location("void UNNEModelData::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            Version v = (Version)transfer.GlobalObjects.CustomVer(guid);
            switch (v)
            {
                case Version.V0:
                    transfer.Move(ref FileType);
                    transfer.Move(ref Data_Size32Bits);
                    transfer.Move(ref FileId);
                    transfer.Move(ref ItemsV0);
                    break;
                case Version.V1:
                    transfer.Move(ref FileType);
                    transfer.Move(ref Data_Size32Bits);
                    transfer.Move(ref FileId);
                    transfer.Move(ref ItemsV1);
                    break;
                case Version.V2:
                    transfer.Move(ref TargetRuntimes);
                    transfer.Move(ref FileType);
                    transfer.Move(ref Data_Size32Bits);
                    transfer.Move(ref FileId);
                    transfer.Move(ref ItemsV2);
                    break;
                case Version.V3:
                    transfer.Move(ref TargetRuntimes);
                    transfer.Move(ref FileType);
                    transfer.Move(ref Data_Size32Bits);
                    transfer.Move(ref ItemsV3);
                    transfer.Move(ref FileId);
                    transfer.Move(ref ItemsV3Extra);
                    break;
                case Version.V4:
                    transfer.Move(ref TargetRuntimes);
                    transfer.Move(ref FileType);
                    transfer.Move(ref FileData);
                    transfer.Move(ref ItemsV4);
                    transfer.Move(ref FileId);
                    transfer.Move(ref ItemsV4Extra);
                    break;
            }

            return this;
        }

        public class ItemV0 : ITransferable
        {
            public FString Name;
            public byte[] Data_Size32Bits;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref Data_Size32Bits);
                return this;
            }
        }

        public class ItemV1 : ITransferable
        {
            public FString Name;
            public byte[] Data_Size32Bits;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref Data_Size32Bits);
                return this;
            }
        }

        public class ItemV2 : ITransferable
        {
            public FString Name;
            public uint32 MemoryAlignment;
            public uint64 DataSize;
            public byte[] RawData;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref MemoryAlignment);
                transfer.Move(ref DataSize);
                transfer.Move(ref RawData, (int)DataSize);
                return this;
            }
        }

        public class ItemV3 : ITransferable
        {
            public FString Name;
            public byte[] Data_Size32Bits;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref Data_Size32Bits);
                return this;
            }
        }

        public class ItemV3Extra : ITransferable
        {
            public FString Name;
            public uint32 MemoryAlignment;
            public uint64 DataSize;
            public byte[] RawData;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref MemoryAlignment);
                transfer.Move(ref DataSize);
                transfer.Move(ref RawData, (int)DataSize);
                return this;
            }
        }

        public class ItemV4 : ITransferable
        {
            public FString Name;
            public TArray64Byte Data;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref Data);
                return this;
            }
        }

        public class ItemV4Extra : ITransferable
        {
            public FString Name;
            public uint32 MemoryAlignment;
            public uint64 DataSize;
            public byte[] RawData;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref MemoryAlignment);
                transfer.Move(ref DataSize);
                transfer.Move(ref RawData, (int)DataSize);
                return this;
            }
        }

        public enum Version : uint32
        {
            V0 = 0,
            V1 = 1,
            V2 = 2,
            V3 = 3,
            V4 = 4,
            VersionPlusOne,
            Latest = VersionPlusOne - 1
        };
    }
}