using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(TSplineInterface), "TSplineInterface")]
    [JsonDerivedType(typeof(TMultiSpline<TTangentBezierSpline<FVector3d>>), "TMultiSpline<TTangentBezierSpline<FVector3d>>")]
    [JsonDerivedType(typeof(TTangentBezierSpline<FQuat4d>), "TTangentBezierSpline<FQuat4d>")]
    [JsonDerivedType(typeof(TTangentBezierSpline<FVector3d>), "TTangentBezierSpline<FVector3d>")]
    public class ISplineInterface : ITransferable
    {
        public int32 Version;
        public uint32 TypeId;

        [Location("virtual bool Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Version);
            transfer.Move(ref TypeId);
            return this;
        }
    }

    public class TSplineInterface : ISplineInterface
    {
        public uint8 PreMode;
        public uint8 PostMode;

        [Location("virtual bool Serialize(FArchive& Ar) override")]
        public override ITransferable Move(Transfer transfer)
        {
            if (TypeId == 0)
                base.Move(transfer);
            else if (transfer.IsWriting)
                base.Move(transfer);

            transfer.Move(ref PreMode);
            transfer.Move(ref PostMode);
            return this;
        }
    }
}
