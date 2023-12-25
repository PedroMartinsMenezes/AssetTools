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
                Write(Sum.CustomVersionContainer.VersionCount);
                Write(Sum.CustomVersionContainer.Versions);
                Write(Sum.TotalHeaderSize);
                Write(Sum.PackageNameSize);
                Write(Sum.PackageName);
                Write(Sum.PackageFlags);
                Write(Sum.NameCount);
                Write(Sum.NameOffset);
                Write(Sum.SoftObjectPathsCount);
                Write(Sum.SoftObjectPathsOffset);
                Write(Sum.LocalizationIdSize);
                Write(Sum.LocalizationId);
                Write(Sum.GatherableTextDataCount);
                Write(Sum.GatherableTextDataOffset);
                Write(Sum.ExportCount);
                Write(Sum.ExportOffset);
                Write(Sum.ImportCount);
                Write(Sum.ImportOffset);
                Write(Sum.DependsOffset);
                Write(Sum.SoftPackageReferencesCount);
                Write(Sum.SoftPackageReferencesOffset);
                Write(Sum.SearchableNamesOffset);
                Write(Sum.ThumbnailTableOffset);
                Write(Sum.Guid);
                Write(Sum.PersistentGuid);
                Write(Sum.GenerationCount);
                Write(Sum.Generations);
                Write(Sum.SavedByEngineVersion);
                Write(Sum.CompatibleWithEngineVersion);
                Write(Sum.CompressionFlags);
                Write(Sum.CompressedChunkSize);
                Write(Sum.PackageSource);
                Write(Sum.AdditionalPackagesToCookSize);
            }
            finally
            {
                if (writer is { })
                    writer.Close();
            }
        }

        #region
        private void Write(char value) => writer.Write(value);
        private void Write(byte value) => writer.Write(value);
        private void Write(Int16 value) => writer.Write(value);
        private void Write(UInt16 value) => writer.Write(value);
        private void Write(Int32 value) => writer.Write(value);
        private void Write(UInt32 value) => writer.Write(value);
        private void Write(Int64 value) => writer.Write(value);
        private void Write(UInt64 value) => writer.Write(value);

        private void Write(string value)
        {
            if (value.Length > 0)
            {
                writer.Write(Encoding.ASCII.GetBytes(value));
                writer.Write((byte)0);
            }
        }

        private void Write(Guid value)
        {
            var bytes = value.ToByteArray();
            writer.Write(bytes[00..04]);
            writer.Write(new byte[] { bytes[06], bytes[07], bytes[04], bytes[05] });
            writer.Write(bytes[08..12].Reverse().ToArray());
            writer.Write(bytes[12..16].Reverse().ToArray());
        }

        private void Write(List<FCustomVersion> list)
        {
            list.ForEach(item =>
            {
                Write(item.Key);
                Write(item.Version);
            });
        }

        private void Write(List<FGenerationInfo> list)
        {
            list.ForEach(item =>
            {
                Write(item.ExportCount);
                Write(item.NameCount);
            });
        }
        #endregion

        private void Write(FEngineVersion obj)
        {
            Write(obj.Major);
            Write(obj.Minor);
            Write(obj.Patch);
            Write(obj.Changelist);
            Write(obj.BranchSize);
            Write(obj.Branch);
        }
    }
}
