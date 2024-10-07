namespace AssetTool
{
    [JsonAsset("K2Node_AddComponent")]
    public class UK2Node_AddComponent : UK2Node_CallFunction
    {
        [Location("void UK2Node_AddComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
