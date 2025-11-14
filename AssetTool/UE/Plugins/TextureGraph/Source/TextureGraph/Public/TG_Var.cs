namespace AssetTool
{
    public class FTG_Var : ITransferable<FTG_Argument>
    {
        public object Value;

        [Location("void FTG_Var::Serialize(FArchive& Ar, FTG_Id InPinId, const FTG_Argument& InArgument)")]
        public ITransferable Move(Transfer transfer, FTG_Argument argument)
        {
            if (!argument.IsPrivate() && argument.IsPersistentSelfVar())
            {
                Value = DefaultArchiveSerializers[argument.TypeName](transfer, Value);
            }
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        [Location("void VarArchiveSerializer_FTG_Texture(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FTG_Texture(Transfer transfer, object value)
        {
            if (transfer.Supports.TGTextureAddedTexturePath)
            {
                value = value.ToObject<FSoftObjectPath>(transfer).MoveComplete(transfer);
            }
            return value;
        }

        [Location("void VarArchiveSerializer_FTG_VariantArray(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FTG_VariantArray(Transfer transfer, object value) => value;

        [Location("void VarArchiveSerializer_FVector4f(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FVector4f(Transfer transfer, object value) => value.ToObject<FVector4f>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_FVector2f(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FVector2f(Transfer transfer, object value) => value.ToObject<FVector2f>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_FLinearColor(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FLinearColor(Transfer transfer, object value) => value.ToObject<FLinearColor>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_int32(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_int32(Transfer transfer, object value) => value.ToObject<TInt32>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_uint32(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_uint32(Transfer transfer, object value) => value.ToObject<TUInt32>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_float(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_float(Transfer transfer, object value) => value.ToObject<TFloat>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_bool(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_bool(Transfer transfer, object value) => value.ToObject<TBool>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_UTexture(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_UTexture(Transfer transfer, object value) => value.ToObject<FSoftObjectPath>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_FTG_OutputSettings(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FTG_OutputSettings(Transfer transfer, object value) => value.ToObject<FTG_OutputSettings>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_FTG_TextureDescriptor(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FTG_TextureDescriptor(Transfer transfer, object value) => value.ToObject<FTG_TextureDescriptor>(transfer).Move(transfer);

        [Location("void VarArchiveSerializer_FTG_Material(FTG_Var::VarArchiveSerialInfo& Info)")]
        static object VarArchiveSerializer_FTG_Material(Transfer transfer, object value) => value.ToObject<FTG_Material>(transfer).Move(transfer);

        private static Dictionary<string, Func<Transfer, object, object>> DefaultArchiveSerializers = new()
        {
            ["FTG_Texture"] = VarArchiveSerializer_FTG_Texture,
            ["FTG_VariantArray"] = VarArchiveSerializer_FTG_VariantArray,
            ["FVector4f"] = VarArchiveSerializer_FVector4f,
            ["FVector2f"] = VarArchiveSerializer_FVector2f,
            ["FLinearColor"] = VarArchiveSerializer_FLinearColor,
            ["int32"] = VarArchiveSerializer_int32,
            ["uint32"] = VarArchiveSerializer_uint32,
            ["float"] = VarArchiveSerializer_float,
            ["bool"] = VarArchiveSerializer_bool,
            ["TObjectPtr<UTexture>"] = VarArchiveSerializer_UTexture,
            ["FTG_OutputSettings"] = VarArchiveSerializer_FTG_OutputSettings,
            ["FTG_TextureDescriptor"] = VarArchiveSerializer_FTG_TextureDescriptor,
            ["FTG_Material"] = VarArchiveSerializer_FTG_Material,
        };
    }
}