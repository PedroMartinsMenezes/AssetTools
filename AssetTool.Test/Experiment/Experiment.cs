using AssetTool.Model.Basic;
using AssetTool.Service;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AssetTool.Test.Experiment
{
    public class StructTestExperiment
    {
        [Fact]
        public void Read_NameMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/NameMap.txt");
            string actual = ReadAssetFile(406, 64, reader =>
            {
                string text = reader.ReadFString();
                UInt16 a = reader.ReadUInt16();
                UInt16 b = reader.ReadUInt16();
                string line = $"list.Add(\"{text}\", {a}, {b});";
                return line;
            });
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_ImportMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/ImportMap.txt");
            string actual = ReadAssetFile(2060, 6, reader =>
            {
                (UInt32 a1, UInt32 a2, UInt32 a3) = (reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
                (UInt32 b1, UInt32 b2, UInt32 b3) = (reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
                (UInt32 c1, UInt32 c2, UInt32 c3) = (reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
                Int32 d = reader.ReadInt32();
                string line = $"list.Add(new FObjectImport(new FName({a1},{a2},{a3}), new FName({b1},{b2},{b3}), new FName({c1},{c2},{c3}), {d}));";
                return line;
            });
            Assert.Equal(expected, actual);
        }

        private string ReadAssetFile(int offset, int count, Func<BinaryReader, string> callback)
        {
            var path = "Data/S_Endereco.uasset";

            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string line = callback(reader);
                builder.AppendLine(line);
            }

            return builder.ToString();
        }
    }
}