namespace AssetTool
{
    [JsonAsset("K2Node_MacroInstance")]
    public class UK2Node_MacroInstance : UK2Node_Tunnel
    {
        [Location("void UK2Node_MacroInstance::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
