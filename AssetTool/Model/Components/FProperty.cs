namespace AssetTool
{
    public class FProperty : FField
    {
        public Int32 ArrayDim;
        public Int32 ElementSize;
        public UInt64 PropertyFlags;
        public UInt16 RepIndex;
        public FName RepNotifyFunc = new();
        public byte BlueprintReplicationCondition;
    }

    public static class FPropertyExt
    {
        public static void Write(this BinaryWriter writer, FProperty item)
        {
            writer.Write(item.ArrayDim);
            writer.Write(item.ElementSize);
            writer.Write(item.PropertyFlags);
            writer.Write(item.RepIndex);
        }

        public static void Read(this BinaryReader reader, List<FProperty> item)
        {
            int size = reader.ReadInt32(); //2993..2997 size = 6
            for (int i = 0; i < size; i++)
            {
                item.Add(reader.Read(new FProperty()));
                //[0] 2997..3080
                //[1] 3080..3180
                //[2] 3180..3277
                //[3] 3277..3363
                //[4] 3363..3445
                //[5] 3445..3536
            }
            //3536
        }

        public static FProperty Read(this BinaryReader reader, FProperty item)
        {
            FName PropertyTypeName = new();
            reader.Read(PropertyTypeName); //2997..3005 | 3080..3088

            //Vai para o FField //3005..3053
            reader.Read((FField)item);

            reader.Read(ref item.ArrayDim); //3053..3057
            reader.Read(ref item.ElementSize); //3057..3061
            reader.Read(ref item.PropertyFlags); //3061..3069
            reader.Read(ref item.RepIndex); //3069..3071
            reader.Read(item.RepNotifyFunc); //3071..3079
            reader.Read(ref item.BlueprintReplicationCondition); //3079..3080

            return item;
        }
    }
}
