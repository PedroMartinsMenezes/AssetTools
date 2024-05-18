namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_EditablePinBase : UK2Node
    {
        [Sized] public List<FUserPinInfo> SerializedItems = [];

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializedItems.Resize(transfer).ForEach(item => item.Move(transfer));
            return this;
        }
    }
}
