namespace AssetTool
{
    [JsonAsset("MaterialInterfaceEditorOnlyData")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public FBool bSavedCachedExpressionData;
        public UScriptStruct Struct;

        [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer);
            }
            return this;
        }
    }

    [JsonAsset("MaterialInterface")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;
        public UScriptStruct Struct;

        public UMaterialInterface()
        {
            ArrayMovers.Add("Expressions", (transfer, value) => value.ToObject<TUInt32>(transfer).Move(transfer));
            ArrayMovers.Add("EditorComments", (transfer, value) => value.ToObject<TUInt32>(transfer).Move(transfer));
        }

        [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.Supports.MaterialInterfaceSavedCachedData)
            {
                transfer.Move(ref bSavedCachedExpressionData);
            }
            if (bSavedCachedExpressionData)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer);
            }
            return this;
        }
    }
}