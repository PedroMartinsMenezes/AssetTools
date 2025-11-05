namespace AssetTool
{
    [JsonAsset("DebugDrawComponent")]
    public class UDebugDrawComponent : UPrimitiveComponent
    {
        public FSphere BoundingSphere;
        public float MinDistance;
        public float MaxDistance;
        public float TexelFactor;

        [Location("FArchive& operator<<( FArchive& Ar, FStreamableTextureInstance& TextureInstance )")]
        public override ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_STREAMABLE_TEXTURE_AABB)
            {
                transfer.Move(ref Bounds);
            }
            else
            {
                transfer.Move(ref BoundingSphere);
            }

            if (transfer.Supports.VER_UE4_STREAMABLE_TEXTURE_MIN_MAX_DISTANCE)
            {
                transfer.Move(ref MinDistance);
                transfer.Move(ref MaxDistance);
            }

            transfer.Move(ref TexelFactor);

            return this;
        }
    }
}
