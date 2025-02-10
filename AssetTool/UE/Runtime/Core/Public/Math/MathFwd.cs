global using uint8 = byte;
global using uint16 = ushort;
global using uint32 = uint;
global using uint64 = ulong;
global using int8 = sbyte;
global using int16 = short;
global using int32 = int;
global using int64 = long;

global using FVector = AssetTool.FVector3;
global using FBoxSphereBounds = AssetTool.FBoxSphereBounds3d;
global using FSphere = AssetTool.FSphere3d;

global using FInt32Vector2 = AssetTool.FIntVector2;
global using FInt32Vector3 = AssetTool.FIntVector3;
global using FInt32Vector = AssetTool.FIntVector3;
global using FInt32Vector4 = AssetTool.FIntVector4;

global using FUInt32Vector2 = AssetTool.FUIntVector2;
global using FUInt32Vector3 = AssetTool.FUIntVector3;
global using FUInt32Vector = AssetTool.FUIntVector3;
global using FUInt32Vector4 = AssetTool.FUIntVector4;

global using FInt64Vector = AssetTool.FInt64Vector3;
global using FUInt64Vector = AssetTool.FUInt64Vector3;

global using FIntVector = AssetTool.FIntVector3;
global using FUIntVector = AssetTool.FUIntVector3;

namespace AssetTool
{
    class RemoveThis
    {
        public uint8 MyUInt8 = 0;
        public uint16 MyUInt16 = 0;
        public uint32 MyUInt32 = 0;
        public uint64 MyUInt64 = 0;
        public int8 MyInt8 = 0;
        public int16 MyInt16 = 0;
        public int32 MyInt32 = 0;
        public int64 MyInt64 = 0;

        public FVector FVector = default;
        public FBox FBox = default;
        public FPlane FPlane = default;
        public FBoxSphereBounds FBoxSphereBounds = default;
        public FSphere FSphere = default;
        public FBox2D FBox2D = default;
        public FRotator FRotator = default;
        public FRay FRay = default;
        public FInt32Vector2 FInt32Vector2 = default;
        public FInt32Vector3 FInt32Vector3 = default;
        public FInt32Vector FInt32Vector = default;
        public FInt32Vector4 FInt32Vector4 = default;
        public FUInt32Vector2 FUInt32Vector2 = default;
        public FUInt32Vector3 FUInt32Vector3 = default;
        public FUInt32Vector FUInt32Vector = default;
        public FUInt32Vector4 FUInt32Vector4 = default;
        public FInt64Vector FInt64Vector = default;
        public FUInt64Vector FUInt64Vector = default;
        public FIntVector FIntVector = default;
        public FUIntVector FUIntVector = default;
    }
}

////// Int points
///using FInt32Point = UE::Math::TIntPoint<int32>;
///using FInt64Point = UE::Math::TIntPoint<int64>;
///using FUint32Point = UE::Math::TIntPoint<uint32>;
///using FUint64Point = UE::Math::TIntPoint<uint64>;

///using FIntPoint = FInt32Point;
///using FUintPoint = FUint32Point;

////// Int rects
///using FInt32Rect = UE::Math::TIntRect<int32>;
///using FInt64Rect = UE::Math::TIntRect<int64>;
///using FUint32Rect = UE::Math::TIntRect<uint32>;
///using FUint64Rect = UE::Math::TIntRect<uint64>;

///using FIntRect = UE::Math::TIntRect<int32>;
///using FUintRect = UE::Math::TIntRect<uint32>;

///using FBoxSphereBounds3f = UE::Math::TBoxSphereBounds<float, float>;
///using FBoxSphereBounds3d = UE::Math::TBoxSphereBounds<double, double>;
///using FCompactBoxSphereBounds3d = UE::Math::TBoxSphereBounds<double, float>;

///using FCompactBoxSphereBounds = FCompactBoxSphereBounds3d;