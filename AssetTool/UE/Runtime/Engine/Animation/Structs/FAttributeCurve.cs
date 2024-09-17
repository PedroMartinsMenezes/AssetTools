namespace AssetTool
{
    [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
    public class FAttributeCurve
    {
        public const string StructName = "AttributeCurve";

        public List<FAttributeKey> Keys = [];
        public FSoftObjectPath ScriptStructPath = new();
        public List<UScriptStruct> scripts = [];

        public FAttributeCurve Move(Transfer transfer)
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
                    script.SerializeTaggedProperties(transfer, script.Tags);
                }
            }
            return this;
        }
    }
}
