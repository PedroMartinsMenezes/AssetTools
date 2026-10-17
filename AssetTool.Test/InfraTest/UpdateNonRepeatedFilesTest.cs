using NUnit.Framework;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTool.Test.InfraTest
{
    [Ignore("Irrelevant")]
    public class UpdateNonRepeatedFilesTest : TestBase
    {
        [Test]
        public void Update_NonRepeated_Files()
        {
            string dir = "C:\\UEFiles";

            FileInfo[] files = GetAssetFiles(dir);

            List<string> nonRepeatedFiles = GetNonRepeatedFiles(files);

            var ue57 = nonRepeatedFiles.Where(f => f.StartsWith("C:\\UEFiles\\UE57")).ToList();

            File.WriteAllLines("C:\\UE\\AssetTools\\AssetTool.Test\\InputFiles\\NonRepeated.txt", nonRepeatedFiles);
        }

        /// <summary>
        /// The .uasset/.umap files, one version folder at a time (UE400..UE427, then UE50..UE57): enumerating the
        /// root as a whole is breadth-first and interleaves the versions. A repeated file is then kept from its
        /// oldest version. FileInfo from the directory enumeration already carries the length (no extra call per file).
        /// </summary>
        public static FileInfo[] GetAssetFiles(string dir)
        {
            return new DirectoryInfo(dir).GetDirectories("UE*")
                .OrderBy(d => VersionKey(d.Name))
                .SelectMany(d => d.EnumerateFiles("*", SearchOption.AllDirectories))
                .Where(f => f.Name.EndsWith(".uasset", StringComparison.OrdinalIgnoreCase) || f.Name.EndsWith(".umap", StringComparison.OrdinalIgnoreCase))
                .ToArray();
        }

        /// <summary>
        /// Keeps the first file (in the given order) of each distinct content.
        /// Files with a unique length cannot be repeated and are never read; only files sharing their length
        /// with another one are hashed (xxHash64, in parallel), and the content key is (length, hash).
        /// </summary>
        public static List<string> GetNonRepeatedFiles(FileInfo[] files)
        {
            var countBySize = new Dictionary<long, int>();
            foreach (FileInfo file in files)
                countBySize[file.Length] = countBySize.GetValueOrDefault(file.Length) + 1;

            ulong[] hashes = new ulong[files.Length];
            Parallel.For(0, files.Length, i =>
            {
                if (countBySize[files[i].Length] > 1)
                    hashes[i] = HashFile(files[i].FullName);
            });

            var seen = new HashSet<(long, ulong)>();
            var nonRepeatedFiles = new List<string>();
            for (int i = 0; i < files.Length; i++)
            {
                if (seen.Add((files[i].Length, hashes[i])))
                    nonRepeatedFiles.Add(files[i].FullName);
            }
            return nonRepeatedFiles;
        }

        /// <summary>"UE427" → (4, 27), "UE57" → (5, 7): the first digit is the major version, the rest the minor.</summary>
        private static (int Major, int Minor) VersionKey(string folderName)
        {
            string digits = folderName[2..];
            return (int.Parse(digits[..1]), int.Parse(digits[1..]));
        }

        private static ulong HashFile(string path)
        {
            const int BufferSize = 1 << 20;
            byte[] buffer = ArrayPool<byte>.Shared.Rent(BufferSize);
            try
            {
                // bufferSize 1 disables the FileStream buffer: reads already go straight into a large buffer
                using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 1, FileOptions.SequentialScan);
                var hash = new K4os.Hash.xxHash.XXH64();
                int read;
                while ((read = stream.Read(buffer, 0, BufferSize)) > 0)
                    hash.Update(buffer.AsSpan(0, read));
                return hash.Digest();
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }
    }
}
