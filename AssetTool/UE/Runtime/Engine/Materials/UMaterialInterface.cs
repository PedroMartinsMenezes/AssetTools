namespace AssetTool
{
    [JsonAsset("MaterialInterface")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;
        public UScriptStruct Struct;

        [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(GlobalObjects.Transfer);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.MaterialInterfaceSavedCachedData))
            {
                transfer.Move(ref bSavedCachedExpressionData);
            }
            if (bSavedCachedExpressionData?.Value == true)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer, Struct.Tags);
            }
            return this;
        }
    }
}
