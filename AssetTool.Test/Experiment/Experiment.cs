using AssetTool.Writer;
using System.Text;

namespace AssetTool.Test.Experiment
{
    public class StructTestExperiment
    {
        //add to StructAssetExt class
        public void ReadNameMap()
        {
            int offset = 406;
            int count = 64;
            var path = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                int size = reader.ReadInt32();
                byte[] bytes = new byte[size - 1];
                reader.Read(bytes, 0, size - 1);
                string text = Encoding.ASCII.GetString(bytes);
                byte zero = reader.ReadByte();
                UInt16 a = reader.ReadUInt16();
                UInt16 b = reader.ReadUInt16();

                string line = $"list.Add(\"{text}\", {a}, {b});";

                builder.AppendLine(line);
            }

            Assert.True(builder.Length > 0);
        }
    }
}