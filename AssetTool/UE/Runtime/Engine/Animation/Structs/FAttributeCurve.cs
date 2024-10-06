namespace AssetTool
{
    [TransferibleStruct("AttributeCurve")]
    public class FAttributeCurve : ITransferible
    {
        public const string StructName = "AttributeCurve";

        public List<FAttributeKey> Keys = [];
        public FSoftObjectPath ScriptStructPath = new();
        public List<UScriptStruct> scripts = [];

        [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Keys.Resize(transfer).ForEach(x => x.Move(transfer));
            ScriptStructPath.Move(transfer);

            if (!ScriptStructPath.IsNull)
            {
                scripts.Resize(transfer, Keys.Count);
                for (int i = 0; i < Keys.Count; i++)
                {
                    scripts[i] ??= new();
                    UScriptStruct script = scripts[i];
                    script.SerializeTaggedProperties(transfer);
                }
            }
            return this;
        }
    }
}
