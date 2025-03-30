namespace AssetTool
{
    [JsonAsset("BodySetup")]
    public class UBodySetup : UBodySetupCore
    {
        public FGuid BodySetupGuid;
        public FBool bCooked;
        public FBool bTemp;
        public FFormatContainer CookedFormatData;
        public List<FImplicitObject> ImplicitObject;

        [Location("void UBodySetup::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            ArrayMovers.Add("VertexData", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));

            base.Move(transfer);

            transfer.Move(ref BodySetupGuid);
            transfer.Move(ref bCooked);

            if (bCooked)
            {
                if (transfer.Supports.VER_UE4_STORE_HASCOOKEDDATA_FOR_BODYSETUP)
                {
                    transfer.Move(ref bTemp);
                }
                transfer.Move(ref CookedFormatData);
            }

            if (transfer.Supports.LevelsetSerializationSupportForBodySetup && !transfer.Supports.DisableLevelset_v14_10)
            {
                transfer.Move(ref ImplicitObject);
            }

            return this;
        }
    }
}