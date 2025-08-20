namespace AssetTool
{
    [JsonAsset("RecastNavMesh")]
    public class ARecastNavMesh : ANavigationData
    {
        public uint32 NavMeshVersion;
        public uint32 RecastNavMeshSizeBytes;
        public byte[] Pad;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref NavMeshVersion);
            transfer.Move(ref RecastNavMeshSizeBytes);
            transfer.Move(ref Pad, (int)(RecastNavMeshSizeBytes - 4));

            return this;
        }
    }
}