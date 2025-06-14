//namespace AssetTool
//{
//    [TransferibleStruct("AttributeCurve")]
//    public class FAttributeCurve : ITransferible
//    {
//        public List<FAttributeKey> Keys;
//        public FSoftObjectPath ScriptStructPath;
//        public List<UScriptStruct> ScriptStructs;

//        [Location("bool FAttributeCurve::Serialize(FArchive& Ar)")]
//        public ITransferible Move(Transfer transfer)
//        {
//            transfer.Move(ref Keys);
//            transfer.Move(ref ScriptStructPath);
//            if (!ScriptStructPath.IsNull(transfer) && Keys.Count > 0)
//            {
//                ScriptStructs = ScriptStructs.Resize(transfer, Keys.Count);
//                for (int i = 0; i < Keys.Count; i++)
//                {
//                    ScriptStructs[i].SerializeItem(transfer);
//                }
//            }
//            return this;
//        }
//    }
//}
