using System.Diagnostics;

namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();
        public List<AssetObject> Objects = new();
        public StructFooter Footer = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.Header); //28680 OK

            //ler o conteudo entre 28680 e 69226
            //investigar o AssetRegistryDataOffset

            item.Objects = item.Objects.OrderBy(x => x.Offset).ToList();
            foreach (var obj in item.Objects)
            {
                writer.BaseStream.Position = obj.Offset; //69226..69271
                writer.WriteAssetObject(obj.Type, obj);
            }

            writer.Write(item.Footer);
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);
            SetupObjects(item);
            PrintTypes(item);

            //Remove OK
            //var obj = item.Objects.First(x => x.Offset == 68364);
            //reader.BaseStream.Position = obj.Offset;
            //reader.ReadAssetObject(obj.Type, obj);
            //Debug.Assert((obj.Offset + obj.Size) == reader.BaseStream.Position);

            foreach (AssetObject obj in item.Objects)
            {
                reader.BaseStream.Position = obj.Offset;
                reader.ReadAssetObject(obj.Type, obj);
                Debug.Assert((obj.Offset + obj.Size) == reader.BaseStream.Position);
            }

            reader.Read(item.Footer);
        }

        private static void SetupObjects(StructAsset item)
        {
            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                Type = x.ClassIndex.Index < 0 ?
                    item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value :
                    item.Header.ExportMap[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .OrderBy(x => x.Offset)
            .ToList();
        }

        private static void PrintTypes(StructAsset item)
        {
            item.Objects.Select(x => x.Type).Distinct().ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
