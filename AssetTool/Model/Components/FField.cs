namespace AssetTool
{
    public class FField
    {
        public FName NamePrivate = new();
        public UInt32 FlagsPrivate;
        public Dictionary<FName, FString> MetaDataMap = new();
    }

    public static class FFieldExt
    {
        public static void Write(this BinaryWriter writer, FField item)
        {
            writer.Write(item.NamePrivate); //3005..3013
        }

        public static FField Read(this BinaryReader reader, FField item)
        {
            reader.Read(item.NamePrivate); //3005..3013 | 3088..3096
            reader.Read(ref item.FlagsPrivate); //3013..3017 | 3096..3100

            FBool bHasMetaData = new();
            reader.Read(ref bHasMetaData); //3017..3021 | 3100..3104

            if (bHasMetaData.Value)
            {
                int size = reader.ReadInt32(); //3021..3025 (2) | 3104..3108 (3)
                Enumerable.Range(0, size).ToList().ForEach(x => item.MetaDataMap.Add(new(), new()));
                foreach (var pair in item.MetaDataMap)
                {
                    reader.Read(pair.Key);      //3025..3033 "DisplayName"      - 3041..3049 "Tooltip"
                    reader.Read(pair.Value);    //3033..3037..3040..3041 "Rua"  - 3049..3053 ""


                }
                //3053 | 3153 | 
            }
            //Volta para o FProperty

            return item;
        }
    }
}
