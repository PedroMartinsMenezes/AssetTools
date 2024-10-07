namespace AssetTool
{
    public class FRichCurve : ITransferible
    {
        [Location("bool FRichCurveKey::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            ///if (Ar.UEVer() < VER_UE4_SERIALIZE_RICH_CURVE_KEY)
            ///{
            ///    return false;
            ///}
            ///
            ///Ar.UsingCustomVersion(FUE5MainStreamObjectVersion::GUID);
            ///
            ///// Serialization is handled manually to avoid the extra size overhead of FProperty tagging.
            ///// Otherwise with many keys in a rich curve the size can become quite large.
            ///Ar << InterpMode;
            ///Ar << TangentMode;
            ///Ar << TangentWeightMode;
            ///Ar << Time;
            ///Ar << Value;
            ///Ar << ArriveTangent;
            ///Ar << ArriveTangentWeight;
            ///Ar << LeaveTangent;
            ///Ar << LeaveTangentWeight;
            ///
            ///if (Ar.IsLoading())
            ///{
            ///    if (TangentWeightMode != RCTWM_WeightedNone &&
            ///        TangentWeightMode != RCTWM_WeightedArrive &&
            ///        TangentWeightMode != RCTWM_WeightedLeave &&
            ///        TangentWeightMode != RCTWM_WeightedBoth)
            ///    {
            ///        if (Ar.CustomVer(FUE5MainStreamObjectVersion::GUID) < FUE5MainStreamObjectVersion::RichCurveKeyInvalidTangentMode)
            ///        {
            ///            TangentWeightMode = RCTWM_WeightedNone;
            ///
            ///            // No valid weight mode - find correct one one
            ///            const bool bHasArriveWeight = !FMath::IsNearlyZero(ArriveTangentWeight);
            ///            const bool bHasLeaveWeight = !FMath::IsNearlyZero(LeaveTangentWeight);
            ///
            ///            if (bHasArriveWeight && bHasLeaveWeight)
            ///            {
            ///                TangentWeightMode = RCTWM_WeightedBoth;
            ///            }
            ///            else if (bHasArriveWeight)
            ///            {
            ///                TangentWeightMode = RCTWM_WeightedArrive;
            ///            }
            ///            else if (bHasLeaveWeight)
            ///            {
            ///                TangentWeightMode = RCTWM_WeightedLeave;
            ///            }
            ///        }
            ///        else
            ///        {
            ///            ensureMsgf(false, TEXT("FRichCurveKey found with invalid TangentWeightMode value of %i"), static_cast<int32>(TangentWeightMode));
            ///        }
            ///    }
            ///}

            throw new NotImplementedException();
        }
    }
}
