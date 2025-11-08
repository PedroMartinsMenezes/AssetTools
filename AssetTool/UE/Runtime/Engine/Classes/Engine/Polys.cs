namespace AssetTool
{
    [JsonAsset("Polys")]
    public class UPolys : UObject
    {
        public int32 DbNum;
        public int32 DbMax;
        public FObjectPtr ElementOwner;
        public List<FPoly> Element;

        [Location("void UPolys::Serialize( FArchive& Ar )")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.VER_UE4_BSP_UNDO_FIX)
            {
                transfer.Move(ref DbNum);
                transfer.Move(ref DbMax);
                transfer.Move(ref ElementOwner);
                transfer.Move(ref Element, DbNum);
            }
            else
            {
                transfer.Move(ref Element);
            }

            return this;
        }
    }

    public struct FPoly : ITransferible
    {
        public FVector3f Base;
        public FVector3f Normal;
        public FVector3f TextureU;
        public FVector3f TextureV;
        public FVector3f[] Vertices;
        public uint32 PolyFlags;
        public UInt32 Actor;
        public FName ItemName;
        public UInt32 Material;
        public int32 iLink;
        public int32 iBrushPoly;
        public float LightMapScale;
        public FLightmassPrimitiveSettings LightmassSettings;
        public FName RulesetVariation;

        [Location("FArchive& operator<<( FArchive& Ar, FPoly& Poly )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Base);
            transfer.Move(ref Normal);
            transfer.Move(ref TextureU);
            transfer.Move(ref TextureV);
            transfer.Move(ref Vertices);
            transfer.Move(ref PolyFlags);
            transfer.Move(ref Actor);
            transfer.Move(ref ItemName);
            transfer.Move(ref Material);
            transfer.Move(ref iLink);
            transfer.Move(ref iBrushPoly);
            transfer.Move(ref LightMapScale);
            transfer.Move(ref LightmassSettings);
            transfer.Move(ref RulesetVariation);
            return this;
        }
    }
}