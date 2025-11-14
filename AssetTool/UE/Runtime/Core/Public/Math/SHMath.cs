using System.ComponentModel;
using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("R{R} G{G} B{B}")]
    public class FSHVectorRGB : ITransferable<int>
    {
        public FSHVector R = new();
        public FSHVector G = new();
        public FSHVector B = new();

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVectorRGB& SH)")]
        public ITransferable Move(Transfer transfer, int order)
        {
            R.Move(transfer, order);
            G.Move(transfer, order);
            B.Move(transfer, order);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    [Description("A vector of spherical harmonic coefficients.")]
    [DebuggerDisplay("({string.Join(' ', v)})")]
    public class FSHVector : ITransferable<int>
    {
        public float[] v;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVector& SH)")]
        public ITransferable Move(Transfer transfer, int order)
        {
            int count = GetNumComponents(order);
            transfer.Move(ref v, count);
            return this;
        }

        private static int GetNumComponents(int order)
        {
            if (order == 2)
            {
                int MaxSHOrder = order;
                int MaxSHBasis = MaxSHOrder * MaxSHOrder;
                int NumComponentsPerSIMDVector = 4;
                int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
                int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;
                return NumTotalFloats;
            }
            else if (order == 3)
            {
                int MaxSHOrder = order;
                int MaxSHBasis = MaxSHOrder * MaxSHOrder;
                return MaxSHBasis;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
