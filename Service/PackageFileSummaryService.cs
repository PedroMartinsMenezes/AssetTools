using AssetTool.Model;
using System.Text;

namespace AssetTool.Service
{
    public class PackageFileSummaryService
    {
        BinaryWriter writer;

        public void Save(string path, FPackageFileSummary Sum)
        {
            try
            {
                writer = new BinaryWriter(File.Open(path, FileMode.Create));

                Write(Sum.Tag);
                Write(Sum.LegacyFileVersion);
                Write(Sum.LegacyUE3Version);
                Write(Sum.FileVersionUE.FileVersionUE4);
                Write(Sum.FileVersionUE.FileVersionUE5);
                Write(Sum.FileVersionLicenseeUE);
                Write(Sum.CustomVersionContainer);
                Write(Sum.TotalHeaderSize);
                Write(Sum.PackageName);
            }
            finally
            {
                if (writer is { })
                    writer.Close();
            }
        }

        private void Write(string value)
        {
            writer.Write(new byte[] { 0x15, 0x00, 0x00, 0x00 });

            var bytes = Encoding.ASCII.GetBytes(value);
            writer.Write(bytes);
        }

        private void Write(Guid value)
        {
            var bytes = value.ToByteArray();
            writer.Write(bytes[00]);
            writer.Write(bytes[01]);
            writer.Write(bytes[02]);
            writer.Write(bytes[03]);

            writer.Write(bytes[06]);
            writer.Write(bytes[07]);
            writer.Write(bytes[04]);
            writer.Write(bytes[05]);

            writer.Write(bytes[11]);
            writer.Write(bytes[10]);
            writer.Write(bytes[09]);
            writer.Write(bytes[08]);

            writer.Write(bytes[15]);
            writer.Write(bytes[14]);
            writer.Write(bytes[13]);
            writer.Write(bytes[12]);
        }

        private void Write(Int32 value)
        {
            writer.Write(BitConverter.GetBytes(value));
        }

        private void Write(FCustomVersionContainer obj)
        {
            Write(obj.Versions.Count);
            foreach (var item in obj.Versions)
            {
                Write(item.Key);
                Write(item.Version);
            }
        }
    }
}
