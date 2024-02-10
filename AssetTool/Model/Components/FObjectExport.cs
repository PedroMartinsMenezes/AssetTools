namespace AssetTool
{
    //[3] 2320 .. 2608
    public class FObjectExport
    {
        public FPackageIndex ClassIndex;
        public FPackageIndex SuperIndex;
        public FPackageIndex TemplateIndex;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public UInt32 ObjectFlags;
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        public FBool bIsInheritedInstance;
        public UInt32 PackageFlags;
        public FBool bNotAlwaysLoadedForEditorGame;
        public FBool bIsAsset;
        public FBool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int32 SerializationBeforeSerializationDependencies;
        public Int32 CreateBeforeSerializationDependencies;
        public Int32 SerializationBeforeCreateDependencies;
        public Int32 CreateBeforeCreateDependencies;
    }

    //public class FObjectExportJsonConverter : JsonConverter<FObjectExport>
    //{
    //    public override FObjectExport Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        var v = reader.GetString()!.Split(' ');
    //        var obj = new FObjectExport()
    //        {
    //            ClassIndex = new FPackageIndex(v[22]),
    //            SuperIndex = new FPackageIndex(v[23]),
    //            TemplateIndex = new FPackageIndex(v[24]),
    //            OuterIndex = new FPackageIndex(v[25]),
    //            ObjectName = new FName(v[26]),
    //            ObjectFlags = UInt32.Parse(v[27]),
    //            SerialSize = Int64.Parse(v[28]),
    //            SerialOffset = Int64.Parse(v[29]),
    //            bForcedExport = new FBool(v[30]),
    //            bNotForClient = new FBool(v[31]),
    //            bNotForServer = new FBool(v[32]),
    //            bIsInheritedInstance = new FBool(v[33]),
    //            PackageFlags = UInt32.Parse(v[34]),
    //            bNotAlwaysLoadedForEditorGame = new FBool(v[35]),
    //            bIsAsset = new FBool(v[36]),
    //            bGeneratePublicHash = new FBool(v[37]),
    //            FirstExportDependency = Int32.Parse(v[38]),
    //            SerializationBeforeSerializationDependencies = Int32.Parse(v[39]),
    //            CreateBeforeSerializationDependencies = Int32.Parse(v[40]),
    //            SerializationBeforeCreateDependencies = Int32.Parse(v[41]),
    //            CreateBeforeCreateDependencies = Int32.Parse(v[42]),
    //        };
    //        return obj;
    //    }

    //    public override void Write(Utf8JsonWriter writer, FObjectExport value, JsonSerializerOptions options)
    //    {
    //        string k = $"ClassIndex SuperIndex TemplateIndex OuterIndex ObjectName ObjectFlags SerialSize SerialOffset bForcedExport bNotForClient bNotForServer bIsInheritedInstance PackageFlags bNotAlwaysLoadedForEditorGame bIsAsset bGeneratePublicHash FirstExportDependency SerializationBeforeSerializationDependencies CreateBeforeSerializationDependencies SerializationBeforeCreateDependencies CreateBeforeCreateDependencies";
    //        string v = $"{value.ClassIndex} {value.SuperIndex} {value.TemplateIndex} {value.OuterIndex} {value.ObjectName} {value.ObjectFlags} {value.SerialSize} {value.SerialOffset} {value.bForcedExport} {value.bNotForClient} {value.bNotForServer} {value.bIsInheritedInstance} {value.PackageFlags} {value.bNotAlwaysLoadedForEditorGame} {value.bIsAsset} {value.bGeneratePublicHash} {value.FirstExportDependency} {value.SerializationBeforeSerializationDependencies} {value.CreateBeforeSerializationDependencies} {value.SerializationBeforeCreateDependencies} {value.CreateBeforeCreateDependencies}";
    //        writer.WriteStringValue($"{k} = {v}");
    //    }
    //}
}
