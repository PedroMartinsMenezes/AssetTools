namespace AssetTool
{
    [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public new const string TypeName = "StaticMeshComponent";

        public List<FStaticMeshComponentLODInfo> LODData = [];

        public new UStaticMeshComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UStaticMeshComponent Read(BinaryReader reader)
        {
            LODData.Resize(reader.ReadInt32());

            LODData.ForEach(x => x.Read(reader));

            return this;
        }
        private UStaticMeshComponent Write(BinaryWriter writer)
        {
            writer.Write(LODData.Count);

            LODData.ForEach(x => FStaticMeshComponentLODInfo.Write(writer));

            return this;
        }
    }
}
