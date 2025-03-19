namespace AssetTool
{
    public class FDummySkeletalMeshVertexBuffer : ITransferible
    {
        public FStripDataFlags StripFlags = new();
        public UInt32 NumTexCoords;
        public FBool bUseFullPrecisionUVs;
        public FBool bBackCompatExtraBoneInfluences;
        public FVector Dummy1;
        public FVector Dummy2;
        public Int32 ElementSize;
        public Int32 ArrayNum;
        public byte[] DummyBytes;
        public FSkeletalMeshVertexDataInterface VertexData;

        [Location("FArchive& operator<<(FArchive& Ar, FDummySkeletalMeshVertexBuffer& VertexBuffer)")]
        public ITransferible Move(Transfer transfer)
        {
            StripFlags.Move(transfer);
            transfer.Move(ref NumTexCoords);
            transfer.Move(ref bUseFullPrecisionUVs);
            if (Supports.VER_UE4_SUPPORT_GPUSKINNING_8_BONE_INFLUENCES && !Supports.UseSeparateSkinWeightBuffer)
            {
                transfer.Move(ref bBackCompatExtraBoneInfluences);
            }
            transfer.Move(ref Dummy1);
            transfer.Move(ref Dummy2);
            if (!StripFlags.IsDataStrippedForServer())
            {
                if (!Supports.UseSeparateSkinWeightBuffer)
                {
                    transfer.Move(ref ElementSize);
                    transfer.Move(ref ArrayNum);
                    transfer.Move(ref DummyBytes, ElementSize * ArrayNum);
                }
                else
                {
                    transfer.Move(ref VertexData);
                }
            }
            return this;
        }
    }

    public class FSkeletalMeshVertexDataInterface : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
