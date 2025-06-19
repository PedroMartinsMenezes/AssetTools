using System.ComponentModel;

namespace AssetTool
{
    #region 3D
    public class TSHVectorRGB3 : ITransferible
    {
        public TSHVector3 R;
        public TSHVector3 G;
        public TSHVector3 B;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVectorRGB& SH)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref R);//relative 36
            transfer.Move(ref G);//relative 72
            transfer.Move(ref B);//relative 108
            return this;
        }
    }

    [Description("A vector of spherical harmonic coefficients 3D")]
    public class TSHVector3 : ITransferible
    {
        const int Order = 3;
        const int MaxSHOrder = Order;
        const int MaxSHBasis = MaxSHOrder * MaxSHOrder;
        ///const int NumComponentsPerSIMDVector = 4;
        ///const int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
        ///const int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;

        public float[] V;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVector& SH)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref V, MaxSHBasis);
            return this;
        }
    }
    #endregion


    #region 2D
    public class TSHVectorRGB2 : ITransferible
    {
        public TSHVector2 R;
        public TSHVector2 G;
        public TSHVector2 B;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVectorRGB& SH)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref R);
            transfer.Move(ref G);
            transfer.Move(ref B);
            return this;
        }
    }

    [Description("A vector of spherical harmonic coefficients 2D")]
    public class TSHVector2 : ITransferible
    {
        const int Order = 2;
        const int MaxSHOrder = Order;
        const int MaxSHBasis = MaxSHOrder * MaxSHOrder;
        const int NumComponentsPerSIMDVector = 4;
        const int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
        const int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;

        public float[] V;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref V, NumTotalFloats);
            return this;
        }
    }
    #endregion
}
