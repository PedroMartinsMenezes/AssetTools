using System.ComponentModel;
using System.Diagnostics;

namespace AssetTool
{
    #region 3D
    [DebuggerDisplay("R{R} G{G} B{B}")]
    public class FSHVectorRGB3 : ITransferible
    {
        public FSHVector3 R;
        public FSHVector3 G;
        public FSHVector3 B;

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
    [DebuggerDisplay("({string.Join(' ', v)})")]
    public class FSHVector3 : ITransferible
    {
        const int Order = 3;
        const int MaxSHOrder = Order;
        const int MaxSHBasis = MaxSHOrder * MaxSHOrder;
        ///const int NumComponentsPerSIMDVector = 4;
        ///const int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
        ///const int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;

        public float[] v;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVector& SH)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref v, MaxSHBasis);
            return this;
        }
    }
    #endregion


    #region 2D
    [DebuggerDisplay("R{R} G{G} B{B}")]
    public class FSHVectorRGB2 : ITransferible
    {
        public FSHVector2 R;
        public FSHVector2 G;
        public FSHVector2 B;

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
    [DebuggerDisplay("({string.Join(' ', v)})")]
    public class FSHVector2 : ITransferible
    {
        const int Order = 2;
        const int MaxSHOrder = Order;
        const int MaxSHBasis = MaxSHOrder * MaxSHOrder;
        const int NumComponentsPerSIMDVector = 4;
        const int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
        const int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;

        public float[] v;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref v, NumTotalFloats);
            return this;
        }
    }
    #endregion
}
