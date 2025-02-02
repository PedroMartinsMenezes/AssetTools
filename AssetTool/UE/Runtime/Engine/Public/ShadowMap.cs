namespace AssetTool
{
    public enum ShadowMapType
    {
        SMT_None = 0,
        SMT_2D = 2
    }

    public class FShadowMap : ITransferible
    {
        public ShadowMapType ShadowMapType;
        public FShadowMap2D R;
        public List<FGuid> LightGuids;

        [Location("FArchive& operator<<(FArchive& Ar,FShadowMap*& R)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            ShadowMapType = (ShadowMapType)transfer.Move((UInt32)ShadowMapType);
            if (ShadowMapType == ShadowMapType.SMT_2D)
            {
                R ??= new FShadowMap2D();
                R.Serialize(transfer);
            }
            return this;
        }

        public virtual ITransferible Serialize(Transfer transfer)
        {
            transfer.Move(ref LightGuids);
            return this;
        }
    }

    public class FShadowMap2D : FShadowMap
    {
        public UInt32 Texture;
        public FVector2D CoordinateScale;
        public FVector2D CoordinateBias;
        public FBool[] bChannelValid;
        public FVector4f InvUniformPenumbraSize;

        [Location("void FShadowMap2D::Serialize(FArchive& Ar)")]
        public override ITransferible Serialize(Transfer transfer)
        {
            base.Serialize(transfer);
            transfer.Move(ref Texture);
            transfer.Move(ref CoordinateScale);
            transfer.Move(ref CoordinateBias);
            transfer.Move(ref bChannelValid, 4);
            if (Supports.VER_UE4_STATIC_SHADOWMAP_PENUMBRA_SIZE)
            {
                transfer.Move(ref InvUniformPenumbraSize);
            }
            return this;
        }
    }
}
