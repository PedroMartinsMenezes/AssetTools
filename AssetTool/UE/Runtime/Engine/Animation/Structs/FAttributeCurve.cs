namespace AssetTool
{
    [TransferibleStruct("AttributeCurve")]
    public class FAttributeCurve : ITransferible
    {
        public const string StructName = "AttributeCurve";

        public List<FAttributeKey> Keys;
        public FSoftObjectPath ScriptStructPath = new();
        public List<UScriptStruct> scripts = [];

        [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Keys);
            ScriptStructPath.Move2(transfer);

            if (!ScriptStructPath.IsNull(transfer))
            {
                scripts.Resize(transfer, Keys.Count);
                scripts.ForEach(x => x.SerializeTaggedProperties(transfer));
            }
            return this;
        }
    }
}
