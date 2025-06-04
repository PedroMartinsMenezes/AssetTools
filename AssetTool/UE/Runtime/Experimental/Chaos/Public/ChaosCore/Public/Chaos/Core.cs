global using FVec2 = AssetTool.FVector2f;
global using FVec3 = AssetTool.FVector3f;
global using FVec4 = AssetTool.FVector4f;
//global using  FRotation3 = AssetTool.Chaos.TRotation<FReal, 3>;
//global using  FMatrix33 = AssetTool.Chaos.PMatrix<FReal, 3, 3>;
//global using  FMatrix44 = AssetTool.Chaos.PMatrix<FReal, 4, 4>;
//global using  FRigidTransform3 = AssetTool.Chaos.TRigidTransform<FReal, 3>;

global using FAABB3 = AssetTool.Chaos.TAABB3;

global using FVec2f = AssetTool.FVector2f;
global using FVec3f = AssetTool.FVector3f;
//global using  FRotation3f = AssetTool.Chaos.TRotation<FRealSingle, 3>;
//global using  FRigidTransform3f = AssetTool.Chaos.TRigidTransform<FRealSingle, 3>;
//global using  FTransformPair = AssetTool.Chaos.TVector<FRigidTransform3, 2>;

global using FAABB3f = AssetTool.Chaos.TAABB3;

//global using  FRigidTransformRealSingle3 = AssetTool.Chaos.TRigidTransform<FRealSingle, 3>;

global using TVec2 = AssetTool.FVector2f;
global using TVec3 = AssetTool.FVector3f;
global using TVec4 = AssetTool.FVector4f;

//global using  TRotation3 = AssetTool.Chaos.TRotation<T, 3>;

//global using  TMatrix33 = AssetTool.Chaos.PMatrix<T, 3, 3>;

namespace AssetTool
{
    public class Core
    {
        public FVec2 MyFVec2;
        public FVec3 MyFVec3;
        public FVec4 MyFVec4;

        public FAABB3 MyFAABB3;

        public FVec2f MyFVec2f;
        public FVec3f MyFVec3f;

        public FAABB3f MyFAABB3f;

        public TVec2 MyTVec2;
        public TVec3 MyTVec3;
        public TVec4 MyTVec4;
    }
}
