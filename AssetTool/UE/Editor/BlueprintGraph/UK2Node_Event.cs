namespace AssetTool
{
    [JsonAsset("K2Node_Event")]
    public class UK2Node_Event : UK2Node_EditablePinBase
    {
        [Location("void UK2Node_Event::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
