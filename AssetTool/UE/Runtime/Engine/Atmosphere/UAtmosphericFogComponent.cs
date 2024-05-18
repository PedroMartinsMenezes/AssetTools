namespace AssetTool
{
    [Location("void UAtmosphericFogComponent::Serialize(FArchive& Ar)")]
    public class UAtmosphericFogComponent : USkyAtmosphereComponent
    {
        public new const string TypeName = "AtmosphericFogComponent";

        public FByteBulkData TempTransmittanceData = new();
        public FByteBulkData TempIrradianceData = new();
        public FByteBulkData TempInscatterData = new();
        public Int32 CounterVal;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog))
            {
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ATMOSPHERIC_FOG_CACHE_DATA))
                {
                    TempTransmittanceData.Move(transfer);
                    TempIrradianceData.Move(transfer);
                }
                TempInscatterData.Move(transfer);
                transfer.Move(ref CounterVal);
            }
            return this;
        }
    }
}
