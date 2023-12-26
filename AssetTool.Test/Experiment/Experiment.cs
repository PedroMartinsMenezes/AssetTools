using AssetTool.Service;
using System.Text;

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
                //TODo
                return "";
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