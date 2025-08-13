namespace AssetTool
{
    [TransferibleStruct("ClothTetherData")]
    public class FClothTetherData : ITransferible
    {
        public UScriptStruct Struct = new();
        public List<List<Tether>> Tethers;

        [Location("bool FClothTetherData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            transfer.Move(ref Tethers);
            return this;
        }

        public class Tether : ITransferible
        {
            public int32 start;
            public int32 end;
            public float length;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref start);
                transfer.Move(ref end);
                transfer.Move(ref length);
                return this;
            }
        }
    }
}
