namespace AssetTool
{
    [Location("void UAtmosphericFogComponent::Serialize(FArchive& Ar)")]
    public class UAtmosphericFogComponent : USkyAtmosphereComponent
    {
        public new const string TypeName = "AtmosphericFogComponent";

        public FByteBulkData TempTransmittanceData;
        public FByteBulkData TempIrradianceData;
        public FByteBulkData TempInscatterData;
        public Int32 CounterVal;

        public new UAtmosphericFogComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog))
            {
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ATMOSPHERIC_FOG_CACHE_DATA))
                {
                    TempTransmittanceData = new FByteBulkData().Read(reader); ///TempTransmittanceData.Serialize(Ar, this, INDEX_NONE, false);
                    TempIrradianceData = new FByteBulkData().Read(reader); ///TempIrradianceData.Serialize(Ar, this, INDEX_NONE, false);
                }
                TempInscatterData = new FByteBulkData().Read(reader); ///TempInscatterData.Serialize(Ar, this, INDEX_NONE, false);
                reader.Read(ref CounterVal);
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog))
            {
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ATMOSPHERIC_FOG_CACHE_DATA))
                {
                    TempTransmittanceData.Write(writer);
                    TempIrradianceData.Write(writer);
                }
                TempInscatterData.Write(writer);
                writer.Write(CounterVal);
            }
        }
    }
}
