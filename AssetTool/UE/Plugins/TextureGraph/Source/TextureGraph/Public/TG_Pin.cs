namespace AssetTool
{
    [JsonAsset("TG_Pin")]
    public class UTG_Pin : UObject
    {
        public FTG_Var SelfVar;
        public FTG_Argument Argument;

        [Location("void UTG_Pin::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Members.FirstOrDefault(x => x.Key.Contains("'Argument'")).Value is Dictionary<string, object> dict)
            {
                Argument ??= new FTG_Argument(dict);
            }
            if (Argument is { })
            {
                transfer.Move(ref SelfVar, Argument);
            }
            return this;
        }

        [Flags]
        public enum ETG_Access : uint8
        {
            In = 0,
            Out = 1,
            InParam = 2,
            OutParam = 3,
            InSetting = 4,
            OutSetting = 5,
            InParamSetting = 6,
            OutParamSetting = 7,
            Private = 8,
            OutputBitMask = 0x01,
            ParamBitMask = 0x02,
            SettingBitMask = 0x04,
            PrivateBitMask = 0x08,
            AccessBitMask = 0x0F,
            PersistentSelfVarFlag = 0x10,
            NotConnectableFlag = 0x20,
            EnumFlag = 0x40,
        }
    }
}