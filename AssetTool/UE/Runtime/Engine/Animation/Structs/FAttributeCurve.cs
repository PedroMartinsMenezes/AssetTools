namespace AssetTool
{
    [TransferibleStruct("AttributeCurve")]
    public class FAttributeCurve : ITransferible
    {
        public const string StructName = "AttributeCurve";

        public List<FAttributeKey> Keys;
        public FSoftObjectPath ScriptStructPath;
        public List<UScriptStruct> ScriptStruct;

        [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Keys);
            transfer.Move(ref ScriptStructPath);

            if (!ScriptStructPath.IsNull(transfer))
            {
                ScriptStruct = ScriptStruct.Resize(transfer, Keys.Count);//@@@
                ScriptStruct.ForEach(x => x.SerializeTaggedProperties(transfer));
            }
            return this;
        }
    }
}
