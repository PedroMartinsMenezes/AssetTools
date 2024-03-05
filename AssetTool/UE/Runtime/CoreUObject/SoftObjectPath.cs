using System.ComponentModel;

namespace AssetTool
{
    [Location("FArchive& FLinkerLoad::operator<<(FSoftObjectPath& Value)")]
    [Description("void FSoftObjectPath::SerializePath(FArchive& Ar)")]
    public class FSoftObjectPath
    {
        public const string StructName = "SoftObjectPath";

        public bool bSerializeInternals;

        #region
        public FTopLevelAssetPath AssetPath;
        public FString SubPathString;
        #endregion

        #region SerializePathWithoutFixup
        [Check("CheckSerializeInternals")]
        public FName AssetPathName;
        #endregion

        public FSoftObjectPath() { }

        public FSoftObjectPath(bool bSerializeInternals) { this.bSerializeInternals = bSerializeInternals; }

        public FSoftObjectPath Read(BinaryReader reader)
        {
            SerializePathWithoutFixup(reader);
            reader.Read(ref SubPathString);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            SerializePathWithoutFixup(writer);
            writer.Write(SubPathString);
        }

        private void SerializePathWithoutFixup(BinaryReader reader)
        {
            reader.Read(ref AssetPathName);
        }

        private void SerializePathWithoutFixup(BinaryWriter writer)
        {
            writer.Write(AssetPathName);
        }

        public bool CheckSerializeInternals() => bSerializeInternals;
    }

    public class FSoftClassPath : FSoftObjectPath
    {
    }
}
