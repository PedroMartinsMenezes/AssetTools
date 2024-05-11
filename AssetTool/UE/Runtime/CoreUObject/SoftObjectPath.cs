using System.ComponentModel;

namespace AssetTool
{
    [Location("FArchive& FLinkerLoad::operator<<(FSoftObjectPath& Value)")]
    [Description("void FSoftObjectPath::SerializePath(FArchive& Ar)")]
    public class FSoftObjectPath
    {
        public const string StructName = "SoftObjectPath";

        public bool bSerializeInternals;

        [Check(false)] public int Value;

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
            if (GlobalObjects.SoftObjectPathList.Count == 0)
            {
                SerializePathWithoutFixup(reader);
                reader.Read(ref SubPathString);
            }
            else
            {
                Value = reader.ReadInt32();
            }
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            if (GlobalObjects.SoftObjectPathList.Count == 0)
            {
                SerializePathWithoutFixup(writer);
                writer.Write(SubPathString);
            }
            else
            {
                writer.Write(ref Value);
            }
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
