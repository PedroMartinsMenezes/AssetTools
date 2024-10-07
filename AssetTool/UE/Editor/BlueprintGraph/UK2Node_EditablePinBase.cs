namespace AssetTool
{
    [JsonAsset("K2Node_EditablePinBase")]
    public class UK2Node_EditablePinBase : UK2Node
    {
        public List<FUserPinInfo> SerializedItems = [];

        [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializedItems.Resize(transfer).ForEach(item => item.Move(transfer));
            return this;
        }
    }
}
