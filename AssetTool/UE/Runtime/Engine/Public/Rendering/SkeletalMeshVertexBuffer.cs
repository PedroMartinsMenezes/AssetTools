namespace AssetTool
{
    public class FDummySkeletalMeshVertexBuffer : ITransferible
    {
        public FStripDataFlags StripFlags = new();
        public UInt32 NumTexCoords;
        public FBool bUseFullPrecisionUVs;
        public FBool bBackCompatExtraBoneInfluences;
        public FVector Dummy;
        public Int32 ElementSize;
        public Int32 ArrayNum;
        public List<byte> DummyBytes;
        public FSkeletalMeshVertexDataInterface VertexData;

        public ITransferible Move(Transfer transfer)
        {
            StripFlags.Move(transfer);
            transfer.Move(ref NumTexCoords);
            transfer.Move(ref bUseFullPrecisionUVs);
            if (!Supports.UseSeparateSkinWeightBuffer)
            {
                transfer.Move(ref bBackCompatExtraBoneInfluences);
            }
            transfer.Move(ref Dummy);
            if (!StripFlags.IsDataStrippedForServer())
            {
                if (!Supports.UseSeparateSkinWeightBuffer)
                {
                    transfer.Move(ref ElementSize);
                    transfer.Move(ref ArrayNum);
                    transfer.Move(ref DummyBytes);
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
