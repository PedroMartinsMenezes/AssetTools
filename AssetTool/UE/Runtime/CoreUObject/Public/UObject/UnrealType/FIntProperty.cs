namespace AssetTool
{
    public class FIntProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public static int MoveValue(Transfer transfer, int value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
