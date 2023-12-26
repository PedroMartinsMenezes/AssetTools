using AssetTool.Model;

namespace AssetTool.Service
{
    public static class ObjectImportExt
    {
        public static void Write(this BinaryWriter writer, List<FObjectImport> list)
        {
            list.ForEach(item => writer.Write(item));
        }

        public static void Write(this BinaryWriter writer, FObjectImport item)
        {
            writer.Write(item.A);
            writer.Write(item.B);
            writer.Write(item.C);
            writer.Write(item.D.Index);
        }

        //public static void Add(this List<FObjectImport> list, 
        //    UInt32 a1, UInt32 a2, UInt32 a3, 
        //    UInt32 b1, UInt32 b2, UInt32 b3, 
        //    Int32 c, 
        //    UInt32 d1, UInt32 d2, UInt32 d3)
        //{
        //    list.Add(new() 
        //    { 
        //        ClassPackage = new(a1, a2, a3),
        //        ClassName = new(b1, b2, b3),
        //        OuterIndex = new FPackageIndex { Index = c },
        //        ObjectName = new(d1, d2, d3),
        //    });
        //}
    }
}
