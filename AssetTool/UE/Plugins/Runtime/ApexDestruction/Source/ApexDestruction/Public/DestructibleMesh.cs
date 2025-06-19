namespace AssetTool
{
    [JsonAsset("DestructibleMesh")]
    public class UDestructibleMesh : USkeletalMesh
    {
        public uint8[] NameBuffer;
        public uint8[] TempBuffer;
        public uint8[] Buffer;

        [Location("void UDestructibleMesh::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref NameBuffer);
            transfer.Move(ref TempBuffer);
            if (transfer.Supports.CacheDestructibleOverlaps)
            {
                transfer.Move(ref Buffer);
            }
            return this;
        }
    }
}