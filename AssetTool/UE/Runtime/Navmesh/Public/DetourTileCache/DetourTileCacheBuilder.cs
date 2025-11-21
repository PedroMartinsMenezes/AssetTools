namespace AssetTool
{
    public class dtTileCacheLayerHeader
    {
        public int32 CompressedDataSizeNoHeader;
        public short version;
        public int tx, ty, tlayer;
        public ushort hmin, hmax;
        public ushort width, height;
        public ushort minx, maxx, miny, maxy;
        public double[] bmin = [0, 0, 0], bmax = [0, 0, 0];
        public byte[] CompressedData;

        [Location("void FPImplRecastNavMesh::SerializeCompressedTileCacheData(FArchive& Ar, int32 NavMeshVersion, unsigned char*& CompressedData, int32& CompressedDataSize)")]
        public void SerializeCompressedTileCacheData(Transfer transfer)
        {
            transfer.Move(ref CompressedDataSizeNoHeader);

            bool bHasHeader = CompressedDataSizeNoHeader >= 0;
            if (!bHasHeader)
            {
                return;
            }

            transfer.Move(ref version);
            transfer.Move(ref tx);
            transfer.Move(ref ty);
            transfer.Move(ref tlayer);
            for (int i = 0; i < 3; ++i)
            {
                transfer.Move(ref bmin[i]);
                transfer.Move(ref bmax[i]);
            }
            transfer.Move(ref hmin);
            transfer.Move(ref hmax);
            transfer.Move(ref width);
            transfer.Move(ref height);
            transfer.Move(ref minx);
            transfer.Move(ref maxx);
            transfer.Move(ref miny);
            transfer.Move(ref maxy);
            transfer.Move(ref CompressedData, CompressedDataSizeNoHeader);
        }
    }
}
