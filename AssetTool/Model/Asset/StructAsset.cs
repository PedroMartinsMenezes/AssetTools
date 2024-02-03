using System.Diagnostics;

namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();

        public PadData PadData = new();

        public List<AssetObject> Objects = new();

        public StructFooter Footer = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            try
            {
                writer.Write(item.Header); //28680 OK

                writer.Write(item.PadData);


                //ler o conteudo entre 28680 e 69226
                //investigar o AssetRegistryDataOffset

                item.Objects = item.Objects.OrderBy(x => x.Offset).ToList();
                foreach (var obj in item.Objects)
                {
                    Console.WriteLine($"Writing {obj.Type}");
                    writer.BaseStream.Position = obj.Offset; //69226..69271
                    writer.WriteAssetObject(obj.Type, obj);
                }

                //writer.Write(item.Footer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            try
            {
                reader.Read(item.Header);

                SetupObjects(item);
                PrintTypes(item);

                long pos = reader.BaseStream.Position;
                reader.Read(item.PadData, reader.BaseStream.Position, item.Objects.Min(x => x.Offset));
                reader.BaseStream.Position = pos;

                foreach (AssetObject obj in item.Objects)
                {
                    Console.WriteLine($"{obj.Offset} - {obj.NextOffset}: {obj.Type}");
                    reader.BaseStream.Position = obj.Offset;
                    reader.ReadAssetObject(obj.Type, obj);
                    if (obj.NextOffset != reader.BaseStream.Position)
                    {
                        Console.WriteLine($"Wrong size. Expected {obj.NextOffset}. Actual {reader.BaseStream.Position}");
                        break;
                    }
                }

                //reader.Read(item.Footer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
            Console.WriteLine("Objects:");
            item.Objects.Select(x => x.Type).Distinct().ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("");
            Console.WriteLine("Reading:");
        }
    }
}
