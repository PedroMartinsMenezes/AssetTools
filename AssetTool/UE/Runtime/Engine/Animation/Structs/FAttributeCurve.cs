namespace AssetTool
{
    [TransferableStruct("AttributeCurve")]
    public class FAttributeCurve : ITransferable
    {
        public const string StructName = "AttributeCurve";

        public List<FAttributeKey> Keys;
        public FSoftObjectPath ScriptStructPath;
        public List<UScriptStruct> ScriptStruct;

        [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Keys);
            transfer.Move(ref ScriptStructPath);

            if (!ScriptStructPath.IsNull(transfer))
            {
                transfer.Move(ref ScriptStruct, Keys.Count, x => x.SerializeTaggedProperties(transfer));
            }
            return this;
        }
    }
}
