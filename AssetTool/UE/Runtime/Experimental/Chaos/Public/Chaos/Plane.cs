using System.Diagnostics;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("({MPlaneConcrete.MX.X} {MPlaneConcrete.MX.Y} {MPlaneConcrete.MX.Z}) ({MPlaneConcrete.MNormal.X} {MPlaneConcrete.MNormal.Y} {MPlaneConcrete.MNormal.Z})")]
    public class TPlane3 : FImplicitObject
    {
        public TPlaneConcrete MPlaneConcrete;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 322")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            transfer.Move(ref MPlaneConcrete);
            return this;
        }
    }

    [DebuggerDisplay("({MX.X} {MX.Y} {MX.Z}) ({MNormal.X} {MNormal.Y} {MNormal.Z})")]
    public class TPlaneConcrete : ITransferible
    {
        public TVec3 MX;
        public TVec3 MNormal;

        [Location("FORCEINLINE void Serialize(FArchive& Ar) at 230")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref MX);
            transfer.Move(ref MNormal);
            return this;
        }
    }
}
