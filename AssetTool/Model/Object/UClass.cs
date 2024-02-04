namespace AssetTool
{
    [Location("void UClass::Serialize( FArchive& Ar )")]
    public class UClass : UStruct
    {
        public TMap1<FName, UInt32> FuncMap = new();
        public UInt32 ClassFlags;
        public UInt32 ClassWithin;
        public FName ClassConfigName = new();
        public UInt32 ClassGeneratedBy;
        [Sized] public List<FImplementedInterface> SerializedInterfaces = new();
        public FBool bDeprecatedForceScriptOrder = new();
        public FName Dummy = new();
        public FBool bCookedAsBool = new();
        public UInt32 PerspectiveNewCDO;
    }

    public static class UClassExt
    {
        public static void Write(this BinaryWriter writer, UClass item)
        {
            writer.Write((UStruct)item);
        }

        public static UClass Read(this BinaryReader reader, UClass item)
        {
            reader.Read((UStruct)item);//68364..68730
            reader.ReadValue(item.FuncMap);//68730..68806

            reader.Read(ref item.ClassFlags); //68806..68810
            reader.Read(ref item.ClassWithin); //68810..68814
            reader.Read(item.ClassConfigName); //68814..68822
            reader.Read(ref item.ClassGeneratedBy); //68822..68826
            reader.ReadList(item.SerializedInterfaces); //68826..68830
            reader.Read(ref item.bDeprecatedForceScriptOrder); //68830..68834
            reader.Read(item.Dummy); //68834..68842
            reader.Read(ref item.bCookedAsBool); //68842..68846
            reader.Read(ref item.PerspectiveNewCDO); //68846..68850

            return item;
        }
    }
}
